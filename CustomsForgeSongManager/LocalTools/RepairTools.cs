﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using CustomsForgeSongManager.DataObjects;
using GenTools;
using CustomsForgeSongManager.Forms;
using RocksmithToolkitLib.PsarcLoader;
using RocksmithToolkitLib.DLCPackage;
using RocksmithToolkitLib.Sng;
using RocksmithToolkitLib.Extensions;
using RocksmithToolkitLib.Xml;
using RocksmithToolkitLib.DLCPackage.Manifest.Functions;
using RocksmithToolkitLib;
using Arrangement = RocksmithToolkitLib.DLCPackage.Arrangement;


// DO NOT USE RESHAPER SORT ON THIS METHOD IT RUINS REPAIR OPTIONS OBJECT ORDER
namespace CustomsForgeSongManager.LocalTools
{
    public class RepairTools
    {
        private static bool addedDD;
        private static bool ddError;
        private static bool fixedMax5;
        private static RepairOptions options;
        private static ProgressStatus repairStatus;
        private static StringBuilder sbErrors;

        public static void DoRepairs(object sender, List<SongData> songs, RepairOptions repairOptions)
        {
            options = repairOptions;
            // run new generic worker
            using (var gWorker = new GenericWorker())
            {
                gWorker.WorkDescription = "repairing songs";
                gWorker.BackgroundProcess(sender);
                while (Globals.WorkerFinished == Globals.Tristate.False)
                    Application.DoEvents();
            }
        }

        public static void InitRepairTools()
        {
            GenericWorker.InitReportProgress();
            sbErrors = new StringBuilder();
            options = new RepairOptions();
            repairStatus = new ProgressStatus();
            FileTools.VerifyCfsmFolders();
        }

        public static DLCPackageData MaxFiveArrangements(DLCPackageData packageData)
        {
            const int playableArrLimit = 5; // one based limit
            var playableArrCount = packageData.Arrangements.Count(arr => arr.ArrangementType == ArrangementType.Guitar || arr.ArrangementType == ArrangementType.Bass);
            if (!options.IgnoreStopLimit && playableArrCount <= playableArrLimit)
                return packageData;

            var removalNdx = playableArrCount - playableArrLimit; // zero based index
            var packageDataKept = new DLCPackageData();
            packageDataKept.Arrangements = new List<Arrangement>();

            foreach (var arr in packageData.Arrangements)
            {
                // skip vocal and showlight arrangements
                if (arr.ArrangementType == ArrangementType.Vocal || arr.ArrangementType == ArrangementType.ShowLight)
                    continue;

                var isKept = true;
                var songXml = Song2014.LoadFromFile(arr.SongXml.File);
                var mf = new ManifestFunctions(GameVersion.RS2014);

                if (mf.GetMaxDifficulty(songXml) == 0 && options.RemoveNDD) isKept = false;
                if (arr.ArrangementType == ArrangementType.Bass && options.RemoveBass) isKept = false;
                if (arr.ArrangementType == ArrangementType.Guitar && options.RemoveGuitar) isKept = false;
                if (arr.BonusArr && options.RemoveBonus) isKept = false;
                if (arr.Metronome == Metronome.Generate && options.RemoveMetronome) isKept = false;

                if (isKept || removalNdx == 0)
                {
                    Globals.Log(" - Kept Arrangement: " + arr);
                    packageDataKept.Arrangements.Add(arr);

                    if (packageDataKept.Arrangements.Count == playableArrLimit)
                    {
                        Globals.Log(" - Kept first [" + playableArrLimit + "] arrangements matching the repair criteria");
                        break;
                    }
                }
                else
                {
                    Globals.Log(" - Removed Arrangement: " + arr);
                    if (!options.IgnoreStopLimit)
                        removalNdx--;
                }
            }

            fixedMax5 = true;

            // add back vocals and showlights arrangements
            foreach (var arr in packageData.Arrangements)
                if (arr.ArrangementType == ArrangementType.Vocal || arr.ArrangementType == ArrangementType.ShowLight)
                    packageDataKept.Arrangements.Add(arr);

            // replace original arrangements with kept arrangements
            packageData.Arrangements = packageDataKept.Arrangements;
            return packageData;
        }

