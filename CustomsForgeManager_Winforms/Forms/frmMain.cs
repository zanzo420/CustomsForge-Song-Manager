﻿using System;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomsForgeManager_Winforms.Controls;
using CustomsForgeManager_Winforms.lib;
using CustomsForgeManager_Winforms.Logging;
using CustomsForgeManager_Winforms.Utilities;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.IO.Compression;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;
using Antlr4.StringTemplate;

namespace CustomsForgeManager_Winforms.Forms
{
    public partial class frmMain : Form
    {
        private bool allSelected = false;
        private bool sortDescending = true;
        private readonly Log myLog;
        private Settings mySettings;
        private Stopwatch counterStopwatch = new Stopwatch();
        private int numberOfDLCPendingUpdate = 0;
        private int numberOfDisabledDLC = 0;

        private BindingList<SongData> SongCollection = new BindingList<SongData>();
        private List<SongData> DupeCollection = new List<SongData>();
        private List<SongData> SortedSongCollection = new List<SongData>();
        private Dictionary<string, SongData> OutdatedSongList = new Dictionary<string, SongData>();

        private frmMain()
        {
            throw new Exception("Improper constructor used");
        }
        public frmMain(Log myLog, Settings mySettings)
        {
            // TODO: Complete member initialization
            this.myLog = myLog;
            this.mySettings = mySettings;

            InitializeComponent();
            this.renamerPropertyDataGridView.AutoGenerateColumns = true;
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                using (Stream stream = assembly.GetManifestResourceStream("CustomsForgeManager_Winforms.Resources.renamer_properties.json"))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string json = reader.ReadToEnd();
                    this.renamerPropertyDataSet = (System.Data.DataSet)JsonConvert.DeserializeObject(json, (typeof(System.Data.DataSet)));
                    this.renamerPropertyDataGridView.DataSource = this.renamerPropertyDataSet.Tables[0];

                };
            }
            catch (Exception e)
            {
                this.myLog.Write(e.Message);
            }
      
