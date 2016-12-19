﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using CustomControls;

namespace GenTools
{
    public static class GenExtensions
    {
        #region Constants

        private const int HWND_BOTTOM = 1;
        private const int HWND_NOTOPMOST = -2;
        private const int HWND_TOP = 0;
        private const int HWND_TOPMOST = -1;
        private const string MESSAGEBOX_CAPTION = "GenExtensions from ExtensionsLib";
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_SHOWWINDOW = 0x0040;

        #endregion

        public static bool IsInDesignMode
        {
            get
            {
                if (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1 || System.Diagnostics.Debugger.IsAttached)
                    return true;

                return false;
            }
        }

        #region Class Methods

        public static bool AddShortcut(Environment.SpecialFolder destDirectory,
                                       string exeShortcutLink, string exePath, string destSubDirectory = "",
                                       string shortcutDescription = "", string exeIconPath = "") // e.g. "OutlookGoogleCalendarSync.lnk"
        {
            Debug.WriteLine("AddShortcut: directory=" + destDirectory.ToString() + "; subdir=" + destSubDirectory);
            if (destSubDirectory != "") destSubDirectory = "\\" + destSubDirectory;
            var shortcutDir = Environment.GetFolderPath(destDirectory) + destSubDirectory;

            if (!Directory.Exists(shortcutDir))
            {
                Debug.WriteLine("Creating directory " + shortcutDir);
                Directory.CreateDirectory(shortcutDir);
            }

            var shortcutLocation = Path.Combine(shortcutDir, exeShortcutLink);
            // IWshRuntimeLibrary is in the COM library "Windows Script Host Object Model"
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = shell.CreateShortcut(shortcutLocation) as IWshRuntimeLibrary.WshShortcut;

            shortcut.Description = shortcutDescription;
            shortcut.IconLocation = exeIconPath;
            shortcut.TargetPath = exePath;
            shortcut.WorkingDirectory = Application.StartupPath;
            shortcut.Save();
            Debug.WriteLine("Created shortcut " + exeShortcutLink + " in \"" + shortcutDir + "\"");
            return true;
        }

        public static void BenchmarkAction(Action action, int iterations)
        {
            // usage example: GenExtensions.Extensions.Benchmark(LoadSongManager, 1);

            GC.Collect();
            action.Invoke(); // run once outside loop to avoid initialization costs
            var sw = Stopwatch.StartNew();

            for (int i = 0; i < iterations; i++)
                action.Invoke();

            sw.Stop();
            Console.WriteLine(action.Method.Name + " took: " + sw.ElapsedMilliseconds + " (msec)");
        }

        // TODO: develop generic benchmarking for extension methods
        public static void BenchmarkExtension(MethodInfo method, int iterations)
        {
            // usage example: var song = Extensions.BenchmarkAction(DgvExtensions.GetObjectFromFirstSelectedRow<SongData>(dgvCurrent), 1);

            GC.Collect();

            method.Invoke(null, new object[] { }); // run once outside loop to avoid initialization costs
            var sw = Stopwatch.StartNew();

            for (int i = 0; i < iterations; i++)
                method.Invoke(null, new object[] { });

            sw.Stop();
            Console.WriteLine(method.Name + " took: " + sw.ElapsedMilliseconds + " (msec)");
        }

        public static bool CheckShortcut(Environment.SpecialFolder destDirectory, string exeShortcutLink, string destSubDirectory = "")
        {
            Debug.WriteLine("CheckShortcut: directory=" + destDirectory.ToString() + "; subdir=" + destSubDirectory);
            if (destSubDirectory != "") destSubDirectory = "\\" + destSubDirectory;
            var shortcutDir = Environment.GetFolderPath(destDirectory) + destSubDirectory;

            if (!Directory.Exists(shortcutDir)) return false;

            foreach (var file in Directory.GetFiles(shortcutDir))
            {
                if (file.EndsWith(String.Format("{0}{1}", "\\", exeShortcutLink)))
                {
                    Debug.WriteLine("Found shortcut " + exeShortcutLink + " in \"" + shortcutDir + "\"");
                    return true;
                }
            }
            return false;
        }