        public static bool RemasterSong(string srcFilePath)
        {
            if (options.UsingOrgFiles)
            {
                srcFilePath = FileTools.GetOriginal(srcFilePath);
                if (String.IsNullOrEmpty(srcFilePath))
                    return false;
            }
            else
            {
                if (!FileTools.CreateBackupOfType(srcFilePath, Constants.RemasteredOrgFolder, Constants.EXT_ORG))
                    return false;
            }

            try
            {
                // SNG's needs to be regenerated
                // ArrangmentIDs are stored in multiple place and all need to be updated
                // therefore we are going to unpack, apply repair, and repack
                Globals.Log(" - Extracting CDLC artifacts");
                GenExtensions.InvokeIfRequired(Globals.TsProgressBar_Main.GetCurrentParent(), delegate
                {
                    Globals.TsProgressBar_Main.Value = 35;
                });

                // repair status variables
                addedDD = false;
                ddError = false;
                fixedMax5 = false;

                DLCPackageData packageData;
                using (var psarcOld = new PsarcPackager())
                    packageData = psarcOld.ReadPackage(srcFilePath, options.IgnoreMultitone);

                // TODO: selectively remove arrangements here before remastering
                if (options.RepairMaxFive)
                    packageData = MaxFiveArrangements(packageData);

                var playableArrCount = packageData.Arrangements.Count(arr => arr.ArrangementType == ArrangementType.Guitar || arr.ArrangementType == ArrangementType.Bass);
                if (playableArrCount > 5)
                    throw new CustomException("Maximum playable arrangement limit exceeded");

                // Update arrangement song info
                foreach (Arrangement arr in packageData.Arrangements)
                {
                    if (!options.PreserveStats)
                    {
                        // generate new AggregateGraph
                        arr.SongFile = new RocksmithToolkitLib.DLCPackage.AggregateGraph.SongFile { File = "" };

                        // generate new Arrangement IDs
                        arr.Id = IdGenerator.Guid();
                        arr.MasterId = RandomGenerator.NextInt();
                    }

                    // skip vocal and showlight arrangements
                    if (arr.ArrangementType == ArrangementType.Vocal || arr.ArrangementType == ArrangementType.ShowLight)
                        continue;

                    // validate SongInfo
                    var songXml = Song2014.LoadFromFile(arr.SongXml.File);
                    songXml.AlbumYear = packageData.SongInfo.SongYear.ToString().GetValidYear();
                    songXml.ArtistName = packageData.SongInfo.Artist.GetValidAtaSpaceName();
                    songXml.Title = packageData.SongInfo.SongDisplayName.GetValidAtaSpaceName();
                    songXml.AlbumName = packageData.SongInfo.Album.GetValidAtaSpaceName();
                    songXml.ArtistNameSort = packageData.SongInfo.ArtistSort.GetValidSortableName();
                    songXml.SongNameSort = packageData.SongInfo.SongDisplayNameSort.GetValidSortableName();
                    songXml.AlbumNameSort = packageData.SongInfo.AlbumSort.GetValidSortableName();
                    songXml.AverageTempo = Convert.ToSingle(packageData.SongInfo.AverageTempo.ToString().GetValidTempo());

                    // write updated xml arrangement
                    using (var stream = File.Open(arr.SongXml.File, FileMode.Create))
                        songXml.Serialize(stream, true);

                    // add comments back to xml arrangement   
                    Song2014.WriteXmlComments(arr.SongXml.File, arr.XmlComments);

                    // only add DD to NDD arrangements (unless user specifies otherwise)             
                    var mf = new ManifestFunctions(GameVersion.RS2014);
                    var maxDD = mf.GetMaxDifficulty(songXml);

                    if ((options.AddDD && maxDD == 0) || (options.AddDD && options.OverwriteDD))
                    {
                        // phrase length should be at least 8 to fix chord density bug
                        if (options.PhraseLength < 8) throw new Exception("DD Phrase Length less than eight."); // belt and suspenders code

                        var consoleOutput = String.Empty;
                        var result = DynamicDifficulty.ApplyDD(arr.SongXml.File, options.PhraseLength, options.RemoveSustain, options.RampUpPath, options.CfgPath, out consoleOutput, true);
                        if (result == -1)
                            throw new CustomException("ddc.exe is missing"); // may want to exit the application if this happens

                        if (String.IsNullOrEmpty(consoleOutput))
                        {
                            Globals.Log(" - Added DD to " + arr);
                            addedDD = true;
                        }
                        else
                        {
                            Globals.Log(" - " + arr + " DDC console output: " + consoleOutput);
                            sbErrors.AppendLine(String.Format("{0}, Could not apply DD to: {1}", srcFilePath, arr));
                            ddError = true;
                        }
                    }

                    // put arrangment comments in correct order
                    Song2014.WriteXmlComments(arr.SongXml.File);
                }

                if (!options.PreserveStats)
                    packageData = packageData.AddPackageComment(Constants.TKI_ARRID);

                if (options.RepairMaxFive && fixedMax5)
                    packageData = packageData.AddPackageComment(Constants.TKI_MAX5);

                if (options.AddDD && addedDD)
                    packageData = packageData.AddPackageComment(Constants.TKI_DDC);

                // add comment to ToolkitInfo to identify Remastered CDLC
                packageData = packageData.AddPackageComment(Constants.TKI_REMASTER);
                // add default package version if missing
                if (String.IsNullOrEmpty(packageData.ToolkitInfo.PackageVersion))
                    packageData.ToolkitInfo.PackageVersion = "1";
                else
                    packageData.ToolkitInfo.PackageVersion = packageData.ToolkitInfo.PackageVersion.GetValidVersion();

                // validate packageData (important)
                packageData.Name = packageData.Name.GetValidKey(); // DLC Key                 
                Globals.Log(" - Repackaging Remastered CDLC");
                GenExtensions.InvokeIfRequired(Globals.TsProgressBar_Main.GetCurrentParent(), delegate
                {
                    Globals.TsProgressBar_Main.Value = 70;
                });

                // regenerates the SNG with the repair and repackages               
                using (var psarcNew = new PsarcPackager(true))
                    psarcNew.WritePackage(srcFilePath, packageData);

                Globals.Log(String.Format(" - {0}", options.PreserveStats ? "Preserved Song Stats" : "Reset Song Stats"));
                if (options.UsingOrgFiles)
                    Globals.Log(" - Used [" + Constants.EXT_ORG + "] File");
                if (addedDD)
                    Globals.Log(" - Added Dynamic Difficulty");
                if (!ddError)
                    Globals.Log(" - Repair was successful");
                else
                    Globals.Log(" - Repair was successful, but DD could not be applied");

                if (!options.ProcessDLFolder)
                {
                    // update/rescan just one CDLC in the bound SongCollection ... very cool lovro
                    // gets contents of archive after it has been repaired
                    using (var browser = new PsarcBrowser(srcFilePath))
                    {
                        var songInfo = browser.GetSongData();
                        var song = Globals.SongCollection.FirstOrDefault(s => s.FilePath == srcFilePath);
                        int index = Globals.SongCollection.IndexOf(song);
                        Globals.SongCollection[index] = songInfo.First();
                    }
                }
            }
            catch (CustomException ex)
            {
                Globals.Log(" - Repair failed ... " + ex.Message);
                Globals.Log(" - See '" + Path.GetFileName(Constants.RepairsErrorLogPath) + "' file");

                if (ex.Message.Contains("Maximum"))
                {
                    //  copy (org) to maximum (max), delete backup (org), delete original
                    var properExt = Path.GetExtension(srcFilePath);
                    var orgFilePath = String.Format(@"{0}{1}{2}", Path.Combine(Constants.RemasteredOrgFolder, Path.GetFileNameWithoutExtension(srcFilePath)), Constants.EXT_ORG, properExt).Trim();
                    var maxFilePath = String.Format(@"{0}{1}{2}", Path.Combine(Constants.RemasteredMaxFolder, Path.GetFileNameWithoutExtension(srcFilePath)), Constants.EXT_MAX, properExt).Trim();
                    File.SetAttributes(orgFilePath, FileAttributes.Normal);
                    File.SetAttributes(srcFilePath, FileAttributes.Normal);
                    File.Copy(orgFilePath, maxFilePath, true);
                    File.Delete(orgFilePath);
                    File.Delete(srcFilePath);
                    sbErrors.AppendLine(String.Format("{0}, Maximum playable arrangement limit exceeded", maxFilePath));

                    return false;
                }
            }
            catch (Exception ex)
            {
                Globals.Log(" - Repair failed ... " + ex.Message);
                Globals.Log(" - See '" + Path.GetFileName(Constants.RepairsErrorLogPath) + "' file");

                //  copy (org) to corrupt (cor), delete backup (org), delete original
                var properExt = Path.GetExtension(srcFilePath);
                var orgFilePath = String.Format(@"{0}{1}{2}", Path.Combine(Constants.RemasteredOrgFolder, Path.GetFileNameWithoutExtension(srcFilePath)), Constants.EXT_ORG, properExt).Trim();
                var corFilePath = String.Format(@"{0}{1}{2}", Path.Combine(Constants.RemasteredCorFolder, Path.GetFileNameWithoutExtension(srcFilePath)), Constants.EXT_COR, properExt).Trim();
                File.SetAttributes(orgFilePath, FileAttributes.Normal);
                File.SetAttributes(srcFilePath, FileAttributes.Normal);
                File.Copy(orgFilePath, corFilePath, true);
                File.Delete(orgFilePath);
                File.Delete(srcFilePath);
                sbErrors.AppendLine(String.Format("{0}, Corrupt CDLC", corFilePath));

                return false;
            }

            return true;
        }

