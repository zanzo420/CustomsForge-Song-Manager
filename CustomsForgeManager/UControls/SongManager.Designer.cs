﻿using CustomsForgeManager.CustomsForgeManagerLib.CustomControls;

namespace CustomsForgeManager.UControls
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lnkClearSearch = new System.Windows.Forms.LinkLabel();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gb_Main_Search = new System.Windows.Forms.GroupBox();
            this.panelSongListButtons = new System.Windows.Forms.Panel();
            this.btnBackupSelectedDLCs = new System.Windows.Forms.Button();
            this.btnCheckAllForUpdates = new System.Windows.Forms.Button();
            this.radioBtn_ExportToHTML = new System.Windows.Forms.RadioButton();
            this.radioBtn_ExportToCSV = new System.Windows.Forms.RadioButton();
            this.btnExportSongList = new System.Windows.Forms.Button();
            this.lbl_ExportTo = new System.Windows.Forms.Label();
            this.radioBtn_ExportToBBCode = new System.Windows.Forms.RadioButton();
            this.btnDisableEnableSongs = new System.Windows.Forms.Button();
            this.btnRescan = new System.Windows.Forms.Button();
            this.gb_Main_Actions = new System.Windows.Forms.GroupBox();
            this.sfdSongListToCSV = new System.Windows.Forms.SaveFileDialog();
            this.cmsGetAuthorName = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSongManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsShowDLCInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOpenDLCPage = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCheckForUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOpenDLCLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditDLC = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteSong = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBackupDLC = new System.Windows.Forms.ToolStripMenuItem();
            this.lnkLblSelectAll = new System.Windows.Forms.LinkLabel();
            this.gb_Main_Grid = new System.Windows.Forms.GroupBox();
            this.dgvSongs = new CustomsForgeManager.CustomsForgeManagerLib.CustomControls.RADataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cBass = new System.Windows.Forms.DataGridViewImageColumn();
            this.cLead = new System.Windows.Forms.DataGridViewImageColumn();
            this.cRhythm = new System.Windows.Forms.DataGridViewImageColumn();
            this.cVocals = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmsSongManagerColumns = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSearch.SuspendLayout();
            this.gb_Main_Search.SuspendLayout();
            this.panelSongListButtons.SuspendLayout();
            this.gb_Main_Actions.SuspendLayout();
            this.cmsSongManager.SuspendLayout();
            this.gb_Main_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.cmsSongManagerColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.Controls.Add(this.lnkClearSearch);
            this.panelSearch.Controls.Add(this.lbl_Search);
            this.panelSearch.Controls.Add(this.tbSearch);
            this.panelSearch.Location = new System.Drawing.Point(6, 19);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(970, 33);
            this.panelSearch.TabIndex = 5;
            // 
            // lnkClearSearch
            // 
            this.lnkClearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClearSearch.AutoSize = true;
            this.lnkClearSearch.ForeColor = System.Drawing.Color.DimGray;
            this.lnkClearSearch.LinkColor = System.Drawing.Color.Black;
            this.lnkClearSearch.Location = new System.Drawing.Point(891, 9);
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
            this.lbl_Search.Size = new System.Drawing.Size(59, 13);
            this.lbl_Search.TabIndex = 2;
            this.lbl_Search.Text = "Search for:";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(68, 6);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(817, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // gb_Main_Search
            // 
            this.gb_Main_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Main_Search.Controls.Add(this.panelSearch);
            this.gb_Main_Search.Location = new System.Drawing.Point(3, 3);
            this.gb_Main_Search.Name = "gb_Main_Search";
            this.gb_Main_Search.Size = new System.Drawing.Size(982, 58);
            this.gb_Main_Search.TabIndex = 10;
            this.gb_Main_Search.TabStop = false;
            this.gb_Main_Search.Text = "Search:";
            // 
            // panelSongListButtons
            // 
            this.panelSongListButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSongListButtons.Controls.Add(this.btnBackupSelectedDLCs);
            this.panelSongListButtons.Controls.Add(this.btnCheckAllForUpdates);
            this.panelSongListButtons.Controls.Add(this.radioBtn_ExportToHTML);
            this.panelSongListButtons.Controls.Add(this.radioBtn_ExportToCSV);
            this.panelSongListButtons.Controls.Add(this.btnExportSongList);
            this.panelSongListButtons.Controls.Add(this.lbl_ExportTo);
            this.panelSongListButtons.Controls.Add(this.radioBtn_ExportToBBCode);
            this.panelSongListButtons.Controls.Add(this.btnDisableEnableSongs);
            this.panelSongListButtons.Controls.Add(this.btnRescan);
            this.panelSongListButtons.Location = new System.Drawing.Point(6, 13);
            this.panelSongListButtons.Name = "panelSongListButtons";
            this.panelSongListButtons.Size = new System.Drawing.Size(970, 41);
            this.panelSongListButtons.TabIndex = 3;
            // 
            // btnBackupSelectedDLCs
            // 
            this.btnBackupSelectedDLCs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackupSelectedDLCs.Image = global::CustomsForgeManager.Properties.Resources.backup;
            this.btnBackupSelectedDLCs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackupSelectedDLCs.Location = new System.Drawing.Point(302, 6);
            this.btnBackupSelectedDLCs.Name = "btnBackupSelectedDLCs";
            this.btnBackupSelectedDLCs.Size = new System.Drawing.Size(116, 29);
            this.btnBackupSelectedDLCs.TabIndex = 19;
            this.btnBackupSelectedDLCs.Text = "Backup selected";
            this.btnBackupSelectedDLCs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackupSelectedDLCs.UseVisualStyleBackColor = true;
            this.btnBackupSelectedDLCs.Click += new System.EventHandler(this.btnBackupSelectedDLCs_Click);
            // 
            // btnCheckAllForUpdates
            // 
            this.btnCheckAllForUpdates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckAllForUpdates.Image = global::CustomsForgeManager.Properties.Resources.update;
            this.btnCheckAllForUpdates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckAllForUpdates.Location = new System.Drawing.Point(447, 6);
            this.btnCheckAllForUpdates.Name = "btnCheckAllForUpdates";
            this.btnCheckAllForUpdates.Size = new System.Drawing.Size(135, 29);
            this.btnCheckAllForUpdates.TabIndex = 4;
            this.btnCheckAllForUpdates.Text = "Check All for Update";
            this.btnCheckAllForUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckAllForUpdates.UseVisualStyleBackColor = true;
            this.btnCheckAllForUpdates.Visible = false;
            this.btnCheckAllForUpdates.Click += new System.EventHandler(this.btnCheckAllForUpdates_Click);
            // 
            // radioBtn_ExportToHTML
            // 
            this.radioBtn_ExportToHTML.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtn_ExportToHTML.AutoSize = true;
            this.radioBtn_ExportToHTML.Location = new System.Drawing.Point(766, 12);
            this.radioBtn_ExportToHTML.Name = "radioBtn_ExportToHTML";
            this.radioBtn_ExportToHTML.Size = new System.Drawing.Size(55, 17);
            this.radioBtn_ExportToHTML.TabIndex = 18;
            this.radioBtn_ExportToHTML.TabStop = true;
            this.radioBtn_ExportToHTML.Text = "HTML";
            this.radioBtn_ExportToHTML.UseVisualStyleBackColor = true;
            // 
            // radioBtn_ExportToCSV
            // 
            this.radioBtn_ExportToCSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtn_ExportToCSV.AutoSize = true;
            this.radioBtn_ExportToCSV.Location = new System.Drawing.Point(828, 12);
            this.radioBtn_ExportToCSV.Name = "radioBtn_ExportToCSV";
            this.radioBtn_ExportToCSV.Size = new System.Drawing.Size(46, 17);
            this.radioBtn_ExportToCSV.TabIndex = 17;
            this.radioBtn_ExportToCSV.TabStop = true;
            this.radioBtn_ExportToCSV.Text = "CSV";
            this.radioBtn_ExportToCSV.UseVisualStyleBackColor = true;
            // 
            // btnExportSongList
            // 
            this.btnExportSongList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportSongList.Image = global::CustomsForgeManager.Properties.Resources.export;
            this.btnExportSongList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportSongList.Location = new System.Drawing.Point(881, 6);
            this.btnExportSongList.Name = "btnExportSongList";
            this.btnExportSongList.Size = new System.Drawing.Size(68, 29);
            this.btnExportSongList.TabIndex = 12;
            this.btnExportSongList.Text = "Export";
            this.btnExportSongList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportSongList.UseVisualStyleBackColor = true;
            this.btnExportSongList.Click += new System.EventHandler(this.btnExportSongList_Click);
            // 
            // lbl_ExportTo
            // 
            this.lbl_ExportTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ExportTo.AutoSize = true;
            this.lbl_ExportTo.Location = new System.Drawing.Point(628, 14);
            this.lbl_ExportTo.Name = "lbl_ExportTo";
            this.lbl_ExportTo.Size = new System.Drawing.Size(52, 13);
            this.lbl_ExportTo.TabIndex = 16;
            this.lbl_ExportTo.Text = "Export to:";
            // 
            // radioBtn_ExportToBBCode
            // 
            this.radioBtn_ExportToBBCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtn_ExportToBBCode.AutoSize = true;
            this.radioBtn_ExportToBBCode.Location = new System.Drawing.Point(695, 12);
            this.radioBtn_ExportToBBCode.Name = "radioBtn_ExportToBBCode";
            this.radioBtn_ExportToBBCode.Size = new System.Drawing.Size(64, 17);
            this.radioBtn_ExportToBBCode.TabIndex = 15;
            this.radioBtn_ExportToBBCode.TabStop = true;
            this.radioBtn_ExportToBBCode.Text = "BBCode";
            this.radioBtn_ExportToBBCode.UseVisualStyleBackColor = true;
            // 
            // btnDisableEnableSongs
            // 
            this.btnDisableEnableSongs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDisableEnableSongs.Image = global::CustomsForgeManager.Properties.Resources.disable;
            this.btnDisableEnableSongs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisableEnableSongs.Location = new System.Drawing.Point(123, 6);
            this.btnDisableEnableSongs.Name = "btnDisableEnableSongs";
            this.btnDisableEnableSongs.Size = new System.Drawing.Size(150, 29);
            this.btnDisableEnableSongs.TabIndex = 14;
            this.btnDisableEnableSongs.Text = "Enable/Disable selected";
            this.btnDisableEnableSongs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisableEnableSongs.UseVisualStyleBackColor = true;
            this.btnDisableEnableSongs.Click += new System.EventHandler(this.btnDisableEnableSongs_Click);
            // 
            // btnRescan
            // 
            this.btnRescan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRescan.Image = ((System.Drawing.Image)(resources.GetObject("btnRescan.Image")));
            this.btnRescan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRescan.Location = new System.Drawing.Point(20, 6);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(74, 29);
            this.btnRescan.TabIndex = 4;
            this.btnRescan.Text = "Rescan";
            this.btnRescan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRescan.UseVisualStyleBackColor = true;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // gb_Main_Actions
            // 
            this.gb_Main_Actions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Main_Actions.Controls.Add(this.panelSongListButtons);
            this.gb_Main_Actions.Location = new System.Drawing.Point(3, 427);
            this.gb_Main_Actions.Name = "gb_Main_Actions";
            this.gb_Main_Actions.Size = new System.Drawing.Size(982, 60);
            this.gb_Main_Actions.TabIndex = 9;
            this.gb_Main_Actions.TabStop = false;
            this.gb_Main_Actions.Text = "Actions:";
            // 
            // sfdSongListToCSV
            // 
            this.sfdSongListToCSV.FileName = "songList.csv";
            this.sfdSongListToCSV.Filter = "csv files(*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // cmsGetAuthorName
            // 
            this.cmsGetAuthorName.Name = "cmsGetAuthorName";
            this.cmsGetAuthorName.Size = new System.Drawing.Size(176, 22);
            this.cmsGetAuthorName.Text = "Get Author Name";
            this.cmsGetAuthorName.Click += new System.EventHandler(this.cmsGetAuthorName_Click);
            // 
            // cmsSongManager
            // 
            this.cmsSongManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsShowDLCInfo,
            this.cmsOpenDLCPage,
            this.cmsCheckForUpdate,
            this.cmsOpenDLCLocation,
            this.cmsEditDLC,
            this.cmsGetAuthorName,
            this.cmsDeleteSong,
            this.cmsBackupDLC});
            this.cmsSongManager.Name = "contextMenuStrip_MainManager";
            this.cmsSongManager.Size = new System.Drawing.Size(177, 180);
            // 
            // cmsShowDLCInfo
            // 
            this.cmsShowDLCInfo.Image = global::CustomsForgeManager.Properties.Resources.info;
            this.cmsShowDLCInfo.Name = "cmsShowDLCInfo";
            this.cmsShowDLCInfo.Size = new System.Drawing.Size(176, 22);
            this.cmsShowDLCInfo.Text = "Show DLC Info";
            this.cmsShowDLCInfo.Click += new System.EventHandler(this.cmsShowDLCInfo_Click);
            // 
            // cmsOpenDLCPage
            // 
            this.cmsOpenDLCPage.Image = global::CustomsForgeManager.Properties.Resources.internet;
            this.cmsOpenDLCPage.Name = "cmsOpenDLCPage";
            this.cmsOpenDLCPage.Size = new System.Drawing.Size(176, 22);
            this.cmsOpenDLCPage.Text = "Open DLC Page";
            this.cmsOpenDLCPage.Click += new System.EventHandler(this.cmsOpenDLCPage_Click);
            // 
            // cmsCheckForUpdate
            // 
            this.cmsCheckForUpdate.Image = global::CustomsForgeManager.Properties.Resources.update;
            this.cmsCheckForUpdate.Name = "cmsCheckForUpdate";
            this.cmsCheckForUpdate.Size = new System.Drawing.Size(176, 22);
            this.cmsCheckForUpdate.Text = "Check for Update";
            this.cmsCheckForUpdate.Visible = false;
            this.cmsCheckForUpdate.Click += new System.EventHandler(this.cmsCheckForUpdate_Click);
            // 
            // cmsOpenDLCLocation
            // 
            this.cmsOpenDLCLocation.Image = global::CustomsForgeManager.Properties.Resources.folder_open;
            this.cmsOpenDLCLocation.Name = "cmsOpenDLCLocation";
            this.cmsOpenDLCLocation.Size = new System.Drawing.Size(176, 22);
            this.cmsOpenDLCLocation.Text = "Open DLC Location";
            this.cmsOpenDLCLocation.Click += new System.EventHandler(this.cmsOpenDLCLocation_Click);
            // 
            // cmsEditDLC
            // 
            this.cmsEditDLC.Image = global::CustomsForgeManager.Properties.Resources.edit;
            this.cmsEditDLC.Name = "cmsEditDLC";
            this.cmsEditDLC.Size = new System.Drawing.Size(176, 22);
            this.cmsEditDLC.Text = "Edit DLC";
            this.cmsEditDLC.Click += new System.EventHandler(this.cmsEditDLC_Click);
            // 
            // cmsDeleteSong
            // 
            this.cmsDeleteSong.Image = global::CustomsForgeManager.Properties.Resources.delete;
            this.cmsDeleteSong.Name = "cmsDeleteSong";
            this.cmsDeleteSong.Size = new System.Drawing.Size(176, 22);
            this.cmsDeleteSong.Text = "Delete song";
            this.cmsDeleteSong.Click += new System.EventHandler(this.cmsDeleteSong_Click);
            // 
            // cmsBackupDLC
            // 
            this.cmsBackupDLC.Image = global::CustomsForgeManager.Properties.Resources.backup;
            this.cmsBackupDLC.Name = "cmsBackupDLC";
            this.cmsBackupDLC.Size = new System.Drawing.Size(176, 22);
            this.cmsBackupDLC.Text = "Backup DLC";
            this.cmsBackupDLC.Click += new System.EventHandler(this.cmsBackupDLC_Click);
            // 
            // lnkLblSelectAll
            // 
            this.lnkLblSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkLblSelectAll.AutoSize = true;
            this.lnkLblSelectAll.ForeColor = System.Drawing.Color.Black;
            this.lnkLblSelectAll.LinkColor = System.Drawing.Color.Black;
            this.lnkLblSelectAll.Location = new System.Drawing.Point(6, 326);
            this.lnkLblSelectAll.Name = "lnkLblSelectAll";
            this.lnkLblSelectAll.Size = new System.Drawing.Size(112, 13);
            this.lnkLblSelectAll.TabIndex = 2;
            this.lnkLblSelectAll.TabStop = true;
            this.lnkLblSelectAll.Text = "Select All/Deselect All";
            this.lnkLblSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblSelectAll_LinkClicked);
            // 
            // gb_Main_Grid
            // 
            this.gb_Main_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Main_Grid.Controls.Add(this.lnkLblSelectAll);
            this.gb_Main_Grid.Controls.Add(this.dgvSongs);
            this.gb_Main_Grid.Location = new System.Drawing.Point(3, 67);
            this.gb_Main_Grid.Name = "gb_Main_Grid";
            this.gb_Main_Grid.Size = new System.Drawing.Size(982, 354);
            this.gb_Main_Grid.TabIndex = 8;
            this.gb_Main_Grid.TabStop = false;
            this.gb_Main_Grid.Text = "Results Grid:";
            // 
            // dgvSongs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSongs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.cBass,
            this.cLead,
            this.cRhythm,
            this.cVocals});
            this.dgvSongs.Location = new System.Drawing.Point(6, 19);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.Size = new System.Drawing.Size(970, 304);
            this.dgvSongs.TabIndex = 1;
            this.dgvSongs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongs_CellDoubleClick);
            this.dgvSongs.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSongs_CellMouseDown);
            this.dgvSongs.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSongs_ColumnHeaderMouseClick);
            this.dgvSongs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSongs_KeyDown);
            this.dgvSongs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvSongs_KeyUp);
            // 
            // colSelect
            // 
            this.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSelect.FalseValue = "false";
            this.colSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colSelect.HeaderText = "Select";
            this.colSelect.IndeterminateValue = "false";
            this.colSelect.Name = "colSelect";
            this.colSelect.TrueValue = "true";
            this.colSelect.Width = 43;
            // 
            // cBass
            // 
            this.cBass.HeaderText = "B";
            this.cBass.Image = global::CustomsForgeManager.Properties.Resources.Letter_B;
            this.cBass.MinimumWidth = 20;
            this.cBass.Name = "cBass";
            this.cBass.ToolTipText = "Bass";
            this.cBass.Visible = false;
            this.cBass.Width = 21;
            // 
            // cLead
            // 
            this.cLead.HeaderText = "L";
            this.cLead.Image = global::CustomsForgeManager.Properties.Resources.Letter_L;
            this.cLead.MinimumWidth = 20;
            this.cLead.Name = "cLead";
            this.cLead.ToolTipText = "Lead";
            this.cLead.Visible = false;
            this.cLead.Width = 21;
            // 
            // cRhythm
            // 
            this.cRhythm.HeaderText = "R";
            this.cRhythm.Image = global::CustomsForgeManager.Properties.Resources.Letter_R;
            this.cRhythm.MinimumWidth = 20;
            this.cRhythm.Name = "cRhythm";
            this.cRhythm.ToolTipText = "Rhythm";
            this.cRhythm.Visible = false;
            this.cRhythm.Width = 21;
            // 
            // cVocals
            // 
            this.cVocals.HeaderText = "V";
            this.cVocals.Image = global::CustomsForgeManager.Properties.Resources.Letter_V;
            this.cVocals.MinimumWidth = 20;
            this.cVocals.Name = "cVocals";
            this.cVocals.ToolTipText = "Vocals";
            this.cVocals.Visible = false;
            this.cVocals.Width = 21;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "B";
            this.dataGridViewImageColumn1.Image = global::CustomsForgeManager.Properties.Resources.Letter_B;
            this.dataGridViewImageColumn1.MinimumWidth = 20;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Bass";
            this.dataGridViewImageColumn1.Visible = false;
            this.dataGridViewImageColumn1.Width = 21;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "L";
            this.dataGridViewImageColumn2.Image = global::CustomsForgeManager.Properties.Resources.Letter_L;
            this.dataGridViewImageColumn2.MinimumWidth = 20;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ToolTipText = "Lead";
            this.dataGridViewImageColumn2.Visible = false;
            this.dataGridViewImageColumn2.Width = 21;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "R";
            this.dataGridViewImageColumn3.Image = global::CustomsForgeManager.Properties.Resources.Letter_R;
            this.dataGridViewImageColumn3.MinimumWidth = 20;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ToolTipText = "Rhythm";
            this.dataGridViewImageColumn3.Visible = false;
            this.dataGridViewImageColumn3.Width = 21;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "V";
            this.dataGridViewImageColumn4.Image = global::CustomsForgeManager.Properties.Resources.Letter_V;
            this.dataGridViewImageColumn4.MinimumWidth = 20;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ToolTipText = "Vocals";
            this.dataGridViewImageColumn4.Visible = false;
            this.dataGridViewImageColumn4.Width = 21;
            // 
            // cmsSongManagerColumns
            // 
            this.cmsSongManagerColumns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.cmsSongManagerColumns.Name = "cmsSongManagerColumns";
            this.cmsSongManagerColumns.Size = new System.Drawing.Size(153, 48);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Checked = true;
            this.testToolStripMenuItem.CheckOnClick = true;
            this.testToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.testToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // SongManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gb_Main_Search);
            this.Controls.Add(this.gb_Main_Actions);
            this.Controls.Add(this.gb_Main_Grid);
            this.Name = "SongManager";
            this.Size = new System.Drawing.Size(990, 490);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.gb_Main_Search.ResumeLayout(false);
            this.panelSongListButtons.ResumeLayout(false);
            this.panelSongListButtons.PerformLayout();
            this.gb_Main_Actions.ResumeLayout(false);
            this.cmsSongManager.ResumeLayout(false);
            this.gb_Main_Grid.ResumeLayout(false);
            this.gb_Main_Grid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.cmsSongManagerColumns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.LinkLabel lnkClearSearch;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gb_Main_Search;
        private System.Windows.Forms.Panel panelSongListButtons;
        private System.Windows.Forms.Button btnBackupSelectedDLCs;
        private System.Windows.Forms.RadioButton radioBtn_ExportToHTML;
        private System.Windows.Forms.RadioButton radioBtn_ExportToCSV;
        private System.Windows.Forms.Button btnExportSongList;
        private System.Windows.Forms.Label lbl_ExportTo;
        private System.Windows.Forms.RadioButton radioBtn_ExportToBBCode;
        private System.Windows.Forms.Button btnDisableEnableSongs;
        private System.Windows.Forms.Button btnCheckAllForUpdates;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.GroupBox gb_Main_Actions;
        private System.Windows.Forms.SaveFileDialog sfdSongListToCSV;
        private System.Windows.Forms.ToolStripMenuItem cmsShowDLCInfo;
        private System.Windows.Forms.ToolStripMenuItem cmsOpenDLCPage;
        private System.Windows.Forms.ToolStripMenuItem cmsCheckForUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmsOpenDLCLocation;
        private System.Windows.Forms.ToolStripMenuItem cmsEditDLC;
        private System.Windows.Forms.ToolStripMenuItem cmsGetAuthorName;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteSong;
        private System.Windows.Forms.ToolStripMenuItem cmsBackupDLC;
        private System.Windows.Forms.ContextMenuStrip cmsSongManager;
        private RADataGridView dgvSongs;
        private System.Windows.Forms.LinkLabel lnkLblSelectAll;
        private System.Windows.Forms.GroupBox gb_Main_Grid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewImageColumn cBass;
        private System.Windows.Forms.DataGridViewImageColumn cLead;
        private System.Windows.Forms.DataGridViewImageColumn cRhythm;
        private System.Windows.Forms.DataGridViewImageColumn cVocals;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.ContextMenuStrip cmsSongManagerColumns;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;

    }
}