        public static void CleanDir(this System.IO.DirectoryInfo directory, bool deleteSubDirs = false)
        {
            foreach (FileInfo file in directory.GetFiles()) file.Delete();

            if (deleteSubDirs)
                foreach (DirectoryInfo subDirectory in directory.GetDirectories()) subDirectory.Delete(true);
        }

        public static string CleanForAPI(this string text)
        {
            //return text.Replace("/", "_"); //.Replace("\\","");
            var result = text.Replace("/", "_1_").Replace("\\", "_2_"); //WebUtility.HtmlEncode(text);
            return result; //WebUtility.HtmlDecode(text);
        }

        public static void CleanLocalTemp()
        {
            var di = new DirectoryInfo(Path.GetTempPath());

            // 'Local Settings\Temp' in WinXp
            // 'AppData\Local\Temp' in Win7
            // confirm this is the correct temp directory before deleting
            if (di.Parent != null)
            {
                if (di.Parent.Name.Contains("Local") && di.Name == "Temp")
                {
                    foreach (FileInfo file in di.GetFiles())
                        try
                        {
                            file.Delete();
                        }
                        catch { /*Don't worry just skip locked file*/ }

                    foreach (DirectoryInfo dir in di.GetDirectories())
                        try
                        {
                            dir.Delete(true);
                        }
                        catch { /*Don't worry just skip locked directory*/ }
                }
            }
        }

        public static string CleanName(this string s)
        {
            s = Regex.Replace(s, @"\s+", "");
            s = s.ToLower();

            return s
                .Replace("\\", "")
                .Replace("/", "")
                .Replace("\"", "")
                .Replace("*", "")
                .Replace(":", "")
                .Replace("<", "")
                .Replace(">", "")
                .Replace("'", "")
                .Replace(".", "")
                .Replace("!", "")
                .Replace("?", "")
                .Replace("|", "")
                .Replace("—", "")
                .Replace("’", "")
                .Replace("...", "");
        }

        public static void ClearFolder(string folderName)
        {
            // useage: ClearFolder(Path.GetTempPath()); to empty the Local Temp folder
            // use this method when DeleteDir does not completely empty a folder
            DirectoryInfo dir = new DirectoryInfo(folderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                ClearFolder(di.FullName);
                di.Delete();
            }
        }

        public static DataTable ConvertList<T>(IEnumerable<T> objectList)
        {
            Type type = typeof(T);
            var typeproperties = type.GetProperties();

            DataTable list2DataTable = new DataTable();
            foreach (PropertyInfo propInfo in typeproperties)
            {
                list2DataTable.Columns.Add(new DataColumn(propInfo.Name, propInfo.PropertyType));
            }

            foreach (T listItem in objectList)
            {
                object[] values = new object[typeproperties.Length];
                for (int i = 0; i < typeproperties.Length; i++)
                {
                    values[i] = typeproperties[i].GetValue(listItem, null);
                }

                list2DataTable.Rows.Add(values);
            }

            return list2DataTable;
        }

        public static bool CopyFile(string fileFrom, string fileTo, bool overWrite, bool verbose = true)
        {
            if (verbose)
                if (!PromptOverwrite(fileTo))
                    return false;
                else
                    overWrite = true;

            var fileToDir = Path.GetDirectoryName(fileTo);
            if (!Directory.Exists(fileToDir)) MakeDir(fileToDir);

            try
            {
                File.SetAttributes(fileFrom, FileAttributes.Normal);
                File.Copy(fileFrom, fileTo, overWrite);
                return true;
            }
            catch (IOException e)
            {
                if (!overWrite) return true; // be nice don't throw error
                BetterDialog.ShowDialog(
                    "Could not copy file " + fileFrom + "\r\nError Code: " + e.Message +
                    "\r\nMake sure associated file/folders are closed.",
                    MESSAGEBOX_CAPTION, MessageBoxButtons.OK, Bitmap.FromHicon(SystemIcons.Warning.Handle), "Warning ...", 150, 150);
                return false;
            }
        }