        // CAREFUL ... this is called from a background worker ... threading issues
        public static StringBuilder RepairSongs(List<SongData> songs, RepairOptions repairOptions)
        {
            InitRepairTools();
            options = repairOptions;

            // make sure 'dlc' folder is clean
            FileTools.CleanDlcFolder();
            Globals.Log("Applying selected repairs to CDLC ...");
            var srcFilePaths = new List<string>();

            if (options.UsingOrgFiles)
            {
                Globals.Log("Using (.org) files for all repairs ...");
                srcFilePaths = Directory.EnumerateFiles(Constants.RemasteredOrgFolder, "*" + Constants.EXT_ORG + "*").ToList();
            }
            else if (options.ProcessDLFolder)
            {
                // TODO: maybe make sure new CDLC have been unzipped/unrar'd first
                // AppSettings.Instance.DownloadsDir is (must be) validated before being used by the bWorker
                var dlDirPath = AppSettings.Instance.DownloadsDir;
                if (!String.IsNullOrEmpty(dlDirPath))
                {
                    Globals.Log("Repairing CDLC files from: " + dlDirPath + " ...");
                    srcFilePaths = Directory.EnumerateFiles(dlDirPath, "*.psarc").ToList();
                }
                else
                    Globals.Log("<ERROR> 'Downloads' directory path is not set properly ...");
            }
            else
                srcFilePaths = FileTools.SongFilePaths(songs);

            var total = srcFilePaths.Count;
            int processed = 0, failed = 0, skipped = 0;
            GenericWorker.InitReportProgress();

            foreach (var srcFilePath in srcFilePaths)
            {
                var isSkipped = false;
                Globals.Log("Processing: " + Path.GetFileName(srcFilePath));
                processed++;
                GenericWorker.ReportProgress(processed, total, skipped, failed);

                var isOfficialRepairedDisabled = FileTools.IsOfficialRepairedDisabled(srcFilePath);
                if (!String.IsNullOrEmpty(isOfficialRepairedDisabled))
                {
                    if (isOfficialRepairedDisabled.Contains("Official"))
                    {
                        Globals.Log(" - Skipped ODLC File");
                        skipped++;
                        isSkipped = true;
                    }

                    if (isOfficialRepairedDisabled.Contains("Remastered") && options.SkipRemastered)
                    {
                        Globals.Log(" - Skipped Remastered File");
                        skipped++;
                        isSkipped = true;
                    }

                    if (isOfficialRepairedDisabled.Contains("Disabled"))
                    {
                        Globals.Log(" - Skipped Disabled File");
                        skipped++;
                        isSkipped = true;
                    }
                }

                // remaster the CDLC file
                if (!isSkipped)
                {
                    var rSucess = RemasterSong(srcFilePath);
                    if (!rSucess)
                    {
                        var lines = sbErrors.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        if (lines.Last().ToLower().Contains("maximum"))
                            Globals.Log(Path.GetFileName(srcFilePath) + " - Exceeds Playable Arrangements Limit ... Moved file to 'maxfive' subfolder");
                        else
                            Globals.Log(Path.GetFileName(srcFilePath) + " - Corrupt CDLC ... Moved file to 'corrupt' subfolder");

                        failed++;

                        // remove corrupt CDLC from SongCollection
                        var song = Globals.SongCollection.FirstOrDefault(s => s.FilePath == srcFilePath);
                        int index = Globals.SongCollection.IndexOf(song);
                        Globals.SongCollection.AllowRemove = true;
                        Globals.SongCollection.RemoveAt(index);
                        Globals.ReloadSongManager = true; // set quick reload flag
                    }
                }

                // move new CDLC from the 'Downloads' folder to the 'dlc' folder
                if (options.ProcessDLFolder)
                {
                    var destFilePath = Constants.Rs2DlcFolder;
                    var cdlcFolderPath = Path.Combine(Constants.Rs2DlcFolder, "cdlc");

                    if(Directory.Exists(cdlcFolderPath))
                        destFilePath = cdlcFolderPath;
                   
                    destFilePath = Path.Combine(destFilePath, Path.GetFileName(srcFilePath));
                    
                    GenExtensions.MoveFile(srcFilePath, destFilePath);
                    Globals.Log(" - Moved new CDLC to 'dlc' folder");
                    Globals.ReloadSongManager = true; // set quick reload flag

                    // add new repaired 'Downloads' CDLC to the SongCollection
                    using (var browser = new PsarcBrowser(destFilePath))
                    {
                        var songInfo = browser.GetSongData();
                        Globals.SongCollection.Add(songInfo.First());
                    }
                }

                if (!Constants.DebugMode)
                {
                    // cleanup after every nth record
                    if (processed % 50 == 0)
                        GenExtensions.CleanLocalTemp();
                }
            }

            GenericWorker.ReportProgress(processed, total, skipped, failed);

            if (processed > 0)
            {
                Globals.Log("CDLC repair completed ...");
                Globals.ReloadSongManager = true;

                if (!Constants.DebugMode)
                    GenExtensions.CleanLocalTemp();
            }
            else
                Globals.Log("No CDLC were repaired ...");

            if (!String.IsNullOrEmpty(sbErrors.ToString())) //failed > 0)
            {
                // error log can be turned into CSV file
                sbErrors.Insert(0, "File Path, Error Message" + Environment.NewLine);
                sbErrors.Insert(0, DateTime.Now.ToString("MM-dd-yy HH:mm") + Environment.NewLine);
                using (TextWriter tw = new StreamWriter(Constants.RepairsErrorLogPath, true))
                {
                    tw.WriteLine(sbErrors + Environment.NewLine);
                    tw.Close();
                }

                Globals.Log("Saved error log to: " + Constants.RepairsErrorLogPath + " ...");
            }

            return sbErrors;
        }

