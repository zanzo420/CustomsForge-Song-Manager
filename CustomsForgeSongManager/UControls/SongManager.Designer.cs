﻿using System.Windows.Forms;
using DataGridViewTools;

namespace CustomsForgeSongManager.UControls
{
    partial class SongManager
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.chkSubFolders = new System.Windows.Forms.CheckBox();
            this.lnkClearSearch = new System.Windows.Forms.LinkLabel();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.cueSearch = new DataGridViewTools.CueTextBox();
            this.gb_Main_Search = new System.Windows.Forms.GroupBox();
            this.sfdSongListToCSV = new System.Windows.Forms.SaveFileDialog();
            this.cmsSongManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsActions = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsPlaySelected = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsShowSongInfo = new CustomControls.ToolStripEnhancedMenuItem();
            this.cmsEnableDisable = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOpenSongPage = new CustomControls.ToolStripEnhancedMenuItem();
            this.cmsCheckForUpdate = new CustomControls.ToolStripEnhancedMenuItem();
            this.cmsOpenSongLocation = new CustomControls.ToolStripEnhancedMenuItem();
            this.cmsEdit = new CustomControls.ToolStripEnhancedMenuItem();
            this.cmsGetCharterName = new CustomControls.ToolStripEnhancedMenuItem();
            this.cmsDelete = new CustomControls.ToolStripEnhancedMenuItem();
            this.cmsBackup = new CustomControls.ToolStripEnhancedMenuItem();
            this.cmsTaggerPreview = new CustomControls.ToolStripEnhancedMenuItem();
            this.cmsGetAnalyzerData = new CustomControls.ToolStripEnhancedMenuItem();
            this.lnkLblSelectAll = new System.Windows.Forms.LinkLabel();
            this.gb_Main_Grid = new System.Windows.Forms.GroupBox();
            this.dgvSongsDetail = new DataGridViewTools.SubclassedDataGridView();
            this.colDetailKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailArrangement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailTuning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailSections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailDMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailToneBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailChordCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailNoteCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailOctaveCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailChords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongsMaster = new DataGridViewTools.RADataGridView();
            this.colShowDetail = new System.Windows.Forms.DataGridViewImageColumn();
            this.colKey = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colBass = new System.Windows.Forms.DataGridViewImageColumn();
            this.colLead = new System.Windows.Forms.DataGridViewImageColumn();
            this.colRhythm = new System.Windows.Forms.DataGridViewImageColumn();
            this.colVocals = new System.Windows.Forms.DataGridViewImageColumn();
            this.colRepairStatus = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colEnabled = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colArtist = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colTitle = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colAlbum = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colSongYear = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colArrangements = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colTuning = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colDD = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colSongLength = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colAvgTempo = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colAppID = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colFileName = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colFilePath = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colFileDate = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colFileSize = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colStatus = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colCharter = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colUpdated = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colVersion = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colToolkitVersion = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colTagged = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colIgnitionID = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colIgnitionUpdated = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colIgnitionVersion = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colIgnitionAuthor = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colArtistTitleAlbum = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colArtistSort = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colTitleSort = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colAlbumSort = new DataGridViewTools.DataGridViewAutoFilterTextBoxColumn();
            this.colNoteCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChordCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOctaveCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVibratoCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHammerOnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBendCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPullOffCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHarmonicCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFretHandMuteCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPalmMuteCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPluckCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSlapCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPopCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSlideCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSustainCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTremoloCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPinchHarmonicCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnpitchedSlideCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalTapCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHighestFretUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnklblToggle = new System.Windows.Forms.LinkLabel();
            this.cmsSongManagerColumns = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiRescan = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiRescanQuick = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiRescanFull = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiRepairs = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiSkipRemastered = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRepairsAddDD = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiAddDDSettings = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiAddDDNumericUpDown = new CustomControls.ToolStripNumericUpDown();
            this.tsmiAddDDRemoveSustain = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiAddDDCfgPath = new CustomControls.ToolStripSpringTextBox();
            this.tsmiAddDDRampUpPath = new CustomControls.ToolStripSpringTextBox();
            this.tsmiOverwriteDD = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRepairsMastery = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiRepairsPreserveStats = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiRepairsUsingOrg = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiRepairsMultitone = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRepairsMaxFive = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiRemoveNDD = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiRemoveBass = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiRemoveGuitar = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiRemoveBonus = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiRemoveMetronome = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiIgnoreStopLimit = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRemoveSections = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiProcessDLFolder = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRepairsRun = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiDuplicates = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiDuplicatesSoon = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiMods = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiModsChangeAppId = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiModsPitchShifter = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiModsPitchShiftStandard = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiModsPreserveStats = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiModsPitchShiftOverwrite = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTagStyle = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiModsTagArtwork = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiModsUntagArtwork = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiModsTheMover = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiModsMyCDLC = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFiles = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesCheckODLC = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilesCleanDlc = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesRestore = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesRestoreBak = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesRestoreOrg = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesRestoreMax = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesRestoreCor = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesArchive = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesArcBak = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesArcOrg = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesArcMax = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesArcCor = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesArcDeleteAfter = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilesOrganize = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesUnorganize = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiFilesIncludeODLC = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiHelp = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiHelpGeneral = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiHelpRepairs = new CustomControls.ToolStripEnhancedMenuItem();
            this.tsmiHelpErrorLog = new CustomControls.ToolStripEnhancedMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelSearch.SuspendLayout();
            this.gb_Main_Search.SuspendLayout();
            this.cmsSongManager.SuspendLayout();
            this.gb_Main_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongsMaster)).BeginInit();
            this.cmsSongManagerColumns.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.Controls.Add(this.chkSubFolders);
            this.panelSearch.Controls.Add(this.lnkClearSearch);
            this.panelSearch.Controls.Add(this.lbl_Search);
            this.panelSearch.Controls.Add(this.cueSearch);
            this.panelSearch.Location = new System.Drawing.Point(6, 19);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(879, 33);
            this.panelSearch.TabIndex = 5;
            // 
            // chkSubFolders
            // 
            this.chkSubFolders.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSubFolders.AutoSize = true;
            this.chkSubFolders.Checked = true;
            this.chkSubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubFolders.Location = new System.Drawing.Point(522, 8);
            this.chkSubFolders.Name = "chkSubFolders";
            this.chkSubFolders.Size = new System.Drawing.Size(197, 17);
            this.chkSubFolders.TabIndex = 24;
            this.chkSubFolders.Text = "Include Organized and Setlist Songs";
            this.toolTip.SetToolTip(this.chkSubFolders, "If checked, search \'dlc\' folder and \r\nsubfolders for any matching songs.");
            this.chkSubFolders.UseVisualStyleBackColor = true;
            this.chkSubFolders.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkSubFolders_MouseUp);
            // 
            // lnkClearSearch
            // 
            this.lnkClearSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkClearSearch.AutoSize = true;
            this.lnkClearSearch.ForeColor = System.Drawing.Color.DimGray;
            this.lnkClearSearch.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lnkClearSearch.Location = new System.Drawing.Point(411, 10);
            this.lnkClearSearch.Name = "lnkClearSearch";
            this.lnkClearSearch.Size = new System.Drawing.Size(68, 13);
            this.lnkClearSearch.TabIndex = 3;
            this.lnkClearSearch.TabStop = true;
            this.lnkClearSearch.Text = "Clear Search";
            this.lnkClearSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearSearch_LinkClicked);
            // 
            // lbl_Search
            // 
            this.lbl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(3, 9);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(0, 13);
            this.lbl_Search.TabIndex = 2;
            // 
            // cueSearch
            // 
            this.cueSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cueSearch.Cue = "Type characters to search...";
            this.cueSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cueSearch.ForeColor = System.Drawing.Color.Gray;
            this.cueSearch.Location = new System.Drawing.Point(9, 6);
            this.cueSearch.Name = "cueSearch";
            this.cueSearch.Size = new System.Drawing.Size(396, 20);
            this.cueSearch.TabIndex = 1;
            this.cueSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cueSearch_KeyUp);
            // 
            // gb_Main_Search
            // 
            this.gb_Main_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Main_Search.Controls.Add(this.panelSearch);
            this.gb_Main_Search.Location = new System.Drawing.Point(3, 427);
            this.gb_Main_Search.Name = "gb_Main_Search";
            this.gb_Main_Search.Size = new System.Drawing.Size(891, 58);
            this.gb_Main_Search.TabIndex = 10;
            this.gb_Main_Search.TabStop = false;
            this.gb_Main_Search.Text = "Search:";
            // 
            // sfdSongListToCSV
            // 
            this.sfdSongListToCSV.FileName = "songList.csv";
            this.sfdSongListToCSV.Filter = "csv files(*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // cmsSongManager
            // 
            this.cmsSongManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsActions,
            this.toolStripSeparator15,
            this.cmsPlaySelected,
            this.cmsOpenSongPage,
            this.cmsCheckForUpdate,
            this.cmsEdit,
            this.cmsGetCharterName,
            this.cmsTaggerPreview,
            this.cmsGetAnalyzerData,
            this.toolStripSeparator2,
            this.cmsShowSongInfo,
            this.cmsOpenSongLocation,
            this.cmsEnableDisable,
            this.cmsDelete,
            this.cmsBackup});
            this.cmsSongManager.Name = "contextMenuStrip_MainManager";
            this.cmsSongManager.Size = new System.Drawing.Size(210, 324);
            this.cmsSongManager.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.cmsSongManager_Closing);
            this.cmsSongManager.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsSongManager_ItemClicked);
            // 
            // cmsActions
            // 
            this.cmsActions.AssociatedEnumValue = null;
            this.cmsActions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsActions.Name = "cmsActions";
            this.cmsActions.RadioButtonGroupName = null;
            this.cmsActions.Size = new System.Drawing.Size(209, 22);
            this.cmsActions.Text = "Actions:";
            this.cmsActions.ToolTipText = resources.GetString("cmsActions.ToolTipText");
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(206, 6);
            // 
            // cmsPlaySelected
            // 
            this.cmsPlaySelected.Image = global::CustomsForgeSongManager.Properties.Resources.ap_play;
            this.cmsPlaySelected.Name = "cmsPlaySelected";
            this.cmsPlaySelected.Size = new System.Drawing.Size(209, 22);
            this.cmsPlaySelected.Text = "Play/Pause Selected Song";
            this.cmsPlaySelected.Click += new System.EventHandler(this.cmsPlaySelected_Click);
            // 
            // cmsShowSongInfo
            // 
            this.cmsShowSongInfo.AssociatedEnumValue = null;
            this.cmsShowSongInfo.Image = ((System.Drawing.Image)(resources.GetObject("cmsShowSongInfo.Image")));
            this.cmsShowSongInfo.Name = "cmsShowSongInfo";
            this.cmsShowSongInfo.RadioButtonGroupName = null;
            this.cmsShowSongInfo.Size = new System.Drawing.Size(209, 22);
            this.cmsShowSongInfo.Text = "Show Song Info";
            this.cmsShowSongInfo.Click += new System.EventHandler(this.cmsShowSongInfo_Click);
            // 
            // cmsEnableDisable
            // 
            this.cmsEnableDisable.Image = global::CustomsForgeSongManager.Properties.Resources.disable;
            this.cmsEnableDisable.Name = "cmsEnableDisable";
            this.cmsEnableDisable.Size = new System.Drawing.Size(209, 22);
            this.cmsEnableDisable.Text = "Enable/Disable Songs";
            this.cmsEnableDisable.Click += new System.EventHandler(this.cmsEnableDisable_Click);
            // 
            // cmsOpenSongPage
            // 
            this.cmsOpenSongPage.AssociatedEnumValue = null;
            this.cmsOpenSongPage.Image = ((System.Drawing.Image)(resources.GetObject("cmsOpenSongPage.Image")));
            this.cmsOpenSongPage.Name = "cmsOpenSongPage";
            this.cmsOpenSongPage.RadioButtonGroupName = null;
            this.cmsOpenSongPage.Size = new System.Drawing.Size(209, 22);
            this.cmsOpenSongPage.Text = "Open Song Page";
            this.cmsOpenSongPage.Visible = false;
            this.cmsOpenSongPage.Click += new System.EventHandler(this.cmsOpenDLCPage_Click);
            // 
            // cmsCheckForUpdate
            // 
            this.cmsCheckForUpdate.AssociatedEnumValue = null;
            this.cmsCheckForUpdate.Image = ((System.Drawing.Image)(resources.GetObject("cmsCheckForUpdate.Image")));
            this.cmsCheckForUpdate.Name = "cmsCheckForUpdate";
            this.cmsCheckForUpdate.RadioButtonGroupName = null;
            this.cmsCheckForUpdate.Size = new System.Drawing.Size(209, 22);
            this.cmsCheckForUpdate.Text = "Check for Update";
            this.cmsCheckForUpdate.Visible = false;
            this.cmsCheckForUpdate.Click += new System.EventHandler(this.cmsCheckForUpdate_Click);
            // 
            // cmsOpenSongLocation
            // 
            this.cmsOpenSongLocation.AssociatedEnumValue = null;
            this.cmsOpenSongLocation.Image = ((System.Drawing.Image)(resources.GetObject("cmsOpenSongLocation.Image")));
            this.cmsOpenSongLocation.Name = "cmsOpenSongLocation";
            this.cmsOpenSongLocation.RadioButtonGroupName = null;
            this.cmsOpenSongLocation.Size = new System.Drawing.Size(209, 22);
            this.cmsOpenSongLocation.Text = "Open Song Location";
            this.cmsOpenSongLocation.Click += new System.EventHandler(this.cmsOpenDLCLocation_Click);
            // 
            // cmsEdit
            // 
            this.cmsEdit.AssociatedEnumValue = null;
            this.cmsEdit.Image = ((System.Drawing.Image)(resources.GetObject("cmsEdit.Image")));
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.RadioButtonGroupName = null;
            this.cmsEdit.Size = new System.Drawing.Size(209, 22);
            this.cmsEdit.Text = "Edit Song Information";
            this.cmsEdit.Click += new System.EventHandler(this.cmsEdit_Click);
            // 
            // cmsGetCharterName
            // 
            this.cmsGetCharterName.AssociatedEnumValue = null;
            this.cmsGetCharterName.Name = "cmsGetCharterName";
            this.cmsGetCharterName.RadioButtonGroupName = null;
            this.cmsGetCharterName.Size = new System.Drawing.Size(209, 22);
            this.cmsGetCharterName.Text = "Get Charter\'s Name";
            this.cmsGetCharterName.Visible = false;
            this.cmsGetCharterName.Click += new System.EventHandler(this.cmsGetCharterName_Click);
            // 
            // cmsDelete
            // 
            this.cmsDelete.AssociatedEnumValue = null;
            this.cmsDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmsDelete.Image")));
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.RadioButtonGroupName = null;
            this.cmsDelete.Size = new System.Drawing.Size(209, 22);
            this.cmsDelete.Text = "Delete Songs";
            this.cmsDelete.ToolTipText = "WARNING\r\nDeletion can not be undone.";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // cmsBackup
            // 
            this.cmsBackup.AssociatedEnumValue = null;
            this.cmsBackup.Image = ((System.Drawing.Image)(resources.GetObject("cmsBackup.Image")));
            this.cmsBackup.Name = "cmsBackup";
            this.cmsBackup.RadioButtonGroupName = null;
            this.cmsBackup.Size = new System.Drawing.Size(209, 22);
            this.cmsBackup.Text = "Backup Songs";
            this.cmsBackup.Click += new System.EventHandler(this.cmsBackup_Click);
            // 
            // cmsTaggerPreview
            // 
            this.cmsTaggerPreview.AssociatedEnumValue = null;
            this.cmsTaggerPreview.Name = "cmsTaggerPreview";
            this.cmsTaggerPreview.RadioButtonGroupName = null;
            this.cmsTaggerPreview.Size = new System.Drawing.Size(209, 22);
            this.cmsTaggerPreview.Text = "Tagger Preview";
            this.cmsTaggerPreview.ToolTipText = "The full feature to \'Tag Album Artwork\'\r\ncan be found in the \'Custom Mods\' menu.";
            this.cmsTaggerPreview.Visible = false;
            // 
            // cmsGetAnalyzerData
            // 
            this.cmsGetAnalyzerData.AssociatedEnumValue = null;
            this.cmsGetAnalyzerData.Image = global::CustomsForgeSongManager.Properties.Resources.rescan_plus;
            this.cmsGetAnalyzerData.Name = "cmsGetAnalyzerData";
            this.cmsGetAnalyzerData.RadioButtonGroupName = null;
            this.cmsGetAnalyzerData.Size = new System.Drawing.Size(209, 22);
            this.cmsGetAnalyzerData.Text = "Get Analyzer Data";
            this.cmsGetAnalyzerData.ToolTipText = "Shows note count, chord count, and\r\nlists all chords for the selected songs.\r\n\r\nN" +
                "OTE:\r\n Data may be shown for all\r\nsongs by using the checkbox \'Include\r\nAnayzer " +
                "Data\' in the \'Settings\' menu";
            this.cmsGetAnalyzerData.Click += new System.EventHandler(this.cmsGetAnalyzerData_Click);
            // 
            // lnkLblSelectAll
            // 
            this.lnkLblSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkLblSelectAll.AutoSize = true;
            this.lnkLblSelectAll.ForeColor = System.Drawing.Color.Black;
            this.lnkLblSelectAll.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lnkLblSelectAll.Location = new System.Drawing.Point(12, 370);
            this.lnkLblSelectAll.Name = "lnkLblSelectAll";
            this.lnkLblSelectAll.Size = new System.Drawing.Size(82, 13);
            this.lnkLblSelectAll.TabIndex = 2;
            this.lnkLblSelectAll.TabStop = true;
            this.lnkLblSelectAll.Text = "Select All/None";
            this.lnkLblSelectAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.lnkLblSelectAll, "ODLC are not selectable");
            this.lnkLblSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblSelectAll_LinkClicked);
            // 
            // gb_Main_Grid
            // 
            this.gb_Main_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Main_Grid.Controls.Add(this.dgvSongsDetail);
            this.gb_Main_Grid.Controls.Add(this.lnkLblSelectAll);
            this.gb_Main_Grid.Controls.Add(this.dgvSongsMaster);
            this.gb_Main_Grid.Controls.Add(this.lnklblToggle);
            this.gb_Main_Grid.Location = new System.Drawing.Point(3, 27);
            this.gb_Main_Grid.Name = "gb_Main_Grid";
            this.gb_Main_Grid.Size = new System.Drawing.Size(891, 394);
            this.gb_Main_Grid.TabIndex = 8;
            this.gb_Main_Grid.TabStop = false;
            this.gb_Main_Grid.Text = "Results Grid:";
            // 
            // dgvSongsDetail
            // 
            this.dgvSongsDetail.AllowUserToAddRows = false;
            this.dgvSongsDetail.AllowUserToDeleteRows = false;
            this.dgvSongsDetail.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvSongsDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSongsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongsDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetailKey,
            this.colDetailPID,
            this.colDetailArrangement,
            this.colDetailTuning,
            this.colDetailSections,
            this.colDetailDMax,
            this.colDetailToneBase,
            this.colDetailChordCount,
            this.colDetailNoteCount,
            this.colDetailOctaveCount,
            this.colDetailChords});
            this.dgvSongsDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSongsDetail.HorizontalScrollBarVisible = true;
            this.dgvSongsDetail.Location = new System.Drawing.Point(27, 78);
            this.dgvSongsDetail.Name = "dgvSongsDetail";
            this.dgvSongsDetail.ReadOnly = true;
            this.dgvSongsDetail.RowHeadersVisible = false;
            this.dgvSongsDetail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvSongsDetail.Size = new System.Drawing.Size(842, 70);
            this.dgvSongsDetail.TabIndex = 5;
            this.dgvSongsDetail.VerticalScrollBarVisible = false;
            // 
            // colDetailKey
            // 
            this.colDetailKey.DataPropertyName = "DLCKey";
            this.colDetailKey.Frozen = true;
            this.colDetailKey.HeaderText = "DLC Key";
            this.colDetailKey.Name = "colDetailKey";
            this.colDetailKey.ReadOnly = true;
            this.colDetailKey.Width = 95;
            // 
            // colDetailPID
            // 
            this.colDetailPID.DataPropertyName = "PersistentID";
            this.colDetailPID.Frozen = true;
            this.colDetailPID.HeaderText = "Persistent ID";
            this.colDetailPID.Name = "colDetailPID";
            this.colDetailPID.ReadOnly = true;
            this.colDetailPID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDetailArrangement
            // 
            this.colDetailArrangement.DataPropertyName = "Name";
            this.colDetailArrangement.Frozen = true;
            this.colDetailArrangement.HeaderText = "Arrangement";
            this.colDetailArrangement.Name = "colDetailArrangement";
            this.colDetailArrangement.ReadOnly = true;
            this.colDetailArrangement.Width = 92;
            // 
            // colDetailTuning
            // 
            this.colDetailTuning.DataPropertyName = "Tuning";
            this.colDetailTuning.HeaderText = "Tuning";
            this.colDetailTuning.Name = "colDetailTuning";
            this.colDetailTuning.ReadOnly = true;
            this.colDetailTuning.Width = 65;
            // 
            // colDetailSections
            // 
            this.colDetailSections.DataPropertyName = "SectionCount";
            this.colDetailSections.HeaderText = "Sections";
            this.colDetailSections.Name = "colDetailSections";
            this.colDetailSections.ReadOnly = true;
            this.colDetailSections.Width = 73;
            // 
            // colDetailDMax
            // 
            this.colDetailDMax.DataPropertyName = "DMax";
            this.colDetailDMax.HeaderText = "DMax";
            this.colDetailDMax.Name = "colDetailDMax";
            this.colDetailDMax.ReadOnly = true;
            this.colDetailDMax.Width = 60;
            // 
            // colDetailToneBase
            // 
            this.colDetailToneBase.DataPropertyName = "ToneBase";
            this.colDetailToneBase.HeaderText = "Tone Base";
            this.colDetailToneBase.Name = "colDetailToneBase";
            this.colDetailToneBase.ReadOnly = true;
            this.colDetailToneBase.Width = 84;
            // 
            // colDetailChordCount
            // 
            this.colDetailChordCount.DataPropertyName = "ChordCount";
            this.colDetailChordCount.HeaderText = "Chord Count";
            this.colDetailChordCount.Name = "colDetailChordCount";
            this.colDetailChordCount.ReadOnly = true;
            this.colDetailChordCount.Width = 91;
            // 
            // colDetailNoteCount
            // 
            this.colDetailNoteCount.DataPropertyName = "NoteCount";
            this.colDetailNoteCount.HeaderText = "Note Count";
            this.colDetailNoteCount.Name = "colDetailNoteCount";
            this.colDetailNoteCount.ReadOnly = true;
            this.colDetailNoteCount.Width = 86;
            // 
            // colDetailOctaveCount
            // 
            this.colDetailOctaveCount.DataPropertyName = "OctaveCount";
            this.colDetailOctaveCount.HeaderText = "Octave Count";
            this.colDetailOctaveCount.Name = "colDetailOctaveCount";
            this.colDetailOctaveCount.ReadOnly = true;
            this.colDetailOctaveCount.Visible = false;
            this.colDetailOctaveCount.Width = 98;
            // 
            // colDetailChords
            // 
            this.colDetailChords.DataPropertyName = "ChordCountsCombined";
            this.colDetailChords.HeaderText = "Chords";
            this.colDetailChords.Name = "colDetailChords";
            this.colDetailChords.ReadOnly = true;
            this.colDetailChords.Width = 65;
            // 
            // dgvSongsMaster
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSongsMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvSongsMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSongsMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvSongsMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShowDetail,
            this.colKey,
            this.colSelect,
            this.colBass,
            this.colLead,
            this.colRhythm,
            this.colVocals,
            this.colRepairStatus,
            this.colEnabled,
            this.colArtist,
            this.colTitle,
            this.colAlbum,
            this.colSongYear,
            this.colArrangements,
            this.colTuning,
            this.colDD,
            this.colSongLength,
            this.colAvgTempo,
            this.colAppID,
            this.colFileName,
            this.colFilePath,
            this.colFileDate,
            this.colFileSize,
            this.colStatus,
            this.colCharter,
            this.colUpdated,
            this.colVersion,
            this.colToolkitVersion,
            this.colTagged,
            this.colIgnitionID,
            this.colIgnitionUpdated,
            this.colIgnitionVersion,
            this.colIgnitionAuthor,
            this.colArtistTitleAlbum,
            this.colArtistSort,
            this.colTitleSort,
            this.colAlbumSort,
            this.colNoteCount,
            this.colChordCount,
            this.colOctaveCount,
            this.colVibratoCount,
            this.colHammerOnCount,
            this.colBendCount,
            this.colPullOffCount,
            this.colHarmonicCount,
            this.colFretHandMuteCount,
            this.colPalmMuteCount,
            this.colPluckCount,
            this.colSlapCount,
            this.colPopCount,
            this.colSlideCount,
            this.colSustainCount,
            this.colTremoloCount,
            this.colPinchHarmonicCount,
            this.colUnpitchedSlideCount,
            this.colTotalTapCount,
            this.colHighestFretUsed});
            this.dgvSongsMaster.Location = new System.Drawing.Point(6, 19);
            this.dgvSongsMaster.Name = "dgvSongsMaster";
            this.dgvSongsMaster.RowHeadersVisible = false;
            this.dgvSongsMaster.Size = new System.Drawing.Size(879, 348);
            this.dgvSongsMaster.TabIndex = 1;
            this.dgvSongsMaster.Tag = "Song Manager";
            this.dgvSongsMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongsMaster_CellContentClick);
            this.dgvSongsMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongsMaster_CellDoubleClick);
            this.dgvSongsMaster.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSongsMaster_CellFormatting);
            this.dgvSongsMaster.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSongsMaster_CellMouseDown);
            this.dgvSongsMaster.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSongsMaster_CellMouseUp);
            this.dgvSongsMaster.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSongsMaster_CellMouseUp);
            this.dgvSongsMaster.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSongsMaster_DataBindingComplete);
            this.dgvSongsMaster.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvSongsMaster_Scroll);
            this.dgvSongsMaster.Sorted += new System.EventHandler(this.dgvSongsMaster_Sorted);
            this.dgvSongsMaster.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvSongsMaster_Paint);
            this.dgvSongsMaster.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSongsMaster_KeyDown);
            this.dgvSongsMaster.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvSongsMaster_KeyUp);
            // 
            // colShowDetail
            // 
            this.colShowDetail.DataPropertyName = "ShowDetail";
            this.colShowDetail.Frozen = true;
            this.colShowDetail.HeaderText = "";
            this.colShowDetail.Image = ((System.Drawing.Image)(resources.GetObject("colShowDetail.Image")));
            this.colShowDetail.Name = "colShowDetail";
            this.colShowDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colShowDetail.Width = 20;
            // 
            // colKey
            // 
            this.colKey.DataPropertyName = "DLCKey";
            this.colKey.HeaderText = "DLC Key";
            this.colKey.Name = "colKey";
            this.colKey.ReadOnly = true;
            this.colKey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colKey.Width = 95;
            // 
            // colSelect
            // 
            this.colSelect.DataPropertyName = "Selected";
            this.colSelect.FalseValue = "false";
            this.colSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colSelect.HeaderText = "Select";
            this.colSelect.IndeterminateValue = "false";
            this.colSelect.Name = "colSelect";
            this.colSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSelect.TrueValue = "true";
            this.colSelect.Width = 50;
            // 
            // colBass
            // 
            this.colBass.DataPropertyName = "Bass";
            this.colBass.HeaderText = "B";
            this.colBass.Image = ((System.Drawing.Image)(resources.GetObject("colBass.Image")));
            this.colBass.MinimumWidth = 21;
            this.colBass.Name = "colBass";
            this.colBass.ReadOnly = true;
            this.colBass.ToolTipText = "Bass";
            this.colBass.Visible = false;
            this.colBass.Width = 21;
            // 
            // colLead
            // 
            this.colLead.DataPropertyName = "Lead";
            this.colLead.HeaderText = "L";
            this.colLead.Image = ((System.Drawing.Image)(resources.GetObject("colLead.Image")));
            this.colLead.MinimumWidth = 21;
            this.colLead.Name = "colLead";
            this.colLead.ReadOnly = true;
            this.colLead.ToolTipText = "Lead";
            this.colLead.Visible = false;
            this.colLead.Width = 21;
            // 
            // colRhythm
            // 
            this.colRhythm.DataPropertyName = "Rhythm";
            this.colRhythm.HeaderText = "R";
            this.colRhythm.Image = ((System.Drawing.Image)(resources.GetObject("colRhythm.Image")));
            this.colRhythm.MinimumWidth = 21;
            this.colRhythm.Name = "colRhythm";
            this.colRhythm.ReadOnly = true;
            this.colRhythm.ToolTipText = "Rhythm";
            this.colRhythm.Visible = false;
            this.colRhythm.Width = 21;
            // 
            // colVocals
            // 
            this.colVocals.DataPropertyName = "Vocals";
            this.colVocals.HeaderText = "V";
            this.colVocals.Image = ((System.Drawing.Image)(resources.GetObject("colVocals.Image")));
            this.colVocals.MinimumWidth = 21;
            this.colVocals.Name = "colVocals";
            this.colVocals.ReadOnly = true;
            this.colVocals.ToolTipText = "Vocals";
            this.colVocals.Visible = false;
            this.colVocals.Width = 21;
            // 
            // colRepairStatus
            // 
            this.colRepairStatus.DataPropertyName = "RepairStatus";
            this.colRepairStatus.HeaderText = "Repair Status";
            this.colRepairStatus.Name = "colRepairStatus";
            this.colRepairStatus.ReadOnly = true;
            this.colRepairStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colEnabled
            // 
            this.colEnabled.DataPropertyName = "Enabled";
            this.colEnabled.HeaderText = "Enabled";
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.ReadOnly = true;
            this.colEnabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEnabled.Width = 72;
            // 
            // colArtist
            // 
            this.colArtist.DataPropertyName = "Artist";
            this.colArtist.HeaderText = "Artist";
            this.colArtist.Name = "colArtist";
            this.colArtist.ReadOnly = true;
            this.colArtist.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "Song Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colAlbum
            // 
            this.colAlbum.DataPropertyName = "Album";
            this.colAlbum.HeaderText = "Album";
            this.colAlbum.Name = "colAlbum";
            this.colAlbum.ReadOnly = true;
            this.colAlbum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAlbum.Visible = false;
            // 
            // colSongYear
            // 
            this.colSongYear.DataPropertyName = "SongYear";
            this.colSongYear.HeaderText = "Year";
            this.colSongYear.Name = "colSongYear";
            this.colSongYear.ReadOnly = true;
            this.colSongYear.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSongYear.Visible = false;
            this.colSongYear.Width = 50;
            // 
            // colArrangements
            // 
            this.colArrangements.DataPropertyName = "Arrangements";
            this.colArrangements.HeaderText = "Arrangements";
            this.colArrangements.Name = "colArrangements";
            this.colArrangements.ReadOnly = true;
            this.colArrangements.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colArrangements.Visible = false;
            this.colArrangements.Width = 50;
            // 
            // colTuning
            // 
            this.colTuning.DataPropertyName = "Tuning";
            this.colTuning.HeaderText = "Tuning";
            this.colTuning.Name = "colTuning";
            this.colTuning.ReadOnly = true;
            this.colTuning.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDD
            // 
            this.colDD.DataPropertyName = "DD";
            this.colDD.HeaderText = "DD";
            this.colDD.Name = "colDD";
            this.colDD.ReadOnly = true;
            this.colDD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colSongLength
            // 
            this.colSongLength.DataPropertyName = "SongLength";
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.NullValue = null;
            this.colSongLength.DefaultCellStyle = dataGridViewCellStyle21;
            this.colSongLength.HeaderText = "Length Seconds";
            this.colSongLength.Name = "colSongLength";
            this.colSongLength.ReadOnly = true;
            this.colSongLength.Visible = false;
            // 
            // colAvgTempo
            // 
            this.colAvgTempo.DataPropertyName = "SongAverageTempo";
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewCellStyle22.NullValue = null;
            this.colAvgTempo.DefaultCellStyle = dataGridViewCellStyle22;
            this.colAvgTempo.HeaderText = "BPM";
            this.colAvgTempo.Name = "colAvgTempo";
            this.colAvgTempo.ReadOnly = true;
            this.colAvgTempo.Visible = false;
            // 
            // colAppID
            // 
            this.colAppID.DataPropertyName = "AppID";
            this.colAppID.HeaderText = "App ID";
            this.colAppID.Name = "colAppID";
            this.colAppID.ReadOnly = true;
            this.colAppID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAppID.Width = 80;
            // 
            // colFileName
            // 
            this.colFileName.DataPropertyName = "FileName";
            this.colFileName.HeaderText = "File Name";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            this.colFileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFileName.Visible = false;
            this.colFileName.Width = 50;
            // 
            // colFilePath
            // 
            this.colFilePath.DataPropertyName = "FilePath";
            this.colFilePath.HeaderText = "File Path";
            this.colFilePath.Name = "colFilePath";
            this.colFilePath.ReadOnly = true;
            this.colFilePath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFilePath.Width = 150;
            // 
            // colFileDate
            // 
            this.colFileDate.DataPropertyName = "FileDate";
            this.colFileDate.HeaderText = "File Date";
            this.colFileDate.Name = "colFileDate";
            this.colFileDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFileDate.Visible = false;
            // 
            // colFileSize
            // 
            this.colFileSize.DataPropertyName = "FileSize";
            this.colFileSize.HeaderText = "File Size (bytes)";
            this.colFileSize.Name = "colFileSize";
            this.colFileSize.Visible = false;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStatus.Visible = false;
            this.colStatus.Width = 50;
            // 
            // colCharter
            // 
            this.colCharter.DataPropertyName = "CharterName";
            this.colCharter.HeaderText = "Charter";
            this.colCharter.Name = "colCharter";
            this.colCharter.ReadOnly = true;
            this.colCharter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCharter.Visible = false;
            this.colCharter.Width = 50;
            // 
            // colUpdated
            // 
            this.colUpdated.DataPropertyName = "LastConversionDateTime";
            dataGridViewCellStyle23.NullValue = null;
            this.colUpdated.DefaultCellStyle = dataGridViewCellStyle23;
            this.colUpdated.HeaderText = "Updated";
            this.colUpdated.Name = "colUpdated";
            this.colUpdated.ReadOnly = true;
            this.colUpdated.Visible = false;
            this.colUpdated.Width = 50;
            // 
            // colVersion
            // 
            this.colVersion.DataPropertyName = "Version";
            this.colVersion.HeaderText = "Version";
            this.colVersion.Name = "colVersion";
            this.colVersion.ReadOnly = true;
            this.colVersion.Visible = false;
            this.colVersion.Width = 50;
            // 
            // colToolkitVersion
            // 
            this.colToolkitVersion.DataPropertyName = "ToolkitVer";
            this.colToolkitVersion.HeaderText = "Toolkit Version";
            this.colToolkitVersion.Name = "colToolkitVersion";
            this.colToolkitVersion.ReadOnly = true;
            this.colToolkitVersion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colToolkitVersion.Width = 110;
            // 
            // colTagged
            // 
            this.colTagged.DataPropertyName = "Tagged";
            this.colTagged.HeaderText = "Tagged";
            this.colTagged.Name = "colTagged";
            this.colTagged.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTagged.Width = 72;
            // 
            // colIgnitionID
            // 
            this.colIgnitionID.DataPropertyName = "IgnitionID";
            this.colIgnitionID.HeaderText = "Ignition ID";
            this.colIgnitionID.Name = "colIgnitionID";
            this.colIgnitionID.ReadOnly = true;
            this.colIgnitionID.Visible = false;
            this.colIgnitionID.Width = 50;
            // 
            // colIgnitionUpdated
            // 
            this.colIgnitionUpdated.DataPropertyName = "IgnitionUpdated";
            dataGridViewCellStyle24.NullValue = null;
            this.colIgnitionUpdated.DefaultCellStyle = dataGridViewCellStyle24;
            this.colIgnitionUpdated.HeaderText = "Ignition Updated";
            this.colIgnitionUpdated.Name = "colIgnitionUpdated";
            this.colIgnitionUpdated.ReadOnly = true;
            this.colIgnitionUpdated.Visible = false;
            this.colIgnitionUpdated.Width = 50;
            // 
            // colIgnitionVersion
            // 
            this.colIgnitionVersion.DataPropertyName = "IgnitionVersion";
            this.colIgnitionVersion.HeaderText = "Ignition Version";
            this.colIgnitionVersion.Name = "colIgnitionVersion";
            this.colIgnitionVersion.ReadOnly = true;
            this.colIgnitionVersion.Visible = false;
            this.colIgnitionVersion.Width = 50;
            // 
            // colIgnitionAuthor
            // 
            this.colIgnitionAuthor.DataPropertyName = "IgnitionAuthor";
            this.colIgnitionAuthor.HeaderText = "Ignition Author";
            this.colIgnitionAuthor.Name = "colIgnitionAuthor";
            this.colIgnitionAuthor.ReadOnly = true;
            this.colIgnitionAuthor.Visible = false;
            this.colIgnitionAuthor.Width = 50;
            // 
            // colArtistTitleAlbum
            // 
            this.colArtistTitleAlbum.DataPropertyName = "ArtistTitleAlbum";
            this.colArtistTitleAlbum.HeaderText = "ArtistTitleAlbum";
            this.colArtistTitleAlbum.Name = "colArtistTitleAlbum";
            this.colArtistTitleAlbum.ReadOnly = true;
            this.colArtistTitleAlbum.Visible = false;
            // 
            // colArtistSort
            // 
            this.colArtistSort.DataPropertyName = "ArtistSort";
            this.colArtistSort.HeaderText = "In-Game Artist Sort";
            this.colArtistSort.Name = "colArtistSort";
            this.colArtistSort.ReadOnly = true;
            this.colArtistSort.Visible = false;
            this.colArtistSort.Width = 50;
            // 
            // colTitleSort
            // 
            this.colTitleSort.DataPropertyName = "TitleSort";
            this.colTitleSort.HeaderText = "In-Game Title Sort";
            this.colTitleSort.Name = "colTitleSort";
            this.colTitleSort.ReadOnly = true;
            this.colTitleSort.Visible = false;
            this.colTitleSort.Width = 50;
            // 
            // colAlbumSort
            // 
            this.colAlbumSort.DataPropertyName = "AlbumSort";
            this.colAlbumSort.HeaderText = "In-Game Album Sort";
            this.colAlbumSort.Name = "colAlbumSort";
            this.colAlbumSort.ReadOnly = true;
            this.colAlbumSort.Visible = false;
            this.colAlbumSort.Width = 50;
            // 
            // colNoteCount
            // 
            this.colNoteCount.DataPropertyName = "NoteCount";
            this.colNoteCount.HeaderText = "Note Count";
            this.colNoteCount.Name = "colNoteCount";
            this.colNoteCount.ReadOnly = true;
            this.colNoteCount.Visible = false;
            // 
            // colChordCount
            // 
            this.colChordCount.DataPropertyName = "ChordCount";
            this.colChordCount.HeaderText = "Chord Count";
            this.colChordCount.Name = "colChordCount";
            this.colChordCount.ReadOnly = true;
            this.colChordCount.Visible = false;
            // 
            // colOctaveCount
            // 
            this.colOctaveCount.DataPropertyName = "OctaveCount";
            this.colOctaveCount.HeaderText = "Octave Count";
            this.colOctaveCount.Name = "colOctaveCount";
            this.colOctaveCount.ReadOnly = true;
            this.colOctaveCount.Visible = false;
            // 
            // colVibratoCount
            // 
            this.colVibratoCount.DataPropertyName = "VibratoCount";
            this.colVibratoCount.HeaderText = "Vibrato Count";
            this.colVibratoCount.Name = "colVibratoCount";
            this.colVibratoCount.ReadOnly = true;
            this.colVibratoCount.Visible = false;
            // 
            // colHammerOnCount
            // 
            this.colHammerOnCount.DataPropertyName = "HammerOnCount";
            this.colHammerOnCount.HeaderText = "Hammer-On Count";
            this.colHammerOnCount.Name = "colHammerOnCount";
            this.colHammerOnCount.ReadOnly = true;
            this.colHammerOnCount.Visible = false;
            // 
            // colBendCount
            // 
            this.colBendCount.DataPropertyName = "BendCount";
            this.colBendCount.HeaderText = "Bend Count";
            this.colBendCount.Name = "colBendCount";
            this.colBendCount.ReadOnly = true;
            this.colBendCount.Visible = false;
            // 
            // colPullOffCount
            // 
            this.colPullOffCount.DataPropertyName = "PullOffCount";
            this.colPullOffCount.HeaderText = "Pull-Off Count";
            this.colPullOffCount.Name = "colPullOffCount";
            this.colPullOffCount.ReadOnly = true;
            this.colPullOffCount.Visible = false;
            // 
            // colHarmonicCount
            // 
            this.colHarmonicCount.DataPropertyName = "HarmonicCount";
            this.colHarmonicCount.HeaderText = "Harmonic Count";
            this.colHarmonicCount.Name = "colHarmonicCount";
            this.colHarmonicCount.ReadOnly = true;
            this.colHarmonicCount.Visible = false;
            // 
            // colFretHandMuteCount
            // 
            this.colFretHandMuteCount.DataPropertyName = "FretHandMuteCount";
            this.colFretHandMuteCount.HeaderText = "Frethand Mute Count";
            this.colFretHandMuteCount.Name = "colFretHandMuteCount";
            this.colFretHandMuteCount.ReadOnly = true;
            this.colFretHandMuteCount.Visible = false;
            // 
            // colPalmMuteCount
            // 
            this.colPalmMuteCount.DataPropertyName = "PalmMuteCount";
            this.colPalmMuteCount.HeaderText = "PalmMute Count";
            this.colPalmMuteCount.Name = "colPalmMuteCount";
            this.colPalmMuteCount.ReadOnly = true;
            this.colPalmMuteCount.Visible = false;
            // 
            // colPluckCount
            // 
            this.colPluckCount.DataPropertyName = "PluckCount";
            this.colPluckCount.HeaderText = "Pluck Count";
            this.colPluckCount.Name = "colPluckCount";
            this.colPluckCount.ReadOnly = true;
            this.colPluckCount.Visible = false;
            // 
            // colSlapCount
            // 
            this.colSlapCount.DataPropertyName = "SlapCount";
            this.colSlapCount.HeaderText = "Slap Count";
            this.colSlapCount.Name = "colSlapCount";
            this.colSlapCount.ReadOnly = true;
            this.colSlapCount.Visible = false;
            // 
            // colPopCount
            // 
            this.colPopCount.DataPropertyName = "PopCount";
            this.colPopCount.HeaderText = "Pop Count";
            this.colPopCount.Name = "colPopCount";
            this.colPopCount.ReadOnly = true;
            this.colPopCount.Visible = false;
            // 
            // colSlideCount
            // 
            this.colSlideCount.DataPropertyName = "SlideCount";
            this.colSlideCount.HeaderText = "Slide Count";
            this.colSlideCount.Name = "colSlideCount";
            this.colSlideCount.ReadOnly = true;
            this.colSlideCount.Visible = false;
            // 
            // colSustainCount
            // 
            this.colSustainCount.DataPropertyName = "SustainCount";
            this.colSustainCount.HeaderText = "Sustain Count";
            this.colSustainCount.Name = "colSustainCount";
            this.colSustainCount.ReadOnly = true;
            this.colSustainCount.Visible = false;
            // 
            // colTremoloCount
            // 
            this.colTremoloCount.DataPropertyName = "TremoloCount";
            this.colTremoloCount.HeaderText = "Tremolo Count";
            this.colTremoloCount.Name = "colTremoloCount";
            this.colTremoloCount.ReadOnly = true;
            this.colTremoloCount.Visible = false;
            // 
            // colPinchHarmonicCount
            // 
            this.colPinchHarmonicCount.DataPropertyName = "HarmonicPinchCount";
            this.colPinchHarmonicCount.HeaderText = "Pinch Harmonic Count";
            this.colPinchHarmonicCount.Name = "colPinchHarmonicCount";
            this.colPinchHarmonicCount.ReadOnly = true;
            this.colPinchHarmonicCount.Visible = false;
            // 
            // colUnpitchedSlideCount
            // 
            this.colUnpitchedSlideCount.DataPropertyName = "UnpitchedSlideCount";
            this.colUnpitchedSlideCount.HeaderText = "Unpitched Slide Count";
            this.colUnpitchedSlideCount.Name = "colUnpitchedSlideCount";
            this.colUnpitchedSlideCount.ReadOnly = true;
            this.colUnpitchedSlideCount.Visible = false;
            // 
            // colTotalTapCount
            // 
            this.colTotalTapCount.DataPropertyName = "TapCount";
            this.colTotalTapCount.HeaderText = "Tap Count";
            this.colTotalTapCount.Name = "colTotalTapCount";
            this.colTotalTapCount.ReadOnly = true;
            this.colTotalTapCount.Visible = false;
            // 
            // colHighestFretUsed
            // 
            this.colHighestFretUsed.DataPropertyName = "HighestFretUsed";
            this.colHighestFretUsed.HeaderText = "Highest Fret Used";
            this.colHighestFretUsed.Name = "colHighestFretUsed";
            this.colHighestFretUsed.ReadOnly = true;
            this.colHighestFretUsed.Visible = false;
            // 
            // lnklblToggle
            // 
            this.lnklblToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnklblToggle.AutoSize = true;
            this.lnklblToggle.ForeColor = System.Drawing.Color.Black;
            this.lnklblToggle.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lnklblToggle.Location = new System.Drawing.Point(109, 370);
            this.lnklblToggle.Name = "lnklblToggle";
            this.lnklblToggle.Size = new System.Drawing.Size(87, 13);
            this.lnklblToggle.TabIndex = 4;
            this.lnklblToggle.TabStop = true;
            this.lnklblToggle.Text = "Toggle Selection";
            this.lnklblToggle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.lnklblToggle, "ODLC are not toggleable");
            this.lnklblToggle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblToggle_LinkClicked);
            // 
            // cmsSongManagerColumns
            // 
            this.cmsSongManagerColumns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.cmsSongManagerColumns.Name = "cmsSongManagerColumns";
            this.cmsSongManagerColumns.Size = new System.Drawing.Size(107, 26);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.AssociatedEnumValue = null;
            this.testToolStripMenuItem.Checked = true;
            this.testToolStripMenuItem.CheckOnClick = true;
            this.testToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.testToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.RadioButtonGroupName = null;
            this.testToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 200;
            this.toolTip.AutoPopDelay = 12000;
            this.toolTip.InitialDelay = 200;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRescan,
            this.tsmiRepairs,
            this.tsmiDuplicates,
            this.tsmiMods,
            this.tsmiFiles,
            this.tsmiHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(899, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmiRescan
            // 
            this.tsmiRescan.AssociatedEnumValue = null;
            this.tsmiRescan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRescanQuick,
            this.tsmiRescanFull});
            this.tsmiRescan.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRescan.Image")));
            this.tsmiRescan.Name = "tsmiRescan";
            this.tsmiRescan.RadioButtonGroupName = null;
            this.tsmiRescan.Size = new System.Drawing.Size(70, 20);
            this.tsmiRescan.Text = "Rescan";
            this.tsmiRescan.ToolTipText = "See \'Settings\' menu for additional\r\ndata rescan and inclusion options.";
            // 
            // tsmiRescanQuick
            // 
            this.tsmiRescanQuick.AssociatedEnumValue = null;
            this.tsmiRescanQuick.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRescanQuick.Image")));
            this.tsmiRescanQuick.Name = "tsmiRescanQuick";
            this.tsmiRescanQuick.RadioButtonGroupName = null;
            this.tsmiRescanQuick.Size = new System.Drawing.Size(111, 22);
            this.tsmiRescanQuick.Text = "Quick";
            this.tsmiRescanQuick.ToolTipText = "Quick reload of previously scanned data.\r\nOnly rescans data if necessary.";
            this.tsmiRescanQuick.Click += new System.EventHandler(this.tsmiRescanQuick_Click);
            // 
            // tsmiRescanFull
            // 
            this.tsmiRescanFull.AssociatedEnumValue = null;
            this.tsmiRescanFull.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRescanFull.Image")));
            this.tsmiRescanFull.Name = "tsmiRescanFull";
            this.tsmiRescanFull.RadioButtonGroupName = null;
            this.tsmiRescanFull.Size = new System.Drawing.Size(111, 22);
            this.tsmiRescanFull.Text = "Full";
            this.tsmiRescanFull.ToolTipText = "Preliminary scan or after significant changes.\r\n\r\nHint:\r\nTry running a \'Full\' res" +
                "can if the CDLC\r\ncollection does not look as expected.";
            this.tsmiRescanFull.Click += new System.EventHandler(this.tsmiRescanFull_Click);
            // 
            // tsmiRepairs
            // 
            this.tsmiRepairs.AssociatedEnumValue = null;
            this.tsmiRepairs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSkipRemastered,
            this.toolStripSeparator12,
            this.tsmiRepairsAddDD,
            this.tsmiAddDDSettings,
            this.tsmiOverwriteDD,
            this.toolStripSeparator9,
            this.tsmiRepairsMastery,
            this.tsmiRepairsPreserveStats,
            this.tsmiRepairsUsingOrg,
            this.tsmiRepairsMultitone,
            this.toolStripSeparator8,
            this.tsmiRepairsMaxFive,
            this.tsmiRemoveNDD,
            this.tsmiRemoveBass,
            this.tsmiRemoveGuitar,
            this.tsmiRemoveBonus,
            this.tsmiRemoveMetronome,
            this.tsmiIgnoreStopLimit,
            this.toolStripSeparator7,
            this.tsmiRemoveSections,
            this.toolStripSeparator10,
            this.tsmiProcessDLFolder,
            this.toolStripSeparator13,
            this.tsmiRepairsRun});
            this.tsmiRepairs.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRepairs.Image")));
            this.tsmiRepairs.Name = "tsmiRepairs";
            this.tsmiRepairs.RadioButtonGroupName = null;
            this.tsmiRepairs.Size = new System.Drawing.Size(71, 20);
            this.tsmiRepairs.Text = "Repairs";
            this.tsmiRepairs.ToolTipText = resources.GetString("tsmiRepairs.ToolTipText");
            // 
            // tsmiSkipRemastered
            // 
            this.tsmiSkipRemastered.AssociatedEnumValue = null;
            this.tsmiSkipRemastered.AutoCheck = false;
            this.tsmiSkipRemastered.CheckMarkDisplayStyle = CustomControls.CheckMarkDisplayStyle.RadioButton;
            this.tsmiSkipRemastered.CheckOnClick = true;
            this.tsmiSkipRemastered.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tsmiSkipRemastered.Name = "tsmiSkipRemastered";
            this.tsmiSkipRemastered.RadioButtonGroupName = "SkipRemastered";
            this.tsmiSkipRemastered.Size = new System.Drawing.Size(246, 22);
            this.tsmiSkipRemastered.Text = "Skip Previously Remastered CDLC";
            this.tsmiSkipRemastered.ToolTipText = "Skipping previously remastered CDLC\r\nwill greatly speed up the repair\r\nprocess.";
            this.tsmiSkipRemastered.Click += new System.EventHandler(this.RepairsButton_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(243, 6);
            // 
            // tsmiRepairsAddDD
            // 
            this.tsmiRepairsAddDD.AssociatedEnumValue = null;
            this.tsmiRepairsAddDD.AutoCheck = false;
            this.tsmiRepairsAddDD.CheckMarkDisplayStyle = CustomControls.CheckMarkDisplayStyle.RadioButton;
            this.tsmiRepairsAddDD.CheckOnClick = true;
            this.tsmiRepairsAddDD.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiRepairsAddDD.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tsmiRepairsAddDD.Name = "tsmiRepairsAddDD";
            this.tsmiRepairsAddDD.RadioButtonGroupName = "AddDD";
            this.tsmiRepairsAddDD.Size = new System.Drawing.Size(246, 22);
            this.tsmiRepairsAddDD.Text = "Add Dynamic Difficulty (DD)";
            this.tsmiRepairsAddDD.ToolTipText = "Fixes Remastered Play Count tracking\r\nby adding Dynamic Difficulty (DD) to\r\narran" +
                "gements that do not have DD";
            this.tsmiRepairsAddDD.Click += new System.EventHandler(this.RepairsButton_Click);
            // 
            // tsmiAddDDSettings
            // 
            this.tsmiAddDDSettings.AssociatedEnumValue = null;
            this.tsmiAddDDSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddDDNumericUpDown,
            this.tsmiAddDDRemoveSustain,
            this.tsmiAddDDCfgPath,
            this.tsmiAddDDRampUpPath});
            this.tsmiAddDDSettings.Name = "tsmiAddDDSettings";
            this.tsmiAddDDSettings.RadioButtonGroupName = "AddDD";
            this.tsmiAddDDSettings.Size = new System.Drawing.Size(246, 22);
            this.tsmiAddDDSettings.Text = "Customizable DDC Settings";
            this.tsmiAddDDSettings.ToolTipText = "Configuration settings for ddc.exe CLI";
            // 
            // tsmiAddDDNumericUpDown
            // 
            this.tsmiAddDDNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.tsmiAddDDNumericUpDown.DecimalPlaces = 0;
            this.tsmiAddDDNumericUpDown.Margin = new System.Windows.Forms.Padding(0, 1, 3, 1);
            this.tsmiAddDDNumericUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.tsmiAddDDNumericUpDown.Name = "tsmiAddDDNumericUpDown";
            this.tsmiAddDDNumericUpDown.NumBackColor = System.Drawing.SystemColors.Window;
            this.tsmiAddDDNumericUpDown.Size = new System.Drawing.Size(53, 22);
            this.tsmiAddDDNumericUpDown.Text = "Phrase Length";
            this.tsmiAddDDNumericUpDown.TextVisible = false;
            this.tsmiAddDDNumericUpDown.ToolTipText = "Set custom Phrase Length greater than eight";
            this.tsmiAddDDNumericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.tsmiAddDDNumericUpDown.Click += new System.EventHandler(this.RepairsAddDDSettings_Click);
            // 
            // tsmiAddDDRemoveSustain
            // 
            this.tsmiAddDDRemoveSustain.AssociatedEnumValue = null;
            this.tsmiAddDDRemoveSustain.CheckOnClick = true;
            this.tsmiAddDDRemoveSustain.Name = "tsmiAddDDRemoveSustain";
            this.tsmiAddDDRemoveSustain.RadioButtonGroupName = "AddDD";
            this.tsmiAddDDRemoveSustain.Size = new System.Drawing.Size(260, 22);
            this.tsmiAddDDRemoveSustain.Text = "Remove Sustain";
            this.tsmiAddDDRemoveSustain.ToolTipText = "If checked, sustain will be removed.";
            this.tsmiAddDDRemoveSustain.Click += new System.EventHandler(this.RepairsAddDDSettings_Click);
            // 
            // tsmiAddDDCfgPath
            // 
            this.tsmiAddDDCfgPath.AssociatedEnumValue = null;
            this.tsmiAddDDCfgPath.AutoSize = false;
            this.tsmiAddDDCfgPath.Name = "tsmiAddDDCfgPath";
            this.tsmiAddDDCfgPath.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.tsmiAddDDCfgPath.RadioButtonGroupName = null;
            this.tsmiAddDDCfgPath.Size = new System.Drawing.Size(170, 22);
            this.tsmiAddDDCfgPath.Spring = true;
            this.tsmiAddDDCfgPath.Text = "Click to set CFG path";
            this.tsmiAddDDCfgPath.ToolTipText = "Set custom CFG path";
            this.tsmiAddDDCfgPath.Click += new System.EventHandler(this.tsmiAddDDCfgPath_Click);
            // 
            // tsmiAddDDRampUpPath
            // 
            this.tsmiAddDDRampUpPath.AssociatedEnumValue = null;
            this.tsmiAddDDRampUpPath.AutoSize = false;
            this.tsmiAddDDRampUpPath.Name = "tsmiAddDDRampUpPath";
            this.tsmiAddDDRampUpPath.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.tsmiAddDDRampUpPath.RadioButtonGroupName = null;
            this.tsmiAddDDRampUpPath.Size = new System.Drawing.Size(170, 22);
            this.tsmiAddDDRampUpPath.Spring = true;
            this.tsmiAddDDRampUpPath.Text = "Click to set RampUp path";
            this.tsmiAddDDRampUpPath.ToolTipText = "Set custom RampUp path";
            this.tsmiAddDDRampUpPath.Click += new System.EventHandler(this.tsmiAddDDRampUpPath_Click);
            // 
            // tsmiOverwriteDD
            // 
            this.tsmiOverwriteDD.AssociatedEnumValue = null;
            this.tsmiOverwriteDD.CheckOnClick = true;
            this.tsmiOverwriteDD.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiOverwriteDD.ForeColor = System.Drawing.Color.Red;
            this.tsmiOverwriteDD.Name = "tsmiOverwriteDD";
            this.tsmiOverwriteDD.RadioButtonGroupName = "AddDD";
            this.tsmiOverwriteDD.Size = new System.Drawing.Size(246, 22);
            this.tsmiOverwriteDD.Text = "Overwrite Existing DD";
            this.tsmiOverwriteDD.ToolTipText = "Overwrite existing Dynamic Difficulty (DD)\r\nwith new DD even if arrangement alrea" +
                "dy\r\nhas DD.";
            this.tsmiOverwriteDD.CheckStateChanged += new System.EventHandler(this.Repairs_CheckStateChanged);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(243, 6);
            // 
            // tsmiRepairsMastery
            // 
            this.tsmiRepairsMastery.AssociatedEnumValue = null;
            this.tsmiRepairsMastery.AutoCheck = false;
            this.tsmiRepairsMastery.CheckMarkDisplayStyle = CustomControls.CheckMarkDisplayStyle.RadioButton;
            this.tsmiRepairsMastery.CheckOnClick = true;
            this.tsmiRepairsMastery.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiRepairsMastery.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tsmiRepairsMastery.Name = "tsmiRepairsMastery";
            this.tsmiRepairsMastery.RadioButtonGroupName = "Mastery";
            this.tsmiRepairsMastery.Size = new System.Drawing.Size(246, 22);
            this.tsmiRepairsMastery.Text = "Mastery 100% Bug";
            this.tsmiRepairsMastery.ToolTipText = "Mastery 100% Bug is repaired\r\nby default regardless of\r\nother selected options.\r\n" +
                "\r\nOnce the Mastery Bug is repaired\r\nthe CDLC is considered to be\r\n\'Remastered\'.";
            this.tsmiRepairsMastery.Click += new System.EventHandler(this.RepairsButton_Click);
            // 
            // tsmiRepairsPreserveStats
            // 
            this.tsmiRepairsPreserveStats.AssociatedEnumValue = null;
            this.tsmiRepairsPreserveStats.CheckOnClick = true;
            this.tsmiRepairsPreserveStats.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiRepairsPreserveStats.Name = "tsmiRepairsPreserveStats";
            this.tsmiRepairsPreserveStats.RadioButtonGroupName = "Mastery";
            this.tsmiRepairsPreserveStats.Size = new System.Drawing.Size(246, 22);
            this.tsmiRepairsPreserveStats.Text = "Preserve Stats";
            this.tsmiRepairsPreserveStats.ToolTipText = resources.GetString("tsmiRepairsPreserveStats.ToolTipText");
            this.tsmiRepairsPreserveStats.CheckStateChanged += new System.EventHandler(this.Repairs_CheckStateChanged);
            this.tsmiRepairsPreserveStats.Click += new System.EventHandler(this.tsmiRepairsPreserveStats_Click);
            // 
            // tsmiRepairsUsingOrg
            // 
            this.tsmiRepairsUsingOrg.AssociatedEnumValue = null;
            this.tsmiRepairsUsingOrg.CheckOnClick = true;
            this.tsmiRepairsUsingOrg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiRepairsUsingOrg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiRepairsUsingOrg.Name = "tsmiRepairsUsingOrg";
            this.tsmiRepairsUsingOrg.RadioButtonGroupName = "Mastery";
            this.tsmiRepairsUsingOrg.Size = new System.Drawing.Size(246, 22);
            this.tsmiRepairsUsingOrg.Text = "Use (.org) Files";
            this.tsmiRepairsUsingOrg.ToolTipText = resources.GetString("tsmiRepairsUsingOrg.ToolTipText");
            this.tsmiRepairsUsingOrg.CheckStateChanged += new System.EventHandler(this.Repairs_CheckStateChanged);
            // 
            // tsmiRepairsMultitone
            // 
            this.tsmiRepairsMultitone.AssociatedEnumValue = null;
            this.tsmiRepairsMultitone.CheckOnClick = true;
            this.tsmiRepairsMultitone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiRepairsMultitone.ForeColor = System.Drawing.Color.Red;
            this.tsmiRepairsMultitone.Name = "tsmiRepairsMultitone";
            this.tsmiRepairsMultitone.RadioButtonGroupName = "Mastery";
            this.tsmiRepairsMultitone.Size = new System.Drawing.Size(246, 22);
            this.tsmiRepairsMultitone.Text = "Prevent Multitone Exceptions";
            this.tsmiRepairsMultitone.ToolTipText = "Prevent multitone exceptions\r\nby converting corrupt multitone\r\narrangements to si" +
                "ngle tone.";
            this.tsmiRepairsMultitone.Click += new System.EventHandler(this.Repairs_CheckStateChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(243, 6);
            // 
            // tsmiRepairsMaxFive
            // 
            this.tsmiRepairsMaxFive.AssociatedEnumValue = null;
            this.tsmiRepairsMaxFive.AutoCheck = false;
            this.tsmiRepairsMaxFive.CheckMarkDisplayStyle = CustomControls.CheckMarkDisplayStyle.RadioButton;
            this.tsmiRepairsMaxFive.CheckOnClick = true;
            this.tsmiRepairsMaxFive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiRepairsMaxFive.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tsmiRepairsMaxFive.Name = "tsmiRepairsMaxFive";
            this.tsmiRepairsMaxFive.RadioButtonGroupName = "MaxFive";
            this.tsmiRepairsMaxFive.Size = new System.Drawing.Size(246, 22);
            this.tsmiRepairsMaxFive.Text = "Max Five Arrangements";
            this.tsmiRepairsMaxFive.ToolTipText = "Select Max5 Repair Options";
            this.tsmiRepairsMaxFive.Click += new System.EventHandler(this.RepairsButton_Click);
            // 
            // tsmiRemoveNDD
            // 
            this.tsmiRemoveNDD.AssociatedEnumValue = null;
            this.tsmiRemoveNDD.CheckOnClick = true;
            this.tsmiRemoveNDD.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiRemoveNDD.Name = "tsmiRemoveNDD";
            this.tsmiRemoveNDD.RadioButtonGroupName = "MaxFive";
            this.tsmiRemoveNDD.Size = new System.Drawing.Size(246, 22);
            this.tsmiRemoveNDD.Text = "Remove NDD";
            this.tsmiRemoveNDD.CheckStateChanged += new System.EventHandler(this.Repairs_CheckStateChanged);
            // 
            // tsmiRemoveBass
            // 
            this.tsmiRemoveBass.AssociatedEnumValue = null;
            this.tsmiRemoveBass.CheckOnClick = true;
            this.tsmiRemoveBass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiRemoveBass.Name = "tsmiRemoveBass";
            this.tsmiRemoveBass.RadioButtonGroupName = "MaxFive";
            this.tsmiRemoveBass.Size = new System.Drawing.Size(246, 22);
            this.tsmiRemoveBass.Text = "Remove Bass";
            this.tsmiRemoveBass.CheckStateChanged += new System.EventHandler(this.Repairs_CheckStateChanged);
            // 
            // tsmiRemoveGuitar
            // 
            this.tsmiRemoveGuitar.AssociatedEnumValue = null;
            this.tsmiRemoveGuitar.CheckOnClick = true;
            this.tsmiRemoveGuitar.Name = "tsmiRemoveGuitar";
            this.tsmiRemoveGuitar.RadioButtonGroupName = "MaxFive";
            this.tsmiRemoveGuitar.Size = new System.Drawing.Size(246, 22);
            this.tsmiRemoveGuitar.Text = "Remove Guitar";
            this.tsmiRemoveGuitar.CheckStateChanged += new System.EventHandler(this.Repairs_CheckStateChanged);
            // 
            // tsmiRemoveBonus
            // 
            this.tsmiRemoveBonus.AssociatedEnumValue = null;
            this.tsmiRemoveBonus.CheckOnClick = true;
            this.tsmiRemoveBonus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiRemoveBonus.Name = "tsmiRemoveBonus";
            this.tsmiRemoveBonus.RadioButtonGroupName = "MaxFive";
            this.tsmiRemoveBonus.Size = new System.Drawing.Size(246, 22);
            this.tsmiRemoveBonus.Text = "Remove Bonus";
            this.tsmiRemoveBonus.CheckStateChanged += new System.EventHandler(this.Repairs_CheckStateChanged);
            // 
            // tsmiRemoveMetronome
            // 
            this.tsmiRemoveMetronome.AssociatedEnumValue = null;
            this.tsmiRemoveMetronome.CheckOnClick = true;
            this.tsmiRemoveMetronome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiRemoveMetronome.Name = "tsmiRemoveMetronome";
            this.tsmiRemoveMetronome.RadioButtonGroupName = "MaxFive";
            this.tsmiRemoveMetronome.Size = new System.Drawing.Size(246, 22);
            this.tsmiRemoveMetronome.Text = "Remove Metronone";
            this.tsmiRemoveMetronome.CheckStateChanged += new System.EventHandler(this.Repairs_CheckStateChanged);
            // 
            // tsmiIgnoreStopLimit
            // 
            this.tsmiIgnoreStopLimit.AssociatedEnumValue = null;
            this.tsmiIgnoreStopLimit.CheckOnClick = true;
            this.tsmiIgnoreStopLimit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiIgnoreStopLimit.ForeColor = System.Drawing.Color.Red;
            this.tsmiIgnoreStopLimit.Name = "tsmiIgnoreStopLimit";
            this.tsmiIgnoreStopLimit.RadioButtonGroupName = "MaxFive";
            this.tsmiIgnoreStopLimit.Size = new System.Drawing.Size(246, 22);
            this.tsmiIgnoreStopLimit.Text = "Ignore Arrangement Stop Limit";
            this.tsmiIgnoreStopLimit.ToolTipText = "Removes all arrangements of\r\nselected type and ignores\r\nstop limit.";
            this.tsmiIgnoreStopLimit.CheckStateChanged += new System.EventHandler(this.Repairs_CheckStateChanged);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(243, 6);
            // 
            // tsmiRemoveSections
            // 
            this.tsmiRemoveSections.AssociatedEnumValue = null;
            this.tsmiRemoveSections.AutoCheck = false;
            this.tsmiRemoveSections.CheckMarkDisplayStyle = CustomControls.CheckMarkDisplayStyle.RadioButton;
            this.tsmiRemoveSections.CheckOnClick = true;
            this.tsmiRemoveSections.Enabled = false;
            this.tsmiRemoveSections.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tsmiRemoveSections.Name = "tsmiRemoveSections";
            this.tsmiRemoveSections.RadioButtonGroupName = "RemoveSections";
            this.tsmiRemoveSections.Size = new System.Drawing.Size(246, 22);
            this.tsmiRemoveSections.Text = "Remove Sections/Phrases";
            this.tsmiRemoveSections.ToolTipText = "Coming Soon";
            this.tsmiRemoveSections.Visible = false;
            this.tsmiRemoveSections.Click += new System.EventHandler(this.RepairsButton_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(243, 6);
            this.toolStripSeparator10.Visible = false;
            // 
            // tsmiProcessDLFolder
            // 
            this.tsmiProcessDLFolder.AssociatedEnumValue = null;
            this.tsmiProcessDLFolder.AutoCheck = false;
            this.tsmiProcessDLFolder.CheckMarkDisplayStyle = CustomControls.CheckMarkDisplayStyle.RadioButton;
            this.tsmiProcessDLFolder.CheckOnClick = true;
            this.tsmiProcessDLFolder.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tsmiProcessDLFolder.Name = "tsmiProcessDLFolder";
            this.tsmiProcessDLFolder.RadioButtonGroupName = "ProcessDLFolder";
            this.tsmiProcessDLFolder.Size = new System.Drawing.Size(246, 22);
            this.tsmiProcessDLFolder.Text = "Process \'Downloads\' Folder";
            this.tsmiProcessDLFolder.ToolTipText = resources.GetString("tsmiProcessDLFolder.ToolTipText");
            this.tsmiProcessDLFolder.Click += new System.EventHandler(this.RepairsButton_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(243, 6);
            // 
            // tsmiRepairsRun
            // 
            this.tsmiRepairsRun.AssociatedEnumValue = null;
            this.tsmiRepairsRun.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiRepairsRun.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiRepairsRun.Name = "tsmiRepairsRun";
            this.tsmiRepairsRun.RadioButtonGroupName = null;
            this.tsmiRepairsRun.Size = new System.Drawing.Size(246, 22);
            this.tsmiRepairsRun.Text = "Run Selected Repair Optons";
            this.tsmiRepairsRun.ToolTipText = "Select repair options first";
            this.tsmiRepairsRun.Click += new System.EventHandler(this.tsmiRepairsRun_Click);
            // 
            // tsmiDuplicates
            // 
            this.tsmiDuplicates.AssociatedEnumValue = null;
            this.tsmiDuplicates.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDuplicatesSoon});
            this.tsmiDuplicates.Name = "tsmiDuplicates";
            this.tsmiDuplicates.RadioButtonGroupName = null;
            this.tsmiDuplicates.Size = new System.Drawing.Size(68, 20);
            this.tsmiDuplicates.Text = "Duplicates";
            this.tsmiDuplicates.Visible = false;
            // 
            // tsmiDuplicatesSoon
            // 
            this.tsmiDuplicatesSoon.AssociatedEnumValue = null;
            this.tsmiDuplicatesSoon.Name = "tsmiDuplicatesSoon";
            this.tsmiDuplicatesSoon.RadioButtonGroupName = null;
            this.tsmiDuplicatesSoon.Size = new System.Drawing.Size(158, 22);
            this.tsmiDuplicatesSoon.Text = "COMING SOON";
            // 
            // tsmiMods
            // 
            this.tsmiMods.AssociatedEnumValue = null;
            this.tsmiMods.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModsChangeAppId,
            this.toolStripSeparator4,
            this.tsmiModsPitchShifter,
            this.tsmiModsPitchShiftStandard,
            this.tsmiModsPreserveStats,
            this.tsmiModsPitchShiftOverwrite,
            this.toolStripSeparator5,
            this.tsmiTagStyle,
            this.tsmiModsTagArtwork,
            this.tsmiModsUntagArtwork,
            this.toolStripSeparator14,
            this.tsmiModsTheMover,
            this.tsmiModsMyCDLC});
            this.tsmiMods.Name = "tsmiMods";
            this.tsmiMods.RadioButtonGroupName = null;
            this.tsmiMods.Size = new System.Drawing.Size(83, 20);
            this.tsmiMods.Text = "Custom Mods";
            // 
            // tsmiModsChangeAppId
            // 
            this.tsmiModsChangeAppId.AssociatedEnumValue = null;
            this.tsmiModsChangeAppId.Image = ((System.Drawing.Image)(resources.GetObject("tsmiModsChangeAppId.Image")));
            this.tsmiModsChangeAppId.Name = "tsmiModsChangeAppId";
            this.tsmiModsChangeAppId.RadioButtonGroupName = null;
            this.tsmiModsChangeAppId.Size = new System.Drawing.Size(203, 22);
            this.tsmiModsChangeAppId.Text = "Edit App IDs";
            this.tsmiModsChangeAppId.ToolTipText = "Change the CDLC App ID to\r\nany other DLC that you own.\r\n\r\nHINT:\r\nYou can also typ" +
                "e in any valid\r\nApp ID if it is not on the list.";
            this.tsmiModsChangeAppId.Click += new System.EventHandler(this.tsmiModsChangeAppId_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(200, 6);
            // 
            // tsmiModsPitchShifter
            // 
            this.tsmiModsPitchShifter.AssociatedEnumValue = null;
            this.tsmiModsPitchShifter.Image = global::CustomsForgeSongManager.Properties.Resources.shift;
            this.tsmiModsPitchShifter.Name = "tsmiModsPitchShifter";
            this.tsmiModsPitchShifter.RadioButtonGroupName = "PitchShifter";
            this.tsmiModsPitchShifter.Size = new System.Drawing.Size(203, 22);
            this.tsmiModsPitchShifter.Text = "Pitch Shifter";
            this.tsmiModsPitchShifter.ToolTipText = resources.GetString("tsmiModsPitchShifter.ToolTipText");
            this.tsmiModsPitchShifter.Click += new System.EventHandler(this.tsmiModsPitchShifter_Click);
            // 
            // tsmiModsPitchShiftStandard
            // 
            this.tsmiModsPitchShiftStandard.AssociatedEnumValue = null;
            this.tsmiModsPitchShiftStandard.CheckOnClick = true;
            this.tsmiModsPitchShiftStandard.Name = "tsmiModsPitchShiftStandard";
            this.tsmiModsPitchShiftStandard.RadioButtonGroupName = null;
            this.tsmiModsPitchShiftStandard.Size = new System.Drawing.Size(203, 22);
            this.tsmiModsPitchShiftStandard.Text = "Force E Standard Tuning";
            this.tsmiModsPitchShiftStandard.ToolTipText = "If checked, forces E Standard Tuning even\r\nif arrangement is currently a Drop tun" +
                "ing.";
            this.tsmiModsPitchShiftStandard.CheckStateChanged += new System.EventHandler(this.ModsPitchShift_CheckStateChanged);
            // 
            // tsmiModsPreserveStats
            // 
            this.tsmiModsPreserveStats.AssociatedEnumValue = null;
            this.tsmiModsPreserveStats.CheckOnClick = true;
            this.tsmiModsPreserveStats.Name = "tsmiModsPreserveStats";
            this.tsmiModsPreserveStats.RadioButtonGroupName = null;
            this.tsmiModsPreserveStats.Size = new System.Drawing.Size(203, 22);
            this.tsmiModsPreserveStats.Text = "Preserve Stats";
            this.tsmiModsPreserveStats.ToolTipText = resources.GetString("tsmiModsPreserveStats.ToolTipText");
            this.tsmiModsPreserveStats.CheckStateChanged += new System.EventHandler(this.ModsPitchShift_CheckStateChanged);
            this.tsmiModsPreserveStats.Click += new System.EventHandler(this.tsmiModPreserveStats_Click);
            // 
            // tsmiModsPitchShiftOverwrite
            // 
            this.tsmiModsPitchShiftOverwrite.AssociatedEnumValue = null;
            this.tsmiModsPitchShiftOverwrite.CheckOnClick = true;
            this.tsmiModsPitchShiftOverwrite.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiModsPitchShiftOverwrite.ForeColor = System.Drawing.Color.Red;
            this.tsmiModsPitchShiftOverwrite.Name = "tsmiModsPitchShiftOverwrite";
            this.tsmiModsPitchShiftOverwrite.RadioButtonGroupName = "PitchShift";
            this.tsmiModsPitchShiftOverwrite.Size = new System.Drawing.Size(203, 22);
            this.tsmiModsPitchShiftOverwrite.Text = "Overwrite File";
            this.tsmiModsPitchShiftOverwrite.ToolTipText = "If checked, overwrite existing CDLC\r\nwith pitch shifted arrangements and\r\nreduces" +
                " the risk of in-game hangs.";
            this.tsmiModsPitchShiftOverwrite.CheckStateChanged += new System.EventHandler(this.ModsPitchShift_CheckStateChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(200, 6);
            // 
            // tsmiTagStyle
            // 
            this.tsmiTagStyle.AssociatedEnumValue = null;
            this.tsmiTagStyle.Name = "tsmiTagStyle";
            this.tsmiTagStyle.RadioButtonGroupName = null;
            this.tsmiTagStyle.Size = new System.Drawing.Size(203, 22);
            this.tsmiTagStyle.Text = "Tag Style";
            // 
            // tsmiModsTagArtwork
            // 
            this.tsmiModsTagArtwork.AssociatedEnumValue = null;
            this.tsmiModsTagArtwork.Image = global::CustomsForgeSongManager.Properties.Resources.tag;
            this.tsmiModsTagArtwork.Name = "tsmiModsTagArtwork";
            this.tsmiModsTagArtwork.RadioButtonGroupName = null;
            this.tsmiModsTagArtwork.Size = new System.Drawing.Size(203, 22);
            this.tsmiModsTagArtwork.Text = "Tag Album Artwork";
            this.tsmiModsTagArtwork.Click += new System.EventHandler(this.tsmiModsTagArtwork_Click);
            // 
            // tsmiModsUntagArtwork
            // 
            this.tsmiModsUntagArtwork.AssociatedEnumValue = null;
            this.tsmiModsUntagArtwork.Image = ((System.Drawing.Image)(resources.GetObject("tsmiModsUntagArtwork.Image")));
            this.tsmiModsUntagArtwork.Name = "tsmiModsUntagArtwork";
            this.tsmiModsUntagArtwork.RadioButtonGroupName = null;
            this.tsmiModsUntagArtwork.Size = new System.Drawing.Size(203, 22);
            this.tsmiModsUntagArtwork.Text = "Un-Tag";
            this.tsmiModsUntagArtwork.Click += new System.EventHandler(this.tsmiModsUntagArtwork_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(200, 6);
            // 
            // tsmiModsTheMover
            // 
            this.tsmiModsTheMover.AssociatedEnumValue = null;
            this.tsmiModsTheMover.CheckOnClick = true;
            this.tsmiModsTheMover.Name = "tsmiModsTheMover";
            this.tsmiModsTheMover.RadioButtonGroupName = null;
            this.tsmiModsTheMover.Size = new System.Drawing.Size(203, 22);
            this.tsmiModsTheMover.Text = "\'The\' mover";
            this.tsmiModsTheMover.ToolTipText = "\'The\' Mover e.g., The Beatles -> Beatles, The";
            this.tsmiModsTheMover.CheckStateChanged += new System.EventHandler(this.tsmiModsTheMover_CheckStateChanged);
            // 
            // tsmiModsMyCDLC
            // 
            this.tsmiModsMyCDLC.AssociatedEnumValue = null;
            this.tsmiModsMyCDLC.Name = "tsmiModsMyCDLC";
            this.tsmiModsMyCDLC.RadioButtonGroupName = null;
            this.tsmiModsMyCDLC.Size = new System.Drawing.Size(203, 22);
            this.tsmiModsMyCDLC.Text = "Show My CDLC";
            this.tsmiModsMyCDLC.CheckStateChanged += new System.EventHandler(this.tsmiModsMyCDLC_CheckStateChanged);
            // 
            // tsmiFiles
            // 
            this.tsmiFiles.AssociatedEnumValue = null;
            this.tsmiFiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilesCheckODLC,
            this.toolStripSeparator1,
            this.tsmiFilesCleanDlc,
            this.tsmiFilesRestore,
            this.tsmiFilesArchive,
            this.toolStripSeparator6,
            this.tsmiFilesOrganize,
            this.tsmiFilesUnorganize,
            this.tsmiFilesIncludeODLC});
            this.tsmiFiles.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFiles.Image")));
            this.tsmiFiles.Name = "tsmiFiles";
            this.tsmiFiles.RadioButtonGroupName = null;
            this.tsmiFiles.Size = new System.Drawing.Size(56, 20);
            this.tsmiFiles.Text = "Files";
            // 
            // tsmiFilesCheckODLC
            // 
            this.tsmiFilesCheckODLC.AssociatedEnumValue = null;
            this.tsmiFilesCheckODLC.Name = "tsmiFilesCheckODLC";
            this.tsmiFilesCheckODLC.RadioButtonGroupName = null;
            this.tsmiFilesCheckODLC.Size = new System.Drawing.Size(238, 22);
            this.tsmiFilesCheckODLC.Text = "Check CDLC/ODLC";
            this.tsmiFilesCheckODLC.ToolTipText = "Determines if any of your CDLC\r\nhave been replaced by ODLC.";
            this.tsmiFilesCheckODLC.Click += new System.EventHandler(this.tsmiFilesCheckODLC_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // tsmiFilesCleanDlc
            // 
            this.tsmiFilesCleanDlc.AssociatedEnumValue = null;
            this.tsmiFilesCleanDlc.Image = global::CustomsForgeSongManager.Properties.Resources.broom;
            this.tsmiFilesCleanDlc.Name = "tsmiFilesCleanDlc";
            this.tsmiFilesCleanDlc.RadioButtonGroupName = null;
            this.tsmiFilesCleanDlc.Size = new System.Drawing.Size(238, 22);
            this.tsmiFilesCleanDlc.Text = "Clean \'dlc\' Folder";
            this.tsmiFilesCleanDlc.ToolTipText = "Remove any [.org] [.max] or [.cor]\r\nbackup files from the \'dlc\' folder and\r\nsubfo" +
                "lders.";
            this.tsmiFilesCleanDlc.Click += new System.EventHandler(this.tsmiFilesCleanDlc_Click);
            // 
            // tsmiFilesRestore
            // 
            this.tsmiFilesRestore.AssociatedEnumValue = null;
            this.tsmiFilesRestore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilesRestoreBak,
            this.tsmiFilesRestoreOrg,
            this.tsmiFilesRestoreMax,
            this.tsmiFilesRestoreCor});
            this.tsmiFilesRestore.Image = global::CustomsForgeSongManager.Properties.Resources.restorewindow;
            this.tsmiFilesRestore.Name = "tsmiFilesRestore";
            this.tsmiFilesRestore.RadioButtonGroupName = null;
            this.tsmiFilesRestore.Size = new System.Drawing.Size(238, 22);
            this.tsmiFilesRestore.Text = "Restore";
            // 
            // tsmiFilesRestoreBak
            // 
            this.tsmiFilesRestoreBak.AssociatedEnumValue = null;
            this.tsmiFilesRestoreBak.Name = "tsmiFilesRestoreBak";
            this.tsmiFilesRestoreBak.RadioButtonGroupName = null;
            this.tsmiFilesRestoreBak.Size = new System.Drawing.Size(163, 22);
            this.tsmiFilesRestoreBak.Text = "File Type (.bak)";
            this.tsmiFilesRestoreBak.Click += new System.EventHandler(this.tsmiFilesRestoreBak_Click);
            // 
            // tsmiFilesRestoreOrg
            // 
            this.tsmiFilesRestoreOrg.AssociatedEnumValue = null;
            this.tsmiFilesRestoreOrg.Name = "tsmiFilesRestoreOrg";
            this.tsmiFilesRestoreOrg.RadioButtonGroupName = null;
            this.tsmiFilesRestoreOrg.Size = new System.Drawing.Size(163, 22);
            this.tsmiFilesRestoreOrg.Text = "File Type (.org)";
            this.tsmiFilesRestoreOrg.Click += new System.EventHandler(this.tsmiFilesRestoreOrg_Click);
            // 
            // tsmiFilesRestoreMax
            // 
            this.tsmiFilesRestoreMax.AssociatedEnumValue = null;
            this.tsmiFilesRestoreMax.Name = "tsmiFilesRestoreMax";
            this.tsmiFilesRestoreMax.RadioButtonGroupName = null;
            this.tsmiFilesRestoreMax.Size = new System.Drawing.Size(163, 22);
            this.tsmiFilesRestoreMax.Text = "File Type (.max)";
            this.tsmiFilesRestoreMax.Click += new System.EventHandler(this.tsmiFilesRestoreMax_Click);
            // 
            // tsmiFilesRestoreCor
            // 
            this.tsmiFilesRestoreCor.AssociatedEnumValue = null;
            this.tsmiFilesRestoreCor.Name = "tsmiFilesRestoreCor";
            this.tsmiFilesRestoreCor.RadioButtonGroupName = null;
            this.tsmiFilesRestoreCor.Size = new System.Drawing.Size(163, 22);
            this.tsmiFilesRestoreCor.Text = "File Type (.cor)";
            this.tsmiFilesRestoreCor.Click += new System.EventHandler(this.tsmiFilesRestoreCor_Click);
            // 
            // tsmiFilesArchive
            // 
            this.tsmiFilesArchive.AssociatedEnumValue = null;
            this.tsmiFilesArchive.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilesArcBak,
            this.tsmiFilesArcOrg,
            this.tsmiFilesArcMax,
            this.tsmiFilesArcCor,
            this.tsmiFilesArcDeleteAfter});
            this.tsmiFilesArchive.Image = global::CustomsForgeSongManager.Properties.Resources.zip;
            this.tsmiFilesArchive.Name = "tsmiFilesArchive";
            this.tsmiFilesArchive.RadioButtonGroupName = null;
            this.tsmiFilesArchive.Size = new System.Drawing.Size(238, 22);
            this.tsmiFilesArchive.Text = "Archive";
            // 
            // tsmiFilesArcBak
            // 
            this.tsmiFilesArcBak.AssociatedEnumValue = null;
            this.tsmiFilesArcBak.Name = "tsmiFilesArcBak";
            this.tsmiFilesArcBak.RadioButtonGroupName = null;
            this.tsmiFilesArcBak.Size = new System.Drawing.Size(210, 22);
            this.tsmiFilesArcBak.Text = "File Type (.bak)";
            this.tsmiFilesArcBak.Click += new System.EventHandler(this.tsmiFilesArcBak_Click);
            // 
            // tsmiFilesArcOrg
            // 
            this.tsmiFilesArcOrg.AssociatedEnumValue = null;
            this.tsmiFilesArcOrg.Name = "tsmiFilesArcOrg";
            this.tsmiFilesArcOrg.RadioButtonGroupName = null;
            this.tsmiFilesArcOrg.Size = new System.Drawing.Size(210, 22);
            this.tsmiFilesArcOrg.Text = "File Type (.org)";
            this.tsmiFilesArcOrg.Click += new System.EventHandler(this.tsmiFilesArcOrg_Click);
            // 
            // tsmiFilesArcMax
            // 
            this.tsmiFilesArcMax.AssociatedEnumValue = null;
            this.tsmiFilesArcMax.Name = "tsmiFilesArcMax";
            this.tsmiFilesArcMax.RadioButtonGroupName = null;
            this.tsmiFilesArcMax.Size = new System.Drawing.Size(210, 22);
            this.tsmiFilesArcMax.Text = "File Type (.max)";
            this.tsmiFilesArcMax.Click += new System.EventHandler(this.tsmiFilesArcMax_Click);
            // 
            // tsmiFilesArcCor
            // 
            this.tsmiFilesArcCor.AssociatedEnumValue = null;
            this.tsmiFilesArcCor.Name = "tsmiFilesArcCor";
            this.tsmiFilesArcCor.RadioButtonGroupName = null;
            this.tsmiFilesArcCor.Size = new System.Drawing.Size(210, 22);
            this.tsmiFilesArcCor.Text = "File Type (.cor)";
            this.tsmiFilesArcCor.Click += new System.EventHandler(this.tsmiFilesArcCor_Click);
            // 
            // tsmiFilesArcDeleteAfter
            // 
            this.tsmiFilesArcDeleteAfter.AssociatedEnumValue = null;
            this.tsmiFilesArcDeleteAfter.CheckOnClick = true;
            this.tsmiFilesArcDeleteAfter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiFilesArcDeleteAfter.ForeColor = System.Drawing.Color.Red;
            this.tsmiFilesArcDeleteAfter.Name = "tsmiFilesArcDeleteAfter";
            this.tsmiFilesArcDeleteAfter.RadioButtonGroupName = null;
            this.tsmiFilesArcDeleteAfter.Size = new System.Drawing.Size(210, 22);
            this.tsmiFilesArcDeleteAfter.Text = "Delete Files After Arhiving";
            this.tsmiFilesArcDeleteAfter.CheckedChanged += new System.EventHandler(this.tsmiFilesArcDelete_CheckedChanged);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(235, 6);
            // 
            // tsmiFilesOrganize
            // 
            this.tsmiFilesOrganize.AssociatedEnumValue = null;
            this.tsmiFilesOrganize.Name = "tsmiFilesOrganize";
            this.tsmiFilesOrganize.RadioButtonGroupName = null;
            this.tsmiFilesOrganize.Size = new System.Drawing.Size(238, 22);
            this.tsmiFilesOrganize.Text = "Organize ArtistName Subfolders";
            this.tsmiFilesOrganize.ToolTipText = resources.GetString("tsmiFilesOrganize.ToolTipText");
            this.tsmiFilesOrganize.Click += new System.EventHandler(this.tsmiFilesOrganize_Click);
            // 
            // tsmiFilesUnorganize
            // 
            this.tsmiFilesUnorganize.AssociatedEnumValue = null;
            this.tsmiFilesUnorganize.Name = "tsmiFilesUnorganize";
            this.tsmiFilesUnorganize.RadioButtonGroupName = null;
            this.tsmiFilesUnorganize.Size = new System.Drawing.Size(238, 22);
            this.tsmiFilesUnorganize.Text = "Restore CDLC to the \'dlc\' Folder";
            this.tsmiFilesUnorganize.ToolTipText = resources.GetString("tsmiFilesUnorganize.ToolTipText");
            this.tsmiFilesUnorganize.Click += new System.EventHandler(this.tsmiFilesUnorganize_Click);
            // 
            // tsmiFilesIncludeODLC
            // 
            this.tsmiFilesIncludeODLC.AssociatedEnumValue = null;
            this.tsmiFilesIncludeODLC.CheckOnClick = true;
            this.tsmiFilesIncludeODLC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiFilesIncludeODLC.ForeColor = System.Drawing.Color.Red;
            this.tsmiFilesIncludeODLC.Name = "tsmiFilesIncludeODLC";
            this.tsmiFilesIncludeODLC.RadioButtonGroupName = null;
            this.tsmiFilesIncludeODLC.Size = new System.Drawing.Size(238, 22);
            this.tsmiFilesIncludeODLC.Text = "Include ODLC Files";
            this.tsmiFilesIncludeODLC.ToolTipText = "If checked, ODLC files will be organized\r\ntoo, even though they are not selectabl" +
                "e.";
            this.tsmiFilesIncludeODLC.Click += new System.EventHandler(this.tsmiFilesIncludeODLC_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.AssociatedEnumValue = null;
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelpGeneral,
            this.toolStripSeparator3,
            this.tsmiHelpRepairs,
            this.tsmiHelpErrorLog});
            this.tsmiHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsmiHelp.Image")));
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.RadioButtonGroupName = null;
            this.tsmiHelp.Size = new System.Drawing.Size(56, 20);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiHelpGeneral
            // 
            this.tsmiHelpGeneral.AssociatedEnumValue = null;
            this.tsmiHelpGeneral.Image = global::CustomsForgeSongManager.Properties.Resources.info;
            this.tsmiHelpGeneral.Name = "tsmiHelpGeneral";
            this.tsmiHelpGeneral.RadioButtonGroupName = null;
            this.tsmiHelpGeneral.Size = new System.Drawing.Size(154, 22);
            this.tsmiHelpGeneral.Text = "General Help";
            this.tsmiHelpGeneral.Click += new System.EventHandler(this.tsmiHelpGeneral_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(151, 6);
            // 
            // tsmiHelpRepairs
            // 
            this.tsmiHelpRepairs.AssociatedEnumValue = null;
            this.tsmiHelpRepairs.Image = global::CustomsForgeSongManager.Properties.Resources.maintenance;
            this.tsmiHelpRepairs.Name = "tsmiHelpRepairs";
            this.tsmiHelpRepairs.RadioButtonGroupName = null;
            this.tsmiHelpRepairs.Size = new System.Drawing.Size(154, 22);
            this.tsmiHelpRepairs.Text = "Repairs Help";
            this.tsmiHelpRepairs.Click += new System.EventHandler(this.tsmiHelpRepairs_Click);
            // 
            // tsmiHelpErrorLog
            // 
            this.tsmiHelpErrorLog.AssociatedEnumValue = null;
            this.tsmiHelpErrorLog.Image = global::CustomsForgeSongManager.Properties.Resources.notes;
            this.tsmiHelpErrorLog.Name = "tsmiHelpErrorLog";
            this.tsmiHelpErrorLog.RadioButtonGroupName = null;
            this.tsmiHelpErrorLog.Size = new System.Drawing.Size(154, 22);
            this.tsmiHelpErrorLog.Text = "View Error Log";
            this.tsmiHelpErrorLog.Click += new System.EventHandler(this.tsmiHelpErrorLog_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // SongManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gb_Main_Grid);
            this.Controls.Add(this.gb_Main_Search);
            this.Controls.Add(this.menuStrip);
            this.Name = "SongManager";
            this.Size = new System.Drawing.Size(899, 490);
            this.Resize += new System.EventHandler(this.SongManager_Resize);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.gb_Main_Search.ResumeLayout(false);
            this.cmsSongManager.ResumeLayout(false);
            this.gb_Main_Grid.ResumeLayout(false);
            this.gb_Main_Grid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongsMaster)).EndInit();
            this.cmsSongManagerColumns.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.LinkLabel lnkClearSearch;
        private System.Windows.Forms.Label lbl_Search;
        private CueTextBox cueSearch;
        private System.Windows.Forms.GroupBox gb_Main_Search;
        private System.Windows.Forms.SaveFileDialog sfdSongListToCSV;
        private CustomControls.ToolStripEnhancedMenuItem cmsShowSongInfo;
        private CustomControls.ToolStripEnhancedMenuItem cmsOpenSongPage;
        private CustomControls.ToolStripEnhancedMenuItem cmsCheckForUpdate;
        private CustomControls.ToolStripEnhancedMenuItem cmsOpenSongLocation;
        private CustomControls.ToolStripEnhancedMenuItem cmsEdit;
        private CustomControls.ToolStripEnhancedMenuItem cmsGetCharterName;
        private CustomControls.ToolStripEnhancedMenuItem cmsDelete;
        private CustomControls.ToolStripEnhancedMenuItem cmsBackup;
        private System.Windows.Forms.ContextMenuStrip cmsSongManager;
        private RADataGridView dgvSongsMaster;
        private System.Windows.Forms.LinkLabel lnkLblSelectAll;
        private System.Windows.Forms.GroupBox gb_Main_Grid;
        private System.Windows.Forms.ContextMenuStrip cmsSongManagerColumns;
        private CustomControls.ToolStripEnhancedMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private CustomControls.ToolStripEnhancedMenuItem cmsTaggerPreview;
        private CustomControls.ToolStripEnhancedMenuItem tsmiModsChangeAppId;
        private System.Windows.Forms.LinkLabel lnklblToggle;
        private System.Windows.Forms.CheckBox chkSubFolders;
        private CustomControls.ToolStripEnhancedMenuItem tsmiModsPitchShifter;
        private System.Windows.Forms.MenuStrip menuStrip;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRescan;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRescanQuick;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRescanFull;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRepairs;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRepairsMastery;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRepairsMaxFive;
        private CustomControls.ToolStripEnhancedMenuItem tsmiMods;
        private CustomControls.ToolStripEnhancedMenuItem tsmiModsTagArtwork;
        private CustomControls.ToolStripEnhancedMenuItem tsmiModsUntagArtwork;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFiles;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesRestoreOrg;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesRestoreMax;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesRestoreCor;
        private CustomControls.ToolStripEnhancedMenuItem tsmiHelp;
        private CustomControls.ToolStripEnhancedMenuItem tsmiHelpGeneral;
        private CustomControls.ToolStripEnhancedMenuItem tsmiHelpErrorLog;
        private CustomControls.ToolStripEnhancedMenuItem tsmiModsTheMover;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private CustomControls.ToolStripEnhancedMenuItem tsmiModsMyCDLC;
        private CustomControls.ToolStripEnhancedMenuItem tsmiDuplicates;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesRestore;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRepairsPreserveStats;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRepairsUsingOrg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRepairsMultitone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRemoveNDD;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRemoveBass;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRemoveGuitar;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRemoveBonus;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRemoveMetronome;
        private CustomControls.ToolStripEnhancedMenuItem tsmiIgnoreStopLimit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private CustomControls.ToolStripEnhancedMenuItem tsmiTagStyle;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRemoveSections;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private CustomControls.ToolStripEnhancedMenuItem tsmiSkipRemastered;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private CustomControls.ToolStripEnhancedMenuItem tsmiOverwriteDD;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRepairsRun;
        private CustomControls.ToolStripEnhancedMenuItem tsmiHelpRepairs;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesArchive;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesArcOrg;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesArcMax;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesArcCor;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesArcDeleteAfter;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesCleanDlc;
        private CustomControls.ToolStripEnhancedMenuItem tsmiRepairsAddDD;
        private CustomControls.ToolStripEnhancedMenuItem tsmiDuplicatesSoon;
        private CustomControls.ToolStripEnhancedMenuItem tsmiAddDDRemoveSustain;
        private CustomControls.ToolStripSpringTextBox tsmiAddDDCfgPath;
        private CustomControls.ToolStripSpringTextBox tsmiAddDDRampUpPath;
        private CustomControls.ToolStripEnhancedMenuItem tsmiAddDDSettings;
        private CustomControls.ToolStripNumericUpDown tsmiAddDDNumericUpDown;
        private CustomControls.ToolStripEnhancedMenuItem tsmiProcessDLFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesRestoreBak;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesArcBak;
        private CustomControls.ToolStripEnhancedMenuItem tsmiModsPitchShiftOverwrite;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesCheckODLC;
        private System.Windows.Forms.ToolStripMenuItem cmsEnableDisable;
        private System.Windows.Forms.ToolStripMenuItem cmsPlaySelected;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesOrganize;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesUnorganize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private CustomControls.ToolStripEnhancedMenuItem tsmiFilesIncludeODLC;
        private CustomControls.ToolStripEnhancedMenuItem cmsGetAnalyzerData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private SubclassedDataGridView dgvSongsDetail;
        private DataGridViewTextBoxColumn colDetailKey;
        private DataGridViewTextBoxColumn colDetailPID;
        private DataGridViewTextBoxColumn colDetailArrangement;
        private DataGridViewTextBoxColumn colDetailTuning;
        private DataGridViewTextBoxColumn colDetailSections;
        private DataGridViewTextBoxColumn colDetailDMax;
        private DataGridViewTextBoxColumn colDetailToneBase;
        private DataGridViewTextBoxColumn colDetailChordCount;
        private DataGridViewTextBoxColumn colDetailNoteCount;
        private DataGridViewTextBoxColumn colDetailOctaveCount;
        private DataGridViewTextBoxColumn colDetailChords;
        private CustomControls.ToolStripEnhancedMenuItem tsmiModsPitchShiftStandard;
        private DataGridViewImageColumn colShowDetail;
        private DataGridViewAutoFilterTextBoxColumn colKey;
        private DataGridViewCheckBoxColumn colSelect;
        private DataGridViewImageColumn colBass;
        private DataGridViewImageColumn colLead;
        private DataGridViewImageColumn colRhythm;
        private DataGridViewImageColumn colVocals;
        private DataGridViewAutoFilterTextBoxColumn colRepairStatus;
        private DataGridViewAutoFilterTextBoxColumn colEnabled;
        private DataGridViewAutoFilterTextBoxColumn colArtist;
        private DataGridViewAutoFilterTextBoxColumn colTitle;
        private DataGridViewAutoFilterTextBoxColumn colAlbum;
        private DataGridViewAutoFilterTextBoxColumn colSongYear;
        private DataGridViewAutoFilterTextBoxColumn colArrangements;
        private DataGridViewAutoFilterTextBoxColumn colTuning;
        private DataGridViewAutoFilterTextBoxColumn colDD;
        private DataGridViewAutoFilterTextBoxColumn colSongLength;
        private DataGridViewAutoFilterTextBoxColumn colAvgTempo;
        private DataGridViewAutoFilterTextBoxColumn colAppID;
        private DataGridViewAutoFilterTextBoxColumn colFileName;
        private DataGridViewAutoFilterTextBoxColumn colFilePath;
        private DataGridViewAutoFilterTextBoxColumn colFileDate;
        private DataGridViewAutoFilterTextBoxColumn colFileSize;
        private DataGridViewAutoFilterTextBoxColumn colStatus;
        private DataGridViewAutoFilterTextBoxColumn colCharter;
        private DataGridViewAutoFilterTextBoxColumn colUpdated;
        private DataGridViewAutoFilterTextBoxColumn colVersion;
        private DataGridViewAutoFilterTextBoxColumn colToolkitVersion;
        private DataGridViewAutoFilterTextBoxColumn colTagged;
        private DataGridViewAutoFilterTextBoxColumn colIgnitionID;
        private DataGridViewAutoFilterTextBoxColumn colIgnitionUpdated;
        private DataGridViewAutoFilterTextBoxColumn colIgnitionVersion;
        private DataGridViewAutoFilterTextBoxColumn colIgnitionAuthor;
        private DataGridViewAutoFilterTextBoxColumn colArtistTitleAlbum;
        private DataGridViewAutoFilterTextBoxColumn colArtistSort;
        private DataGridViewAutoFilterTextBoxColumn colTitleSort;
        private DataGridViewAutoFilterTextBoxColumn colAlbumSort;
        private DataGridViewTextBoxColumn colNoteCount;
        private DataGridViewTextBoxColumn colChordCount;
        private DataGridViewTextBoxColumn colOctaveCount;
        private DataGridViewTextBoxColumn colVibratoCount;
        private DataGridViewTextBoxColumn colHammerOnCount;
        private DataGridViewTextBoxColumn colBendCount;
        private DataGridViewTextBoxColumn colPullOffCount;
        private DataGridViewTextBoxColumn colHarmonicCount;
        private DataGridViewTextBoxColumn colFretHandMuteCount;
        private DataGridViewTextBoxColumn colPalmMuteCount;
        private DataGridViewTextBoxColumn colPluckCount;
        private DataGridViewTextBoxColumn colSlapCount;
        private DataGridViewTextBoxColumn colPopCount;
        private DataGridViewTextBoxColumn colSlideCount;
        private DataGridViewTextBoxColumn colSustainCount;
        private DataGridViewTextBoxColumn colTremoloCount;
        private DataGridViewTextBoxColumn colPinchHarmonicCount;
        private DataGridViewTextBoxColumn colUnpitchedSlideCount;
        private DataGridViewTextBoxColumn colTotalTapCount;
        private DataGridViewTextBoxColumn colHighestFretUsed;
        private CustomControls.ToolStripEnhancedMenuItem tsmiModsPreserveStats;
        private CustomControls.ToolStripEnhancedMenuItem cmsActions;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripSeparator toolStripSeparator2;

    }
}