        /// <summary>
        /// Find the IndexOf a target string in a source string
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static int CustomIndexOf(this string source, string target, int position)
        {
            int index = -1;
            for (int i = 0; i < position; i++)
            {
                index = source.IndexOf(target, index + 1, StringComparison.InvariantCultureIgnoreCase);

                if (index == -1)
                    break;
            }
            return index;
        }

        public static void DeleteDirectory(string dirPath, bool includeSubDirs = true)
        {
            const int magicDust = 10;
            for (var gnomes = 1; gnomes <= magicDust; gnomes++)
            {
                try
                {
                    Directory.Delete(dirPath, includeSubDirs);
                }
                catch (DirectoryNotFoundException)
                {
                    return; // ok!
                }
                catch (IOException)
                {
                    // System.IO.IOException: The directory is not empty
                    Debug.WriteLine("Gnomes prevent deletion of {0}! Applying magic dust, attempt #{1}.", dirPath, gnomes);
                    Thread.Sleep(50);
                    continue;
                }
                return;
            }
        }

        public static void DeleteEmptyDirs(this DirectoryInfo dir)
        {
            foreach (DirectoryInfo d in dir.GetDirectories())
                d.DeleteEmptyDirs();

            try
            {
                dir.Delete();
            }
            catch (IOException)
            {
            }
            catch (UnauthorizedAccessException)
            {
            }
        }

        public static void DeleteFile(string filePath)
        {
            const int magicDust = 10;
            for (var gnomes = 1; gnomes <= magicDust; gnomes++)
            {
                try
                {
                    File.SetAttributes(filePath, FileAttributes.Normal);
                    File.Delete(filePath);
                }
                catch (FileNotFoundException)
                {
                    return; // file does not exist
                }
                catch (IOException)
                {
                    // IOException: The process cannot access the file ...
                    Debug.WriteLine("Gnomes prevent deletion of {0}! Applying magic dust, attempt #{1}.", filePath, gnomes);
                    Thread.Sleep(50);
                    continue;
                }
                return;
            }
        }

        public static string DifficultyToDD(this string maxDifficulty)
        {
            return maxDifficulty == "0" ? "No" : "Yes";
        }

        public static void ExtractEmbeddedResource(string outputDir, Assembly resourceAssembly, string resourceLocation, string[] files)
        {
            string resourcePath = String.Empty;
            foreach (string file in files)
            {
                resourcePath = Path.Combine(outputDir, file);
                //always replace with the newest 

                // if (!File.Exists(resourcePath))
                {
                    Stream stream = resourceAssembly.GetManifestResourceStream(String.Format("{0}.{1}", resourceLocation, file));
                    using (FileStream fileStream = new FileStream(resourcePath, FileMode.Create))
                        stream.CopyTo(fileStream);
                    //for (int i = 0; i < stream.Length; i++)
                    //    fileStream.WriteByte((byte)stream.ReadByte());
                }
            }
        }