        public static void ViewErrorLog()
        {
            string stringLog;

            if (!File.Exists(Constants.RepairsErrorLogPath))
                stringLog = Path.GetFileName(Constants.RepairsErrorLogPath) + " is empty ...";
            else
            {
                stringLog = Constants.RepairsErrorLogPath + Environment.NewLine;
                stringLog = stringLog + File.ReadAllText(Constants.RepairsErrorLogPath);
                stringLog = stringLog + Environment.NewLine + AppSettings.Instance.LogFilePath + Environment.NewLine;
                stringLog = stringLog + File.ReadAllText(AppSettings.Instance.LogFilePath);
            }

            using (var noteViewer = new frmNoteViewer())
            {
                noteViewer.Text = String.Format("{0} . . . {1}", noteViewer.Text, "Remastered Error Log");
                noteViewer.Width = 700;
                noteViewer.PopulateText(stringLog);
                noteViewer.ShowDialog();
            }
        }
    }

    internal class CustomException : Exception
    {
        public CustomException() : base() { }
        public CustomException(string message) : base(message) { }
    }

    [Serializable]
    public class RepairOptions
    {
        // this object order reflects in the apperance of the settings xml file
        // DO NOT SORT THIS CLASS

        private string _cfgPath;
        private int _phraseLen;
        private string _rampUpPath;