            Init();
        }
        private void Init()
        {
            #region Create directory structure if not exists

            string configFolderPath = Constants.DefaultWorkingDirectory;
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
                Log(string.Format("Working directory created at {0}", configFolderPath));
            }

            #endregion

            #region Logging setup

            myLog.AddTargetFile(mySettings.LogFilePath);
            myLog.AddTargetTextBox(tbLog);
            myLog.AddTargetNotifyIcon(notifyIcon_Main);

            #endregion

            #region Load Settings file and deserialize to Settings class
            LoadSettingsFromFile();
            #endregion

            if (ApplicationDeployment.IsNetworkDeployed)
                Log(string.Format("Application loaded, using version: {0}", ApplicationDeployment.CurrentDeployment.CurrentVersion), 100);

            if (mySettings.RescanOnStartup)
                BackgroundScan();
            else
                LoadSongCollectionFromFile();

            lbl_AppVersion.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        private void BackgroundScan()
        {
            bWorker = new AbortableBackgroundWorker();
            bWorker.SetDefaults();

            toolStripStatusLabel_MainCancel.Visible = true;
            bWorker.DoWork += PopulateListHandler;
            bWorker.RunWorkerCompleted += PopulateCompletedHandler;
            bWorker.RunWorkerAsync();
        }
        void PopulateCompletedHandler(object sender, RunWorkerCompletedEventArgs e)
        {
            PopulateDataGridView();
            SaveSongCollectionToFile();
            ToggleUIControls();
            PopulateColumnList();
            toolStripStatusLabel_MainCancel.Visible = false;
        }
        void PopulateListHandler(object sender, DoWorkEventArgs e)
        {
            ToggleUIControls();
            PopulateSongList();
            PopulateDupeList();
        }

        private void PopulateColumnList()
        {
            listDisabledColumns.Items.Clear();
            foreach (DataGridViewColumn col in dgvSongs.Columns)
            {
                listDisabledColumns.Items.Add(new ListViewItem(new[] { "", col.HeaderText, col.Visible ? "Yes" : "No" }));
            }
        }

        private void PopulateSongList()
        {
            Log("Scanning for songs...");
            dgvSongs.InvokeIfRequired(delegate
            {
                var dataGridViewColumn = dgvSongs.Columns["colSelect"];
                if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
                dgvSongs.DataSource = null;
                SongCollection.Clear();
            });
            string enabled = "";
            int counter = 1;
            List<string> filesList = new List<string>(FilesList(mySettings.RSInstalledDir + "\\dlc", mySettings.IncludeRS1DLCs));
            //List<string> disabledFilesList = new List<string>(FilesList(mySettings.RSInstalledDir + "\\" + Constants.DefaultDisabledSubDirectory,mySettings.IncludeRS1DLCs));
            //filesList.AddRange(disabledFilesList);
            counterStopwatch.Start();
            foreach (string file in filesList)
            {
                if (!bWorker.CancellationPending)
                {
                    Progress(counter++ * 100 / filesList.Count);

                    if (file.Contains(".disabled."))
                    {
                        enabled = "No";
                    }
                    else
                    {
                        enabled = "Yes";
                    }

                    try
                    {
                        var browser = new PsarcBrowser(file);
                        var songInfo = browser.GetSongs();
                        foreach (SongData songData in songInfo.Distinct())
                        {
                            songData.Enabled = enabled;
                            if (songData.Version == "N/A")
                            {
                                string fileNameVersion = songData.GetVersionFromFileName();
                                if (fileNameVersion != "")
                                    songData.Version = fileNameVersion;
                            }
                            if (songData.ToolkitVer == "")
                            {
                                if (songData.FileName.Contains("rs1comp"))
                                    SongCollection.Add(songData);
                            }
                            else
                                SongCollection.Add(songData);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.StartsWith("Error reading JObject"))
                        {
                            Log("<ERROR>: " + file + ":" + "DLC is corrupt!");
                        }
                        else
                        {
                            Log("<ERROR>: " + file + ":" + ex.Message);
                        }
                    }
                    finally
                    {
                        toolStripStatusLabel_Main.Text = string.Format("{0} songs found...", counter);
                    }
                }
            }
            dgvSongs.InvokeIfRequired(delegate
            {
                var dataGridViewColumn = dgvSongs.Columns["colSelect"];
                if (dataGridViewColumn != null) dataGridViewColumn.Visible = true;
                dgvSongs.DataSource = SongCollection;
            });
        }
        private void PopulateDupeList()
        {
            var dups = SongCollection.GroupBy(x => new { x.Song, x.Album, x.Artist })
                        .Where(group => group.Count() > 1)
                        .SelectMany(group => group).ToList();

            if (dups.Count > 0)
            {
                foreach (var song in dups)
                {
                    listDupeSongs.InvokeIfRequired(delegate
                    {
                        listDupeSongs.Items.Add(new ListViewItem(new[] { " ", song.Artist, song.Song, song.Album, song.Path }));
                    });
                }
            }

            DupeCollection.AddRange(dups);

            tpDuplicates.InvokeIfRequired(delegate
            {
                tpDuplicates.Text = "Duplicates(" + dups.Count.ToString() + ")";
            });
        }
        private void PopulateDataGridView()
        {
            toolStripStatusLabel_Main.Text = string.Format("{0} total Rocksmith songs found", SongCollection.Count);


            dgvSongs.InvokeIfRequired(delegate
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = SongCollection;
                dgvSongs.DataSource = bs;
                dgvSongs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                SortedSongCollection = SongCollection.ToList();
                if (mySettings.ManagerGridSettings != null)
                    dgvSongs.ReLoadColumnOrder(mySettings.ManagerGridSettings.ColumnOrder);
                dgvSongs.Columns["colSelect"].Visible = true;
                dgvSongs.Columns["colSelect"].DisplayIndex = 0;
            });

            numberOfDisabledDLC = SongCollection.Where(song => song.Enabled == "No").ToList().Count();
            numberOfDLCPendingUpdate = 0;

            toolStripStatusLabel_DisabledCounter.Visible = true;
            toolStripStatusLabel_DisabledCounter.Alignment = ToolStripItemAlignment.Right;
            toolStripStatusLabel_DisabledCounter.Text = "Outdated: " + numberOfDLCPendingUpdate + " | Disabled DLC: " + numberOfDisabledDLC.ToString();

            counterStopwatch.Stop();
            Log(string.Format("Finished. Task took {0}", counterStopwatch.Elapsed));

            Log("Finished scanning songs...", 100);
        }

        #region Settings
        private void ResetSettings()
        {
            mySettings = new Settings();
            mySettings.LogFilePath = Constants.DefaultWorkingDirectory + "\\debug.log";
            mySettings.RSInstalledDir = GetInstallDirFromRegistry();
            mySettings.RescanOnStartup = true;
            mySettings.IncludeRS1DLCs = false;
        }
        private void SaveSettingsToFile(string path = "")
        {
            if (string.IsNullOrEmpty(path))
                path = Constants.DefaultWorkingDirectory + "\\settings.bin";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                if (mySettings == null)
                {
                    mySettings = new Settings();
                    mySettings.LogFilePath = Constants.DefaultWorkingDirectory + Constants.DefaultLogName;
                    mySettings.RSInstalledDir = tbSettingsRSDir.Text;
                    mySettings.RescanOnStartup = true;
                    mySettings.IncludeRS1DLCs = false;
                    Log("Default settings created...");
                }
                if (!string.IsNullOrEmpty(tbSettingsRSDir.Text))
                    mySettings.RSInstalledDir = tbSettingsRSDir.Text;
                mySettings.RescanOnStartup = checkRescanOnStartup.Checked;
                mySettings.IncludeRS1DLCs = checkIncludeRS1DLC.Checked;

                RADataGridViewSettings settings = new RADataGridViewSettings();
                var columns = dgvSongs.Columns;

                if (columns.Count > 1)
                {
                    for (int i = 0; i < columns.Count; i++)
                    {
                        settings.ColumnOrder.Add(new ColumnOrderItem
                        {
                            ColumnIndex = i,
                            DisplayIndex = columns[i].DisplayIndex,
                            Visible = columns[i].Visible,
                            Width = columns[i].Width
                        });
                    }
                    mySettings.ManagerGridSettings = settings;
                }
                mySettings.Serialze(fs);
                Log("Saved settings...");
                fs.Close();
            }
        }
        private void LoadSettingsFromFile(string path = "")
        {
            //Dictionary<string, List<ColumnOrderItem>> columnOrder = new Dictionary<string, List<ColumnOrderItem>>();
            try
            {
                if (string.IsNullOrEmpty(path))
                    path = Constants.DefaultWorkingDirectory + "\\settings.bin";
                if (!File.Exists(path))
                {
                    using (FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write, FileShare.Write))
                    {
                        ResetSettings();
                        Log("Settings file created...");
                        fs.Close();
                    }
                    SaveSettingsToFile(path);
                }
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    Settings deserialized = fs.DeSerialize() as Settings;
                    if (deserialized != null)
                    {
                        mySettings = deserialized;

                        tbSettingsRSDir.InvokeIfRequired(delegate
                        {
                            tbSettingsRSDir.Text = mySettings.RSInstalledDir;
                        });
                        checkRescanOnStartup.InvokeIfRequired(delegate
                        {
                            checkRescanOnStartup.Checked = mySettings.RescanOnStartup;
                        });
                        if (mySettings.ManagerGridSettings != null)
                        {
                            dgvSongs.ReLoadColumnOrder(mySettings.ManagerGridSettings.ColumnOrder);
                        }
                        checkIncludeRS1DLC.InvokeIfRequired(delegate
                        {
                            checkIncludeRS1DLC.Checked = mySettings.IncludeRS1DLCs;
                        });
                        Log("Loaded settings...");
                    }
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                Log(string.Format("<Error>: {0}", ex.Message));
            }
        }
        #endregion

        private void SaveSongCollectionToFile()
        {
            string path = Constants.DefaultWorkingDirectory + "\\songs.bin";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                SongCollection.Serialze(fs);
                Log("Song collection saved...");
                fs.Close();
            }
        }
        private void LoadSongCollectionFromFile()
        {
            string path = Constants.DefaultWorkingDirectory + "\\songs.bin";
            if (!File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write, FileShare.Write))
                {
                    BackgroundScan();
                    Log("Song collection file created...");
                    fs.Close();
                }
                SaveSettingsToFile(path);
            }
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                BindingList<SongData> songs = fs.DeSerialize() as BindingList<SongData>;
                if (songs != null)
                {
                    SongCollection = songs;
                    Log("Song collection loaded...");
                    fs.Close();
                    PopulateDataGridView();
                }
            }
        }
        private void ToggleUIControls()
        {
            btnRescan.InvokeIfRequired(delegate
            {
                btnRescan.Enabled = !btnRescan.Enabled;
            });

            btnCheckAllForUpdates.InvokeIfRequired(delegate
            {
                btnCheckAllForUpdates.Enabled = !btnCheckAllForUpdates.Enabled;
            });

            btnBatchRenamer.InvokeIfRequired(delegate
            {
                btnBatchRenamer.Enabled = !btnBatchRenamer.Enabled;
            });

            //Uncomment after implementing:
            //btnEditDLC.Enabled = !btnEditDLC.Enabled;
            //btnBackupDLC.Enabled = !btnBackupDLC.Enabled;
            //btnSaveDLC.Enabled = !btnSaveDLC.Enabled;
            //btnDLCPage.Enabled = !btnDLCPage.Enabled;

            checkRescanOnStartup.InvokeIfRequired(delegate
            {
                checkRescanOnStartup.Enabled = !checkRescanOnStartup.Enabled;
            });

            btnBackupRSProfile.InvokeIfRequired(delegate
            {
                btnBackupRSProfile.Enabled = !btnBackupRSProfile.Enabled;
            });

            btnSearch.InvokeIfRequired(delegate
            {
                btnSearch.Enabled = !btnSearch.Enabled;
            });

            btnSettingsSave.InvokeIfRequired(delegate
            {
                btnSettingsSave.Enabled = !btnSettingsSave.Enabled;
            });

            btnSettingsLoad.InvokeIfRequired(delegate
            {
                btnSettingsLoad.Enabled = !btnSettingsLoad.Enabled;
            });

            tbSearch.InvokeIfRequired(delegate
            {
                tbSearch.Enabled = !tbSearch.Enabled;
            });

            tbSettingsRSDir.InvokeIfRequired(delegate
            {
                tbSettingsRSDir.Enabled = !tbSettingsRSDir.Enabled;
            });

            btnDupeRescan.InvokeIfRequired(delegate
            {
                btnDupeRescan.Enabled = !btnDupeRescan.Enabled;
            });

            btnDeleteDupeSong.InvokeIfRequired(delegate
            {
                btnDeleteDupeSong.Enabled = !btnDeleteDupeSong.Enabled;
            });

            btnDisableEnableSongs.InvokeIfRequired(delegate
            {
                btnDisableEnableSongs.Enabled = !btnDisableEnableSongs.Enabled;
            });

            btnExportSongList.InvokeIfRequired(delegate
            {
                btnExportSongList.Enabled = !btnExportSongList.Enabled;
            });

            radioBtn_ExportToBBCode.InvokeIfRequired(delegate
            {
                radioBtn_ExportToBBCode.Enabled = !radioBtn_ExportToBBCode.Enabled;
            });

            radioBtn_ExportToCSV.InvokeIfRequired(delegate
            {
                radioBtn_ExportToCSV.Enabled = !radioBtn_ExportToCSV.Enabled;
            });

            radioBtn_ExportToHTML.InvokeIfRequired(delegate
            {
                radioBtn_ExportToHTML.Enabled = !radioBtn_ExportToHTML.Enabled;
            });

            checkIncludeRS1DLC.InvokeIfRequired(delegate
            {
                checkIncludeRS1DLC.Enabled = !checkIncludeRS1DLC.Enabled;
            });

            linkLblSelectAll.InvokeIfRequired(delegate
            {
                linkLblSelectAll.Enabled = !linkLblSelectAll.Enabled;
            });

            link_MainClearResults.InvokeIfRequired(delegate
            {
                link_MainClearResults.Enabled = !link_MainClearResults.Enabled;
            });

            lbl_ExportTo.InvokeIfRequired(delegate
            {
                lbl_ExportTo.Enabled = !lbl_ExportTo.Enabled;
            });
        }

        private static List<string> FilesList(string path, bool includeRS1Pack = false)
        {
            if (string.IsNullOrEmpty(path))
                throw new Exception("<Error>: No path provided for file scanning");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            List<string> files = new List<string>(Directory.GetFiles(path, "*_p.psarc", SearchOption.AllDirectories));
            files.AddRange(new List<string>(Directory.GetFiles(path, "*_p.disabled.psarc", SearchOption.AllDirectories)));
            if (!includeRS1Pack)
            {
                files = files.Where(file => !file.Contains("rs1comp")).ToList();
            }
            return files;
        }

        private void CheckForUpdate()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                UpdateCheckInfo info;
                try
                {
                    info = ad.CheckForDetailedUpdate();
                    if (info.UpdateAvailable)
                    {
                        Boolean doUpdate = true;

                        if (!info.IsUpdateRequired)
                        {
                            DialogResult dr = MessageBox.Show("An update is available! Would you like to update the application now", "Update Available", MessageBoxButtons.OKCancel);
                            if (DialogResult.OK != dr)
                            {
                                doUpdate = false;
                            }
                        }
                        else
                        {
                            // Display a message that the app MUST reboot. Display the minimum required version.
                            MessageBox.Show("This application has detected a mandatory update from your current version to version"
                                + info.MinimumRequiredVersion
                                + "The application will now install the update and restart.",
                                "Update_Available", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }

                        if (doUpdate)
                        {
                            try
                            {
                                ad.Update();
                                MessageBox.Show("The application has been upgraded and will now restart");
                                Application.Restart();
                            }
                            catch (DeploymentDownloadException dde)
                            {
                                Log("<Error>: " + dde.Message);
                            }
                        }
                    }
                }
                catch (Exception dde)
                {
                    Log("<Error>: " + dde.Message);
                }
            }
        }
        private string GetInstallDirFromRegistry()
        {
            string result = "";
            object test = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Ubisoft\Rocksmith2014", "installdir", null);
            if (test != null)
                result = test.ToString();
            else
            {
                test =
                    Registry.GetValue(
                        @"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 221680",
                        "InstallLocation", null);
                if (test != null)
                    result = test.ToString();
            }
            return result;
        }
        private void Progress(int value)
        {
            toolStripProgressBarMain.ProgressBar.InvokeIfRequired(delegate
            {
                if (toolStripProgressBarMain.ProgressBar != null)
                    toolStripProgressBarMain.ProgressBar
                        .Value = value;
            });
        }
        private void Log(string message)
        {
            myLog.Write(message);
        }
        private void Log(string logMessage, int progress = 1)
        {
            Log(logMessage);
            Progress(progress);
        }
        private void ERR_NI()
        {
            MessageBox.Show("Not implemented yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void SearchDLC(string criteria)
        {
            var results = SongCollection.Where(x => x.Artist.ToLower().Contains(criteria.ToLower()) || x.Album.ToLower().Contains(criteria.ToLower()) ||
                                               x.Song.ToLower().Contains(criteria.ToLower()) || x.Tuning.ToLower().Contains(criteria.ToLower()) ||
                                               x.Author.ToLower().Contains(criteria.ToLower()) || (x.IgnitionAuthor != null &&
                                               x.IgnitionAuthor.ToLower().Contains(criteria.ToLower()) || (x.IgnitionID != null
                                               && x.IgnitionID.ToLower().Contains(criteria.ToLower())))).ToList();

            SortedSongCollection = (List<SongData>)(SongCollection.Where(x => x.Artist.ToLower().Contains(criteria.ToLower()) || x.Album.ToLower().Contains(criteria.ToLower()) ||
                                   x.Song.ToLower().Contains(criteria.ToLower()) || x.Tuning.ToLower().Contains(criteria.ToLower()) ||
                                   x.Author.ToLower().Contains(criteria.ToLower()) || (x.IgnitionAuthor != null &&
                                   x.IgnitionAuthor.ToLower().Contains(criteria.ToLower())) || (x.IgnitionID != null &&
                                   x.IgnitionID.ToLower().Contains(criteria.ToLower()))).ToList());

            dgvSongs.InvokeIfRequired(delegate
            {
                dgvSongs.DataSource = results;
            });
        }
        private void ShowSongInfo()
        {
            if (dgvSongs.SelectedRows.Count > 0)
            {
                var selectedRow = dgvSongs.SelectedRows[0];
                var title = selectedRow.Cells["Song"].Value.ToString();
                var artist = selectedRow.Cells["Artist"].Value.ToString();
                var album = selectedRow.Cells["Album"].Value.ToString();
                var path = selectedRow.Cells["Path"].Value.ToString();

                var song =
                    SongCollection.FirstOrDefault(x => x.Song == title && x.Album == album && x.Artist == artist && x.Path == path);
                if (song != null)
                {
                    frmSongInfo infoWindow = new frmSongInfo(song);
                    infoWindow.Show();
                }
            }
        }

        #region GUIEventHandlers
        #region DataGridView events
        private void dgvSongs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                foreach (DataGridViewRow row in dgvSongs.Rows)
                {
                    if (row.Selected)
                    {
                        if (row.Cells["colSelect"].Value != null && (bool)row.Cells["colSelect"].Value)
                        {
                            row.Cells["colSelect"].Value = false;
                        }
                        else
                        {
                            row.Cells["colSelect"].Value = true;
                        }
                    }
                }
            }
        }
        private void dgvSongs_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    grid.Rows[e.RowIndex].Selected = true;
                }
            }
        }
        private void dgvSongs_DataSourceChanged(object sender, EventArgs e)
        {
            var dataGridViewColumn = ((DataGridView)sender).Columns["Preview"];
            if (dataGridViewColumn != null && dataGridViewColumn.Visible)
                dataGridViewColumn.Visible = false;
        }
        private void dgvSongs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) //if it's not header
                ShowSongInfo();
        }
        private void dgvSongs_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvSongs.DataSource != null)
            {
                int scrollOffset = 0;
                BindingSource bs = new BindingSource { DataSource = SongCollection };
                var songsToShow = SortedSongCollection;

                switch (dgvSongs.Columns[e.ColumnIndex].Name)
                {
                    case "colSelect":
                        bs.DataSource = songsToShow.ToList();
                        break;
                    case "Enabled":
                        if (sortDescending)
                        {
                            bs.DataSource = songsToShow.OrderByDescending(song => song.Enabled);
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource = songsToShow.OrderBy(song => song.Enabled);
                            sortDescending = true;
                        }
                        break;
                    case "Song":
                        if (sortDescending)
                        {
                            bs.DataSource = songsToShow.OrderByDescending(song => song.Song);
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource = songsToShow.OrderBy(song => song.Song);
                            sortDescending = true;
                        }
                        break;
                    case "Artist":
                        if (sortDescending)
                        {
                            bs.DataSource = songsToShow.OrderByDescending(song => song.Artist);
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource = songsToShow.OrderBy(song => song.Artist);
                            sortDescending = true;
                        }
                        break;
                    case "Album":
                        if (sortDescending)
                        {
                            bs.DataSource = songsToShow.OrderByDescending(song => song.Album);
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource = songsToShow.OrderBy(song => song.Album);
                            sortDescending = true;
                        }
                        break;
                    case "Updated":
                        if (sortDescending)
                        {
                            bs.DataSource =
                                songsToShow.OrderByDescending(
                                    song =>
                                        DateTime.ParseExact(song.Updated, "M-d-y H:m",
                                            System.Globalization.CultureInfo.InvariantCulture));
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource =
                                songsToShow.OrderBy(
                                    song =>
                                        DateTime.ParseExact(song.Updated, "M-d-y H:m",
                                            System.Globalization.CultureInfo.InvariantCulture));
                            sortDescending = true;
                        }
                        break;
                    case "Tuning":
                        if (sortDescending)
                        {
                            bs.DataSource = songsToShow.OrderByDescending(song => song.Tuning);
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource = songsToShow.OrderBy(song => song.Tuning);
                            sortDescending = true;
                        }
                        break;
                    case "DD":
                        if (sortDescending)
                        {
                            bs.DataSource = songsToShow.OrderByDescending(song => song.DD);
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource = songsToShow.OrderBy(song => song.DD);
                            sortDescending = true;
                        }
                        break;
                    case "Arrangements":
                        if (sortDescending)
                        {
                            bs.DataSource = songsToShow.OrderByDescending(song => song.Arrangements);
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource = songsToShow.OrderBy(song => song.Arrangements);
                            sortDescending = true;
                        }
                        break;
                    case "Author":
                        if (sortDescending)
                        {
                            bs.DataSource = songsToShow.OrderByDescending(song => song.Author);
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource = songsToShow.OrderBy(song => song.Author);
                            sortDescending = true;
                        }
                        break;
                    case "Version":
                        if (sortDescending)
                        {
                            bs.DataSource = songsToShow.OrderByDescending(song => song.Version);
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource = songsToShow.OrderBy(song => song.Version);
                            sortDescending = true;
                        }
                        break;
                    case "ToolkitVer":
                        if (sortDescending)
                        {
                            bs.DataSource = songsToShow.OrderByDescending(song => song.ToolkitVer);
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource = songsToShow.OrderBy(song => song.ToolkitVer);
                            sortDescending = true;
                        }
                        break;
                    case "Path":
                        if (sortDescending)
                        {
                            bs.DataSource = songsToShow.OrderByDescending(song => song.Path);
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource = songsToShow.OrderBy(song => song.Path);
                            sortDescending = true;
                        }
                        break;
                    case "FileName":
                        if (sortDescending)
                        {
                            bs.DataSource = songsToShow.OrderByDescending(song => song.FileName);
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource = songsToShow.OrderBy(song => song.FileName);
                            sortDescending = true;
                        }
                        break;
                    case "SongYear":
                        if (sortDescending)
                        {
                            bs.DataSource = songsToShow.OrderByDescending(song => song.SongYear);
                            sortDescending = false;
                        }
                        else
                        {
                            bs.DataSource = songsToShow.OrderBy(song => song.SongYear);
                            sortDescending = true;
                        }
                        break;
                }
                scrollOffset = dgvSongs.HorizontalScrollingOffset;
                dgvSongs.DataSource = bs;
                dgvSongs.HorizontalScrollingOffset = scrollOffset;
            }
        }
        #endregion
        #region Link events
        private void lnkAboutCF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://customsforge.com/");
        }

        private void link_CFManager_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://cfmanager.com/");
        }
        private void linkOpenCFHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://customsforge.com/");
        }

        private void linkOpenIgnition_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://ignition.customsforge.com/");
        }

        private void linkOpenOldSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://search.customsforge.com/");
        }

        private void linkOpenRequests_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://requests.customsforge.com/?b");
        }

        private void linkDonationsPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://customsforge.com/donate/");
        }
        private void linkOpenCFVideos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://customsforge.com/videos/");
        }

        private void linkCFFAQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://customsforge.com/faq/");
        }
        private void linkLblSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (DataGridViewRow row in dgvSongs.Rows)
            {
                if (allSelected)
                {
                    row.Cells["colSelect"].Value = false;
                }
                else
                {
                    row.Cells["colSelect"].Value = true;
                }
            }
            allSelected = !allSelected;
        }
        private void link_MainClearResults_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvSongs.InvokeIfRequired(delegate
            {
                SortedSongCollection = SongCollection.ToList();
                dgvSongs.DataSource = new BindingSource().DataSource = SongCollection;
            });
            tbSearch.InvokeIfRequired(delegate { tbSearch.Text = ""; });
        }
        private void link_LovromanProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://customsforge.com/user/43194-lovroman/");
        }
        private void link_DarjuszProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://customsforge.com/user/5299-darjusz/");
        }
        private void link_Alex360Profile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://customsforge.com/user/236-alex360/");
        }
        private void link_UnleashedProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://customsforge.com/user/1-unleashed2k/");
        }
        private void link_ForgeOnProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://customsforge.com/user/345-forgeon/");
        }
        #endregion
        #region Button events
        private void btnEnableColumns_Click(object sender, EventArgs e)
        {
            dgvSongs.InvokeIfRequired(delegate
            {
                foreach (ListViewItem column in listDisabledColumns.CheckedItems)
                {
                    bool visible = false;
                    if (column.SubItems[1].Text == "Select")
                    {
                        visible = dgvSongs.Columns["colSelect"].Visible;
                        dgvSongs.Columns["colSelect"].Visible = !visible;
                        column.SubItems[2].Text = !visible ? "Yes" : "No";
                    }
                    else
                    {
                        visible = dgvSongs.Columns[column.SubItems[1].Text].Visible;
                        dgvSongs.Columns[column.SubItems[1].Text].Visible = !visible;
                        column.SubItems[2].Text = !visible ? "Yes" : "No";
                    }
                    column.Checked = false;
                }
            });
        }
        private void btnExportSongList_Click(object sender, EventArgs e)
        {
            if (radioBtn_ExportToBBCode.Checked)
                SongListToBBCode();
            else if (radioBtn_ExportToHTML.Checked)
                SongListToHTML();
            else if (radioBtn_ExportToCSV.Checked)
                SongListToCSV();
            else
                MessageBox.Show("Export format not selected", "Please select export format!");
        }
        private void btnDisableEnableSongs_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSongs.Rows)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["colSelect"];

                if (cell != null && cell.Value != null && cell.Value.ToString().ToLower() == "true")
                {
                    var originalPath = row.Cells["Path"].Value.ToString();
                    if (!originalPath.Contains("rs1compatibilitydisc"))
                    {
                        if (row.Cells["Enabled"].Value.ToString() == "Yes")
                        {
                            var disabledDLCPath = originalPath.Replace("_p.psarc", "_p.disabled.psarc");
                            File.Move(originalPath, disabledDLCPath);
                            row.Cells["Path"].Value = disabledDLCPath;
                            row.Cells["Enabled"].Value = "No";
                        }
                        else if (row.Cells["Enabled"].Value.ToString() == "No")
                        {
                            var enabledDLCPath = originalPath.Replace("_p.disabled.psarc", "_p.psarc");
                            File.Move(originalPath, enabledDLCPath);
                            row.Cells["Path"].Value = enabledDLCPath;
                            row.Cells["Enabled"].Value = "Yes";
                        }
                        cell.Value = "false";

                        numberOfDisabledDLC = SongCollection.Where(song => song.Enabled == "No").ToList().Count();
                        toolStripStatusLabel_DisabledCounter.Text = "Outdated: " + numberOfDLCPendingUpdate.ToString() + " | Disabled DLC:" + numberOfDisabledDLC.ToString();
                    }
                    else
                    {
                        Log("Rocksmith 1 song->can't be disabled at this moment.");
                    }
                }
            }
        }
        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            SaveSettingsToFile();
        }
        private void btnSettingsLoad_Click(object sender, EventArgs e)
        {
            LoadSettingsFromFile();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchDLC(tbSearch.Text);
        }

        private void btnLaunchSteam_Click(object sender, EventArgs e)
        {
            Process[] rocksmithProcess = Process.GetProcessesByName("Rocksmith2014.exe");
            if (rocksmithProcess.Length > 0)
                MessageBox.Show("Rocksmith is already running!");
            else
                Process.Start("steam://rungameid/221680");
        }
        private void btnBackupRSProfile_Click(object sender, EventArgs e)
        {
            try
            {
                string timestamp = string.Format("{0}-{1}-{2}.{3}-{4}-{5}", DateTime.Now.Day, DateTime.Now.Month,
                    DateTime.Now.Year, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                string backupPath = string.Format("{0}\\profile.backup.{1}.zip", Constants.DefaultWorkingDirectory, timestamp);
                string profilePath = "";
                string steamUserdataPath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam", "InstallPath", null) + @"\userdata";
                DirectoryInfo dInfo = new DirectoryInfo(steamUserdataPath);
                DirectoryInfo[] subdirs = dInfo.GetDirectories("*", SearchOption.AllDirectories);
                foreach (DirectoryInfo info in subdirs)
                {
                    if (info.FullName.Contains(@"221680\remote"))
                    {
                        profilePath = info.FullName;
                    }
                }
                if (profilePath != "")
                {
                    ZipFile.CreateFromDirectory(profilePath, backupPath);
                    Log("Backup created at " + backupPath, 100);
                }
                else
                {
                    Log("Steam profile not found!");
                }
            }
            catch (Exception ex)
            {
                Log("<Error>:" + ex.Message);
            }
        }
        private void btnDupeRescan_Click(object sender, EventArgs e)
        {
            listDupeSongs.Items.Clear();
            DupeCollection.Clear();
            SongCollection.Clear();
            tpDuplicates.InvokeIfRequired(delegate
            {
                tpDuplicates.Text = "Duplicates(0)";
            });
            BackgroundScan();
        }
        private void btnDeleteSongOne_Click(object sender, EventArgs e)
        {
            listDupeSongs.InvokeIfRequired(delegate
            {
                for (int i = 0; i < listDupeSongs.Items.Count; i++)
                {
                    if (listDupeSongs.Items[i].Checked)
                    {
                        try
                        {
                            File.Delete(DupeCollection[i].Path);
                            if (DupeCollection.Where(song => song.Song == DupeCollection[i].Song && song.Album == DupeCollection[i].Album).ToList().Count == 2)
                            {
                                DupeCollection.RemoveAll(song => song.Song == DupeCollection[i].Song && song.Album == DupeCollection[i].Album);
                                listDupeSongs.Items.Clear();
                                foreach (var song in DupeCollection)
                                {
                                    listDupeSongs.InvokeIfRequired(delegate
                                    {
                                        listDupeSongs.Items.Add(new ListViewItem(new[] { " ", song.Artist, song.Song, song.Album, song.Path }));
                                    });
                                }
                            }
                            else
                            {
                                DupeCollection.RemoveAt(i);
                                listDupeSongs.Items.RemoveAt(i);
                            }

                            tpDuplicates.Text = "Duplicates(" + DupeCollection.Count.ToString() + ")";
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                    }
                }
            });
        }
        private void btnRescan_Click(object sender, EventArgs e)
        {
            BackgroundScan();
        }

        private void btnCheckAllForUpdates_Click(object sender, EventArgs e)
        {
            bWorker = new AbortableBackgroundWorker();
            bWorker.SetDefaults();
            bWorker.DoWork += checkAllForUpdates;
            toolStripStatusLabel_MainCancel.Visible = true;
            //toolStripStatusLabel_MainCancel.Click += delegate
            //{
            //    bWorker.CancelAsync();
            //    bWorker.Abort();
            //};
            bWorker.RunWorkerAsync();
        }
        private void btnBatchRenamer_Click(object sender, EventArgs e)
        {
            if (SortedSongCollection != null && SortedSongCollection.Count > 0)
            {
                frmRenamer renamer = new frmRenamer(myLog, mySettings, SortedSongCollection);
                renamer.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please scan in atleast one song.");
            }
        }
        #endregion
        #region ToolStripMenuItem events

        private void toolStripStatusLabel_ClearLog_Click(object sender, EventArgs e)
        {
            tbLog.Clear();
        }

        private void showDLCInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSongInfo();
        }
        private void openDLCPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSongs.SelectedRows.Count == 1)
            {
                var song = GetSongByRow(dgvSongs.SelectedRows[0]);
                if (song != null)
                {
                    if (song.IgnitionID == null || song.IgnitionID == "No Results")
                        song.IgnitionID = Ignition.GetDLCInfoFromURL(song.GetInfoURL(), "id");
                    if (song.IgnitionID == null || song.IgnitionID == "No Results")
                        myLog.Write("<ERROR>: Song doesn't exist in Ignition anymore.");
                    else
                        Process.Start(Constants.DefaultDetailsURL + "/" + song.IgnitionID);
                }
            }
        }
        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bWorker = new AbortableBackgroundWorker();
            bWorker.SetDefaults();
            bWorker.DoWork += CheckForUpdatesEvent;
            bWorker.RunWorkerAsync();
        }
        private void toolStripStatusLabel_MainCancel_Click(object sender, EventArgs e)
        {
            bWorker.CancelAsync();
            bWorker.Abort();
            //bWorker.Dispose();
            //bWorker = null;
            toolStripStatusLabel_MainCancel.Visible = false;
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bWorker.IsBusy)
                bWorker.CancelAsync();
            Application.Exit();
        }
        private void getAuthorNameStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvSongs.InvokeIfRequired(delegate
            {
                if (dgvSongs.SelectedRows.Count > 0)
                {
                    UpdateAuthor(dgvSongs.SelectedRows[0]);
                }
            });
        }
        private void editDLCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void openDLCLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = dgvSongs.SelectedRows[0].Cells["Path"].Value.ToString();
            var directory = new FileInfo(path);
            if (directory.DirectoryName != null)
                Process.Start(directory.DirectoryName);
        }
        #endregion
        private void timerAutoUpdate_Tick(object sender, EventArgs e)
        {
            CheckForUpdate();
        }
        private void tbSettingsRSDir_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tbSettingsRSDir.Enabled)
            {
                if (folderBrowserDialog_SettingsRSPath.ShowDialog() == DialogResult.OK)
                {
                    tbSettingsRSDir.Text = folderBrowserDialog_SettingsRSPath.SelectedPath;
                    mySettings.RSInstalledDir = tbSettingsRSDir.Text;
                }
            }
        }
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbSearch.Text.Length > 0)// && e.KeyCode == Keys.Enter)
            {
                SearchDLC(tbSearch.Text);
            }
            else
            {
                dgvSongs.DataSource = new BindingSource().DataSource = SongCollection;
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettingsToFile();
            SaveSongCollectionToFile();
        }
        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                foreach (DataGridViewRow row in dgvSongs.Rows)
                {
                    if (allSelected)
                    {
                        row.Cells["colSelect"].Value = false;
                    }
                    else
                    {
                        row.Cells["colSelect"].Value = true;
                    }
                }
                allSelected = !allSelected;
            }
        }

        private void CheckForUpdatesEvent(object o, DoWorkEventArgs args)
        {
            dgvSongs.InvokeIfRequired(delegate
            {
                if (dgvSongs.SelectedRows.Count > 0)
                {
                    CheckRowForUpdate(dgvSongs.SelectedRows[0]);
                    SaveSongCollectionToFile();
                }
            });
        }
        #endregion
        void checkAllForUpdates(object sender, DoWorkEventArgs e)
        {
            //Thread.Sleep(3000);
            counterStopwatch.Start();
            dgvSongs.InvokeIfRequired(delegate
            {
                if (!bWorker.CancellationPending)
                {
                    foreach (DataGridViewRow row in dgvSongs.Rows)
                    {
                        //string songname = row.Cells[3].Value.ToString();
                        if (!bWorker.CancellationPending)
                        {
                            DataGridViewRow currentRow = (DataGridViewRow)row;
                            if (!currentRow.Cells["FileName"].Value.ToString().Contains("rs1comp"))
                            {
                                CheckRowForUpdate(currentRow);
                            }
                        }
                        else
                        {
                            bWorker.Abort();
                        }
                    }
                }
                SaveSongCollectionToFile();
            });
            counterStopwatch.Stop();
        }

        private void UpdateAuthor(DataGridViewRow selectedRow)
        {
            var currentSong = GetSongByRow(selectedRow);
            if (currentSong != null)
            {
                currentSong.IgnitionAuthor = Ignition.GetDLCInfoFromURL(currentSong.GetInfoURL(), "name");
                selectedRow.Cells["IgnitionAuthor"].Value = currentSong.IgnitionAuthor;
            }
        }

        private void SongListToHTML()
        {
            var sbTXT = new StringBuilder();
            sbTXT.AppendLine("[table]");
            sbTXT.AppendLine("<tr>");
            sbTXT.AppendLine("<th>Song</th><th>Artist</th><th>Album</th><th>Updated</th><th>Tuning</th><th>DD</th><th>Arangements</th><th>Author</th>");
            sbTXT.AppendLine("</tr>");
            foreach (var song in SongCollection)
            {
                sbTXT.AppendLine("<tr>");
                if (song.Author == null)
                {
                    sbTXT.AppendLine("<td>" + song.Song + "</td><td>" + song.Artist + "</td><td>" + song.Album + "</td><td>" + song.Updated + "</td><td>" + song.Tuning + "</td><td>" + song.DD.DifficultyToDD() + "</td><td>" + song.Arrangements + "</td>");
                }
                else
                {
                    sbTXT.AppendLine("<td>" + song.Song + "</td><td>" + song.Artist + "</td><td>" + song.Album + "</td><td>" + song.Updated + "</td><td>" + song.Tuning + "</td><td>" + song.DD.DifficultyToDD() + "</td><td>" + song.Arrangements + "</td><td>" + song.Author + "</td>");
                }
                sbTXT.AppendLine("</tr>");
            }
            sbTXT.AppendLine("[/table]");

            using (frmSongListExport FormSongListExport = new frmSongListExport())
            {
                FormSongListExport.SongList = sbTXT.ToString();
                FormSongListExport.Text = "Song list to HTML";
                FormSongListExport.ShowDialog();
            }
        }

        private void SongListToBBCode()
        {
            var sbTXT = new StringBuilder();
            sbTXT.AppendLine("Song - Artist, Album, Updated, Tuning, DD, Arangements, Author");
            sbTXT.AppendLine("[LIST=1]");
            foreach (var song in SongCollection)
            {
                if (song.Author == null)
                {
                    sbTXT.AppendLine("[*]" + song.Song + " - " + song.Artist + ", " + song.Album + ", " + song.Updated + ", " + song.Tuning + ", " + song.DD.DifficultyToDD() + ", " + song.Arrangements + "[/*]");
                }
                else
                {
                    sbTXT.AppendLine("[*]" + song.Song + " - " + song.Artist + ", " + song.Album + ", " + song.Updated + ", " + song.Tuning + ", " + song.DD.DifficultyToDD() + ", " + song.Arrangements + ", " + song.Author + "[/*]");
                }
            }
            sbTXT.AppendLine("[/LIST]");

            using (frmSongListExport FormSongListExport = new frmSongListExport())
            {
                FormSongListExport.SongList = sbTXT.ToString();
                FormSongListExport.Text = "Song list to BBCode";
                FormSongListExport.ShowDialog();
            }
        }

        private void SongListToCSV()
        {
            var sbCSV = new StringBuilder();
            string path = Constants.DefaultWorkingDirectory + @"\SongListCSV.csv";

            sfdSongListToCSV.Filter = "csv files(*.csv)|*.csv|All files (*.*)|*.*";
            sfdSongListToCSV.FileName = "SongListCSV";

            if (sfdSongListToCSV.ShowDialog() == DialogResult.OK)
            {
                path = sfdSongListToCSV.FileName;
            }

            sbCSV.AppendLine(@"sep=;");
            sbCSV.AppendLine("Artist;Song;Album;Year;Tuning;Arrangements");
            foreach (var song in SongCollection)
            {
                sbCSV.AppendLine(song.Artist + ";" + song.Song + ";" + song.Album + ";" + song.SongYear + ";" + song.Tuning + ";" + song.Arrangements);
            }
            try
            {
                using (StreamWriter file = new StreamWriter(path, false, Encoding.UTF8))
                {
                    file.Write(sbCSV.ToString());
                }
                Log("Song list saved to:" + path);
            }
            catch (IOException ex)
            {
                Log("<Error>:" + ex.Message);
            }
        }
        private void CheckRowForUpdate(DataGridViewRow dataGridViewRow)
        {
            if (!bWorker.CancellationPending)
            {
                var currentSong = GetSongByRow(dataGridViewRow);
                if (currentSong != null)
                {
                    //currentSong.IgnitionVersion = Ignition.GetDLCInfoFromURL(currentSong.GetInfoURL(), "version");
                    string url = currentSong.GetInfoURL();
                    string response = "";
                    string cfUrl = "";
                    var client = new WebClient();
                    client.DownloadStringCompleted += (sender, e) =>
                    {
                        if (!bWorker.CancellationPending)
                        {
                            response = e.Result;

                            currentSong.IgnitionID = Ignition.GetDLCInfoFromResponse(response, "id");
                            currentSong.IgnitionUpdated = Ignition.GetDLCInfoFromResponse(response, "updated");
                            currentSong.IgnitionVersion = Ignition.GetDLCInfoFromResponse(response, "version");
                            currentSong.IgnitionAuthor = Ignition.GetDLCInfoFromResponse(response, "name");

                            if (!bWorker.CancellationPending)
                            {
                                dataGridViewRow.Cells["IgnitionVersion"].Value = currentSong.IgnitionVersion;
                            }

                            if (currentSong.Version != "N/A")
                            {
                                int version = 0;

                                if (int.TryParse(currentSong.Version, out version))
                                {
                                    currentSong.Version += ".0";
                                }

                                if (int.TryParse(currentSong.IgnitionVersion, out version))
                                {
                                    currentSong.IgnitionVersion += ".0";
                                }

                                if (currentSong.IgnitionVersion == "No Results")
                                {
                                    dataGridViewRow.DefaultCellStyle.BackColor = Color.OrangeRed;
                                    myLog.Write(
                                        string.Format(
                                            "<ERROR>: Song \"{0}\" from \"{1}\" album by {2} not found in ignition.",
                                            currentSong.Song, currentSong.Album, currentSong.Author), false);
                                }
                                else if (currentSong.IgnitionVersion != currentSong.Version)
                                {
                                    dataGridViewRow.DefaultCellStyle.BackColor = Color.Gold;
                                    myLog.Write(
                                        string.Format(
                                            "Update found for \"{0}\" from \"{1}\" album by {2}. Local version: {3}, Ignition version: {4} ",
                                            currentSong.Song, currentSong.Album, currentSong.Author, currentSong.Version,
                                            currentSong.IgnitionVersion), false);

                                    numberOfDLCPendingUpdate++;
                                    toolStripStatusLabel_DisabledCounter.Text = "Outdated: " + numberOfDLCPendingUpdate.ToString() + " | Disabled DLC:" + numberOfDisabledDLC.ToString();
                                    
                                    cfUrl = Constants.DefaultCFSongUrl + currentSong.Song.Replace("'", "").Replace("(","").Replace(")","").Replace(" ", "-") + "-r" + currentSong.IgnitionID;

                                    if (!OutdatedSongList.ContainsKey(cfUrl))
                                    {
                                        OutdatedSongList.Add(cfUrl, currentSong);
                                    }
                                }
                            }
                            if (dataGridViewRow.Index == dgvSongs.Rows.Count - 1)
                            {
                                frmOutdatedSongs frmOutdated = new frmOutdatedSongs();
                                frmOutdated.OutdatedSongList = OutdatedSongList;
                                frmOutdated.ShowDialog();
                                Log(string.Format("Finished update check. Task took {0}", counterStopwatch.Elapsed));
                            }
                        }
                    };
                    if (!bWorker.CancellationPending)
                    {
                        client.DownloadStringAsync(new Uri(url));
                    }
                }
            }
        }

        private SongData GetSongByRow(DataGridViewRow dataGridViewRow)
        {
            return SongCollection.Distinct().FirstOrDefault(x => x.Song == dataGridViewRow.Cells["Song"].Value.ToString() && x.Artist == dataGridViewRow.Cells["Artist"].Value.ToString() && x.Album == dataGridViewRow.Cells["Album"].Value.ToString() && x.Path == dataGridViewRow.Cells["Path"].Value.ToString());
        }

        private void renameAllButton_Click(object sender, EventArgs e)
        {
            SortedSongCollection = SongCollection.ToList();
            if (!renameTemplateTextBox.Text.Contains("<title>"))
            {
                MessageBox.Show("Rename Template requires <title> atleast once to prevent overwriting songs.");
                return;
            }
            if (SortedSongCollection == null || SortedSongCollection.Count == 0)
            {
                MessageBox.Show("Please scan in atleast one song.");
                return;
            }
            bWorker = new AbortableBackgroundWorker();
            bWorker.SetDefaults();
            bWorker.DoWork += doRenameSongs;
            bWorker.DoWork += PopulateListHandler;
            bWorker.RunWorkerCompleted += PopulateCompletedHandler;
            bWorker.RunWorkerAsync();
        }

        //TODO: Refactor this somewhere else?
        private void renameSongs(List<SongData> songList, String templateString, Boolean deleteEmptyDirectories)
        {
            try
            {
                foreach (SongData data in songList)
                {    
                    Template template = new Template(templateString);
                    template.Add("title", data.Song);
                    template.Add("artist", data.Artist);
                    template.Add("version", data.Version);
                    template.Add("author", data.Author);
                    template.Add("album", data.Album);
                    if ("Yes".Equals(data.DD))
                    {
                        template.Add("dd", "_dd");
                    }
                    else
                    {
                        template.Add("dd","");
                    }

                    template.Add("year", data.SongYear);
                    template.Add("author", data.Updated);
                    String newFilePath = mySettings.RSInstalledDir + "\\dlc\\" + template.Render() + "_p.psarc";
                    string oldFilePath = data.Path;
                    FileInfo newFileInfo = new FileInfo(newFilePath);
                    System.IO.Directory.CreateDirectory(newFileInfo.Directory.FullName);
                    myLog.Write("Renaming/Moving:" + oldFilePath);
                  
                    myLog.Write("---> " + newFilePath);
                    System.IO.File.Move(oldFilePath, newFilePath);
                }
                if (deleteEmptyDirectories)
                {
                    new DirectoryInfo(mySettings.RSInstalledDir + "\\dlc\\").DeleteEmptyDirs();
                }
                
            }
            //lazy exception catch for now. Future me will punch me for such astrocities, alas its a desktop app.
            catch (Exception e)
            {
                myLog.Write(e.Message);
            }

        }

        private void doRenameSongs(object sender, DoWorkEventArgs e)
        {
            if (!bWorker.CancellationPending)
            {
                renameSongs(SortedSongCollection, renameTemplateTextBox.Text, deleteEmptyDirCheckBox.Checked);
            }
        }
    }
}