        public static void ExtractEmbeddedResources(string outputDir, Assembly resourceAssembly, string resourceLocation, bool Overwrite = true)
        {
            var resourcePath = String.Empty;
            var resfiles = resourceAssembly.GetManifestResourceNames().Where(s => s.ToLower().StartsWith(resourceLocation.ToLower()));

            foreach (var file in resfiles)
            {
                // string xFile = file;
                var xFile = file.Replace(resourceLocation + ".", "");
                var parts = xFile.Split('.').ToList();
                var fn = String.Format("{0}.{1}", parts[parts.Count - 2], parts[parts.Count - 1]);
                parts.RemoveRange(parts.Count - 2, 2);
                var xpath = String.Empty;

                foreach (var x in parts)
                    xpath += x + '\\';

                resourcePath = Path.Combine(outputDir, xpath, fn);

                if (!Overwrite && File.Exists(resourcePath))
                    continue;

                var path = Path.GetDirectoryName(resourcePath);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                Stream stream = resourceAssembly.GetManifestResourceStream(file);
                using (FileStream fileStream = new FileStream(resourcePath, FileMode.Create))
                    stream.CopyTo(fileStream);
            }
        }

        public static string GetFullAppVersion()
        {
            Debug.WriteLine("Assembly Name: " + Assembly.GetEntryAssembly().GetName());
            // this can be customized
            return String.Format("{0}.{1}.{2}.{3}",
                                 Assembly.GetEntryAssembly().GetName().Version.Major,
                                 Assembly.GetEntryAssembly().GetName().Version.Minor,
                                 Assembly.GetEntryAssembly().GetName().Version.Build,
                                 Assembly.GetEntryAssembly().GetName().Version.Revision);
        }

        public static string GetResource(string resName)
        {
            // very usefull, move next line before method call to determine valid resource paths and names 
            // string[] names = this.GetType().Assembly.GetManifestResourceNames();
            // for static methods use the following two lines
            // Assembly assem = Assembly.GetExecutingAssembly();
            // string[] names = assem.GetManifestResourceNames();
            //
            Assembly assem = Assembly.GetExecutingAssembly();
            var stream = assem.GetManifestResourceStream(resName);
            if (stream != null)
            {
                var reader = new StreamReader(stream);
                return reader.ReadToEnd();
            }

            BetterDialog.ShowDialog("Error: Could not access resource file " + resName,
                                    MESSAGEBOX_CAPTION, MessageBoxButtons.OK,
                                    Bitmap.FromHicon(SystemIcons.Warning.Handle), "Warning ...", 150, 150);
            return null;
        }

        public static void InvokeIfRequired<T>(this T c, Action<T> action) where T : Control
        {
            if (c.InvokeRequired)
                c.Invoke(new Action(() => action(c)));
            else
                action(c);
        }

        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        public static bool IsFilePathLengthValid(this string filePath)
        {
            if (Environment.OSVersion.Version.Major >= 6 && filePath.Length > 260)
                return false;

            if (Environment.OSVersion.Version.Major < 6 && filePath.Length > 215)
                return false;

            return true;
        }