        public bool SkipRemastered { get; set; }
        public bool UsingOrgFiles { get; set; }
        public bool AddDD { get; set; }

        public int PhraseLength
        {
            get { return _phraseLen < 8 ? (_phraseLen = 8) : _phraseLen; }
            set { _phraseLen = value; }
        }

        public bool RemoveSustain { get; set; }

        public string CfgPath
        {
            get { return _cfgPath ?? (_cfgPath = String.Empty); }
            set { _cfgPath = value; }
        }

        public string RampUpPath
        {
            get { return _rampUpPath ?? (_rampUpPath = String.Empty); }
            set { _rampUpPath = value; }
        }

        public bool OverwriteDD { get; set; }
        //
        public bool RepairMastery { get; set; }
        public bool PreserveStats { get; set; }
        public bool IgnoreMultitone { get; set; }
        //
        public bool RepairMaxFive { get; set; }
        public bool RemoveNDD { get; set; }
        public bool RemoveBass { get; set; }
        public bool RemoveGuitar { get; set; }
        public bool RemoveBonus { get; set; }
        public bool RemoveMetronome { get; set; }
        public bool IgnoreStopLimit { get; set; }
        //
        public bool RemoveSections { get; set; }
        //
        public bool ProcessDLFolder { get; set; }
    }

}