        public static bool IsFilePathNameValid(this string filePath)
        {
            try
            {
                // check if filePath is null or empty
                if (String.IsNullOrEmpty(filePath))
                    return false;

                // check drive is valid
                var pathRoot = Path.GetPathRoot(filePath);
                if (!Directory.GetLogicalDrives().Contains(pathRoot))
                    return false;

                var fileName = Path.GetFileName(filePath);
                if (String.IsNullOrEmpty(fileName))
                    return false;

                var dirName = Path.GetDirectoryName(filePath);
                if (String.IsNullOrEmpty(dirName))
                    return false;

                if (dirName.IndexOfAny(Path.GetInvalidPathChars()) >= 0)
                    return false;

                if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                    return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }

        public static bool IsFilePathValid(this string filePath)
        {
            if (filePath.IsFilePathLengthValid())
                if (filePath.IsFilePathNameValid())
                    return true;

            return false;
        }

        public static bool IsPathLengthValid(this string filePath)
        {
            if (Environment.OSVersion.Version.Major >= 6 && filePath.Length > 260)
                return false;

            if (Environment.OSVersion.Version.Major < 6 && filePath.Length > 215)
                return false;

            return true;
        }

        public static bool IsPathNameValid(this string filePath)
        {
            try
            {
                // check if filePath is null or empty
                if (String.IsNullOrEmpty(filePath))
                    return false;

                // check drive is valid
                var pathRoot = Path.GetPathRoot(filePath);
                if (!Directory.GetLogicalDrives().Contains(pathRoot))
                    return false;

                var fileName = Path.GetFileName(filePath);
                if (String.IsNullOrEmpty(fileName))
                    return false;

                var dirName = Path.GetDirectoryName(filePath);
                if (String.IsNullOrEmpty(dirName))
                    return false;

                if (dirName.IndexOfAny(Path.GetInvalidPathChars()) >= 0)
                    return false;

                if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                    return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }

        public static DateTime LastWeekDay(DateTime date, DayOfWeek weekday)
        {
            return (from i in Enumerable.Range(0, 7)
                    where date.AddDays(i * -1).DayOfWeek == weekday
                    select date.AddDays(i * -1)).First();
        }

        public static bool MakeDir(string dirPath)
        {
            try
            {
                Directory.CreateDirectory(dirPath);
                return true;
            }
            catch (IOException e)
            {
                BetterDialog.ShowDialog(
                    "Could not create the directory structure.  Error Code: " + e.Message,
                    MESSAGEBOX_CAPTION, MessageBoxButtons.OK, Bitmap.FromHicon(SystemIcons.Warning.Handle), "Warning ...", 150, 150);
                return false;
            }
        }


        public static bool MoveFile(string fileFrom, string fileTo, bool verbose = true)
        {
            if (File.Exists(fileTo))
                if (!verbose)
                    File.Delete(fileTo);
                else if (!PromptOverwrite(fileTo))
                    return false;
                else
                    File.Delete(fileTo);
            else
            {
                var fileToDir = Path.GetDirectoryName(fileTo);
                if (!Directory.Exists(fileToDir))
                    MakeDir(fileToDir);
            }

            try
            {
                File.Copy(fileFrom, fileTo);
                DeleteFile(fileFrom);
                //File.Move(fileFrom, fileTo);
                return true;
            }
            catch (IOException e)
            {
                BetterDialog.ShowDialog(
                    "Could not move the file " + fileFrom + "  Error Code: " + e.Message,
                    MESSAGEBOX_CAPTION, MessageBoxButtons.OK, Bitmap.FromHicon(SystemIcons.Warning.Handle), "Warning ...", 150, 150);
                return false;
            }
        }

        public static DateTime NextWeekDay(DateTime date, DayOfWeek weekday)
        {
            return (from i in Enumerable.Range(0, 7)
                    where date.AddDays(i).DayOfWeek == weekday
                    select date.AddDays(i)).First();
        }

        public static bool PromptOpen(string destDir, string msgText, string windowTitle)
        {
            if (BetterDialog.ShowDialog(msgText + Environment.NewLine +
                                        "Would you like to open the folder?", @"Information: Prompt Open Message",
                                        MessageBoxButtons.YesNo, Bitmap.FromHicon(SystemIcons.Information.Handle),
                                        "Information ...", 150, 150) == DialogResult.Yes)
            {
                if (Directory.Exists(destDir))
                {
                    Process.Start("explorer.exe", String.Format("{0}", destDir));
                    // bring open directory to front
                    var hWnd = WinGetHandle(windowTitle); // e.g. windowTitle = "Custom Game Toolkit"
                    SetWindowPos(hWnd, (IntPtr)HWND_NOTOPMOST, 0, 0, 0, 0,
                                 SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);

                    return true;
                }
            }
            return false;
        }

        public static bool PromptOverwrite(string destPath)
        {
            if (File.Exists(destPath))
            {
                if (BetterDialog.ShowDialog(Path.GetFileName(destPath) + @" already exists." +
                    Environment.NewLine + Environment.NewLine + @"Overwrite the existing file?", @"Warning: Overwrite File Message",
                    MessageBoxButtons.YesNo, Bitmap.FromHicon(SystemIcons.Warning.Handle), "Warning ...", 150, 150)
                    == DialogResult.No)
                    return false;
            }
            return true;
        }

        public static bool RemoveShortcut(Environment.SpecialFolder destDirectory,
                                          string exeShortcutLink, string destSubDirectory = "")
        {
            Debug.WriteLine("RemoveShortcut: directory=" + destDirectory.ToString() + "; subdir=" + destSubDirectory);
            if (destSubDirectory != "") destSubDirectory = "\\" + destSubDirectory;
            var shortcutDir = Environment.GetFolderPath(destDirectory) + destSubDirectory;

            if (!Directory.Exists(shortcutDir))
            {
                Debug.WriteLine("Failed to delete shortcut " + exeShortcutLink + " in \"" + shortcutDir + "\" - directory does not exist.");
                return false;
            }

            foreach (var file in Directory.GetFiles(shortcutDir))
            {
                if (file.EndsWith(String.Format("{0}{1}", "\\", exeShortcutLink)))
                {
                    File.Delete(file);
                    Debug.WriteLine("Deleted shortcut " + exeShortcutLink + " in \"" + shortcutDir + "\"");
                    return true;
                }
            }

            return false;
        }

        public static List<string> RsFilesList(string path, bool includeRs1Packs = false, bool includeSongPacks = false, bool includeSubfolders = true)
        {
            if (String.IsNullOrEmpty(path))
                throw new Exception("<ERROR>: No path provided for file scanning");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            var files = Directory.EnumerateFiles(path, "*_p.psarc", includeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).ToList();
            files.AddRange(Directory.EnumerateFiles(path, "*_p.disabled.psarc", includeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).ToList());
            files = files.Where(file => !file.ToLower().Contains("inlay")).ToList();

            if (!includeRs1Packs)
                files = files.Where(file => !file.ToLower().Contains("rs1compatibility")).ToList();

            if (!includeSongPacks)
                files = files.Where(file => !file.ToLower().Contains("songpack") && !file.ToLower().Contains("_sp_")).ToList();

            return files;
        }

        public static string RunExtExe(string exeFileName, bool appRootFolder = true,
                                       bool runInBackground = false,
                                       bool waitToFinish = false, string arguments = null)
        {
            string appRootPath = Path.GetDirectoryName(Application.ExecutablePath);

            var rootPath = (appRootFolder)
                               ? appRootPath
                               : Path.GetDirectoryName(exeFileName);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = (appRootFolder)
                                     ? Path.Combine(rootPath, exeFileName)
                                     : exeFileName;
            startInfo.WorkingDirectory = rootPath;

            if (runInBackground)
            {
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
            }

            if (!String.IsNullOrEmpty(arguments))
                startInfo.Arguments = arguments;

            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

            if (waitToFinish)
                process.WaitForExit();

            var output = String.Empty;

            if (runInBackground)
                output = process.StandardOutput.ReadToEnd();

            return output;
        }

        public static List<string> RunExtExeAlt(string exeFileName, bool appRootFolder = true,
                                                bool runInBackground = false,
                                                bool waitToFinish = false, string arguments = null)
        {
            string appRootPath = Path.GetDirectoryName(Application.ExecutablePath);

            var rootPath = (appRootFolder)
                               ? appRootPath
                               : Path.GetDirectoryName(exeFileName);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = (appRootFolder)
                                     ? Path.Combine(rootPath, exeFileName)
                                     : exeFileName;
            startInfo.WorkingDirectory = rootPath;

            if (runInBackground)
            {
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
            }

            if (!String.IsNullOrEmpty(arguments))
                startInfo.Arguments = arguments;

            Process process = new Process();
            process.StartInfo = startInfo;

            var output = new List<string>();

            if (runInBackground)
            {
                process.OutputDataReceived += new DataReceivedEventHandler((s, e) =>
                    {
                        output.Add(e.Data);
                    });
            }

            process.Start();

            if (waitToFinish)
                process.BeginOutputReadLine();

            return output;
        }

        /// <summary>
        /// Splits a text string so that it wraps to specified line length
        /// </summary>
        /// <param name="inputText"></param>
        /// <param name="lineLength"></param>
        /// <param name="splitOnSpace"></param>
        /// <returns></returns>
        public static string SplitString(string inputText, int lineLength, bool splitOnSpace = true)
        {
            var finalString = String.Empty;

            if (splitOnSpace)
            {
                var delimiters = new[] { " " }; // , "\\" };
                var stringSplit = inputText.Split(delimiters, StringSplitOptions.None);
                var charCounter = 0;

                for (int i = 0; i < stringSplit.Length; i++)
                {
                    finalString += stringSplit[i] + " ";
                    charCounter += stringSplit[i].Length;

                    if (charCounter > lineLength)
                    {
                        finalString += Environment.NewLine;
                        charCounter = 0;
                    }
                }
            }
            else
            {
                for (int i = 0; i < inputText.Length; i += lineLength)
                {
                    if (i + lineLength > inputText.Length)
                        lineLength = inputText.Length - i;

                    finalString += inputText.Substring(i, lineLength) + Environment.NewLine;
                }
                finalString = finalString.TrimEnd(Environment.NewLine.ToCharArray());
            }

            return finalString;
        }

        public static void TempChangeDirectory(String directory, Action act)
        {
            String old = Directory.GetCurrentDirectory();
            try
            {
                Directory.SetCurrentDirectory(directory);
                act();
            }
            finally
            {
                Directory.SetCurrentDirectory(old);
            }
        }

        public static string ValidateFileName(this string fileName)
        {
            var validFileName = Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), "-"));
            // var validFileName = String.Join("-", valueFileName.Split(Path.GetInvalidFileNameChars()));
            // var validFileName = String.Concat(fileName.Split(Path.GetInvalidFileNameChars()));                        
            return validFileName;
        }

        public static IntPtr WinGetHandle(string windowName)
        {
            IntPtr hWnd = IntPtr.Zero;
            foreach (Process pList in Process.GetProcesses())
            {
                if (pList.MainWindowTitle.Contains(windowName))
                //if (pList.MainWindowTitle.ToLower() == windowName.ToLower())                   
                {
                    hWnd = pList.MainWindowHandle;
                    break;
                }
            }
            return hWnd;
        }

        public static void WriteStreamFile(this Stream memoryStream, string fileName)
        {
            var streamFileDir = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(streamFileDir)) MakeDir(streamFileDir);

            using (
                FileStream file = new FileStream(fileName, FileMode.Create,
                                                 FileAccess.Write))
            {
                byte[] bytes = new byte[memoryStream.Length];
                memoryStream.Read(bytes, 0, (int)memoryStream.Length);
                file.Write(bytes, 0, bytes.Length);
            }
        }

        public static bool WriteTextFile(this string strText, string fileName,
                                         bool bAppend = true)
        {
            var textFileDir = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(textFileDir))
                MakeDir(textFileDir);

            try
            {
                // File.WriteAllText(fileName, strText); // stream of text
                using (TextWriter tw = new StreamWriter(fileName, bAppend))
                {
                    tw.Write(strText); // IMPORTANT no CRLF added to end
                    // tw.WriteLine(strText);  // causes CRLF to be added
                    tw.Close();
                }
                return true;
            }
            catch (IOException e)
            {
                BetterDialog.ShowDialog(
                    "Could not create text file " + fileName + "  Error Code: " +
                    e.Message, MESSAGEBOX_CAPTION, MessageBoxButtons.OK,
                    Bitmap.FromHicon(SystemIcons.Warning.Handle), "Warning ...", 150, 150);
                return false;
            }
        }

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X,
                                                int Y, int cx, int cy, uint uFlags);

        #endregion
    }
}