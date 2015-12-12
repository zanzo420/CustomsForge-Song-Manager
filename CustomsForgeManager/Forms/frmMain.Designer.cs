﻿using System.ComponentModel;
using System.Windows.Forms;

namespace CustomsForgeManager.Forms
{
    // TODO: improve loading efficiency through seperation of code into forms/classes
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.timerAutoUpdate = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_Tray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tstripContainer = new System.Windows.Forms.ToolStripContainer();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpSongManager = new System.Windows.Forms.TabPage();
            this.tpDuplicates = new System.Windows.Forms.TabPage();
            this.tpRenamer = new System.Windows.Forms.TabPage();
            this.tpSetlistManager = new System.Windows.Forms.TabPage();
            this.tpCachePsarcEditor = new System.Windows.Forms.TabPage();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.tsUtilities = new System.Windows.Forms.ToolStrip();
            this.tsBtnLaunchRS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBackup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.bBCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnUpload = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRequest = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.tsAudioPlayer = new System.Windows.Forms.ToolStrip();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tspbAudioPosition = new System.Windows.Forms.ToolStripProgressBar();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.tsLabel_ShowHideLog = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgressBar_Main = new System.Windows.Forms.ToolStripProgressBar();
            this.tsLabel_ClearLog = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabel_MainMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabel_StatusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabel_Cancel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabel_DisabledCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.timerAudioProgress = new System.Windows.Forms.Timer(this.components);
            this.tslblTimer = new System.Windows.Forms.ToolStripLabel();
            this.gbLog.SuspendLayout();
            this.contextMenuStrip_Tray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tstripContainer.ContentPanel.SuspendLayout();
            this.tstripContainer.TopToolStripPanel.SuspendLayout();
            this.tstripContainer.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tsUtilities.SuspendLayout();
            this.tsAudioPlayer.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.tbLog);
            this.gbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLog.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.gbLog.Location = new System.Drawing.Point(0, 0);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(150, 46);
            this.gbLog.TabIndex = 1;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // tbLog
            // 
            this.tbLog.BackColor = System.Drawing.SystemColors.Window;
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLog.Location = new System.Drawing.Point(3, 16);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(144, 27);
            this.tbLog.TabIndex = 0;
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            // 
            // timerAutoUpdate
            // 
            this.timerAutoUpdate.Enabled = true;
            this.timerAutoUpdate.Interval = 600000;
            // 
            // notifyIcon_Main
            // 
            this.notifyIcon_Main.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon_Main.ContextMenuStrip = this.contextMenuStrip_Tray;
            this.notifyIcon_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_Main.Icon")));
            this.notifyIcon_Main.Text = "Notification";
            this.notifyIcon_Main.Visible = true;
            // 
            // contextMenuStrip_Tray
            // 
            this.contextMenuStrip_Tray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip_Tray.Name = "contextMenuStrip_Tray";
            this.contextMenuStrip_Tray.Size = new System.Drawing.Size(112, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::CustomsForgeManager.Properties.Resources.close;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tstripContainer);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.gbLog);
            this.scMain.Panel2Collapsed = true;
            this.scMain.Size = new System.Drawing.Size(1011, 636);
            this.scMain.SplitterDistance = 526;
            this.scMain.TabIndex = 2;
            // 
            // tstripContainer
            // 
            // 
            // tstripContainer.ContentPanel
            // 
            this.tstripContainer.ContentPanel.Controls.Add(this.tcMain);
            this.tstripContainer.ContentPanel.Size = new System.Drawing.Size(1011, 611);
            this.tstripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tstripContainer.LeftToolStripPanelVisible = false;
            this.tstripContainer.Location = new System.Drawing.Point(0, 0);
            this.tstripContainer.Name = "tstripContainer";
            this.tstripContainer.RightToolStripPanelVisible = false;
            this.tstripContainer.Size = new System.Drawing.Size(1011, 636);
            this.tstripContainer.TabIndex = 3;
            this.tstripContainer.Text = "toolStripContainer1";
            // 
            // tstripContainer.TopToolStripPanel
            // 
            this.tstripContainer.TopToolStripPanel.Controls.Add(this.tsUtilities);
            this.tstripContainer.TopToolStripPanel.Controls.Add(this.tsAudioPlayer);
            this.tstripContainer.TopToolStripPanel.MaximumSize = new System.Drawing.Size(0, 28);
            this.tstripContainer.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpSongManager);
            this.tcMain.Controls.Add(this.tpDuplicates);
            this.tcMain.Controls.Add(this.tpRenamer);
            this.tcMain.Controls.Add(this.tpSetlistManager);
            this.tcMain.Controls.Add(this.tpCachePsarcEditor);
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Controls.Add(this.tpAbout);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1011, 611);
            this.tcMain.TabIndex = 2;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpSongManager
            // 
            this.tpSongManager.Location = new System.Drawing.Point(4, 25);
            this.tpSongManager.Name = "tpSongManager";
            this.tpSongManager.Size = new System.Drawing.Size(1003, 582);
            this.tpSongManager.TabIndex = 0;
            this.tpSongManager.Text = "Song Manager";
            this.tpSongManager.UseVisualStyleBackColor = true;
            // 
            // tpDuplicates
            // 
            this.tpDuplicates.Location = new System.Drawing.Point(4, 25);
            this.tpDuplicates.Name = "tpDuplicates";
            this.tpDuplicates.Size = new System.Drawing.Size(1003, 581);
            this.tpDuplicates.TabIndex = 4;
            this.tpDuplicates.Text = "Duplicates";
            this.tpDuplicates.UseVisualStyleBackColor = true;
            // 
            // tpRenamer
            // 
            this.tpRenamer.Location = new System.Drawing.Point(4, 25);
            this.tpRenamer.Name = "tpRenamer";
            this.tpRenamer.Padding = new System.Windows.Forms.Padding(3);
            this.tpRenamer.Size = new System.Drawing.Size(1003, 581);
            this.tpRenamer.TabIndex = 6;
            this.tpRenamer.Text = "Renamer";
            this.tpRenamer.UseVisualStyleBackColor = true;
            // 
            // tpSetlistManager
            // 
            this.tpSetlistManager.Location = new System.Drawing.Point(4, 25);
            this.tpSetlistManager.Name = "tpSetlistManager";
            this.tpSetlistManager.Size = new System.Drawing.Size(1003, 581);
            this.tpSetlistManager.TabIndex = 7;
            this.tpSetlistManager.Text = "Setlist Manger";
            this.tpSetlistManager.UseVisualStyleBackColor = true;
            // 
            // tpCachePsarcEditor
            // 
            this.tpCachePsarcEditor.Location = new System.Drawing.Point(4, 25);
            this.tpCachePsarcEditor.Name = "tpCachePsarcEditor";
            this.tpCachePsarcEditor.Size = new System.Drawing.Size(1003, 581);
            this.tpCachePsarcEditor.TabIndex = 0;
            this.tpCachePsarcEditor.Text = "Cache Psarc Editor";
            this.tpCachePsarcEditor.UseVisualStyleBackColor = true;
            // 
            // tpSettings
            // 
            this.tpSettings.Location = new System.Drawing.Point(4, 25);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(1003, 581);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tpAbout
            // 
            this.tpAbout.Location = new System.Drawing.Point(4, 25);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(1003, 581);
            this.tpAbout.TabIndex = 8;
            this.tpAbout.Text = "About";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // tsUtilities
            // 
            this.tsUtilities.Dock = System.Windows.Forms.DockStyle.None;
            this.tsUtilities.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnLaunchRS,
            this.toolStripSeparator1,
            this.tsBtnBackup,
            this.toolStripSeparator6,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.tsBtnUpload,
            this.tsBtnRequest,
            this.toolStripSeparator4,
            this.tsBtnHelp});
            this.tsUtilities.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsUtilities.Location = new System.Drawing.Point(3, 0);
            this.tsUtilities.Name = "tsUtilities";
            this.tsUtilities.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsUtilities.Size = new System.Drawing.Size(444, 25);
            this.tsUtilities.TabIndex = 0;
            // 
            // tsBtnLaunchRS
            // 
            this.tsBtnLaunchRS.Image = global::CustomsForgeManager.Properties.Resources.launch;
            this.tsBtnLaunchRS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLaunchRS.Name = "tsBtnLaunchRS";
            this.tsBtnLaunchRS.Size = new System.Drawing.Size(112, 22);
            this.tsBtnLaunchRS.Text = "Launch Rocksmith";
            this.tsBtnLaunchRS.Click += new System.EventHandler(this.tsBtnLaunchRS_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnBackup
            // 
            this.tsBtnBackup.Image = global::CustomsForgeManager.Properties.Resources.backup;
            this.tsBtnBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBackup.Name = "tsBtnBackup";
            this.tsBtnBackup.Size = new System.Drawing.Size(94, 22);
            this.tsBtnBackup.Text = "Backup Profile";
            this.tsBtnBackup.Click += new System.EventHandler(this.tsBtnBackup_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bBCodeToolStripMenuItem,
            this.cSVToolStripMenuItem,
            this.hTMLToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::CustomsForgeManager.Properties.Resources.export;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(68, 22);
            this.toolStripDropDownButton1.Text = "Export";
            // 
            // bBCodeToolStripMenuItem
            // 
            this.bBCodeToolStripMenuItem.Name = "bBCodeToolStripMenuItem";
            this.bBCodeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.bBCodeToolStripMenuItem.Text = "BB Code";
            this.bBCodeToolStripMenuItem.Click += new System.EventHandler(this.bBCodeToolStripMenuItem_Click);
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.hTMLToolStripMenuItem.Text = "HTML";
            this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.hTMLToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnUpload
            // 
            this.tsBtnUpload.Image = global::CustomsForgeManager.Properties.Resources.upload;
            this.tsBtnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnUpload.Name = "tsBtnUpload";
            this.tsBtnUpload.Size = new System.Drawing.Size(60, 22);
            this.tsBtnUpload.Text = "Upload";
            this.tsBtnUpload.ToolTipText = "Upload CDLC to CustomsForge";
            this.tsBtnUpload.Click += new System.EventHandler(this.tsBtnUpload_Click);
            // 
            // tsBtnRequest
            // 
            this.tsBtnRequest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnRequest.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnRequest.Image")));
            this.tsBtnRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRequest.Name = "tsBtnRequest";
            this.tsBtnRequest.Size = new System.Drawing.Size(51, 22);
            this.tsBtnRequest.Text = "Request";
            this.tsBtnRequest.ToolTipText = "Request a song on CustomsForge";
            this.tsBtnRequest.Click += new System.EventHandler(this.tsBtnRequest_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnHelp
            // 
            this.tsBtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnHelp.Image = global::CustomsForgeManager.Properties.Resources.Help;
            this.tsBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnHelp.Name = "tsBtnHelp";
            this.tsBtnHelp.Size = new System.Drawing.Size(23, 22);
            this.tsBtnHelp.Text = "Help";
            this.tsBtnHelp.Click += new System.EventHandler(this.tsBtnHelp_Click);
            // 
            // tsAudioPlayer
            // 
            this.tsAudioPlayer.Dock = System.Windows.Forms.DockStyle.None;
            this.tsAudioPlayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPlay,
            this.tsbStop,
            this.tspbAudioPosition,
            this.tslblTimer});
            this.tsAudioPlayer.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsAudioPlayer.Location = new System.Drawing.Point(481, 0);
            this.tsAudioPlayer.Name = "tsAudioPlayer";
            this.tsAudioPlayer.Padding = new System.Windows.Forms.Padding(0);
            this.tsAudioPlayer.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsAudioPlayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsAudioPlayer.Size = new System.Drawing.Size(202, 25);
            this.tsAudioPlayer.TabIndex = 1;
            // 
            // tsbPlay
            // 
            this.tsbPlay.AutoSize = false;
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = global::CustomsForgeManager.Properties.Resources.ap_play;
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Margin = new System.Windows.Forms.Padding(2);
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(18, 18);
            this.tsbPlay.Text = "Play";
            this.tsbPlay.ToolTipText = "Play/Pause";
            this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.AutoSize = false;
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = global::CustomsForgeManager.Properties.Resources.ap_stop;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Margin = new System.Windows.Forms.Padding(2);
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(18, 18);
            this.tsbStop.Text = "Stop";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // tspbAudioPosition
            // 
            this.tspbAudioPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.tspbAudioPosition.Name = "tspbAudioPosition";
            this.tspbAudioPosition.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tspbAudioPosition.Size = new System.Drawing.Size(100, 20);
            this.tspbAudioPosition.Step = 5;
            this.tspbAudioPosition.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.tspbAudioPosition.ToolTipText = "Click anywhere on progress bar to seek to song positon";
            this.tspbAudioPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tspbAudioPosition_MouseDown);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabel_ShowHideLog,
            this.tsProgressBar_Main,
            this.tsLabel_ClearLog,
            this.tsLabel_MainMsg,
            this.tsLabel_StatusMsg,
            this.tsLabel_Cancel,
            this.tsLabel_DisabledCounter});
            this.statusStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStripMain.Location = new System.Drawing.Point(0, 636);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1011, 23);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // tsLabel_ShowHideLog
            // 
            this.tsLabel_ShowHideLog.AutoSize = false;
            this.tsLabel_ShowHideLog.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLabel_ShowHideLog.IsLink = true;
            this.tsLabel_ShowHideLog.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsLabel_ShowHideLog.Name = "tsLabel_ShowHideLog";
            this.tsLabel_ShowHideLog.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.tsLabel_ShowHideLog.Size = new System.Drawing.Size(68, 18);
            this.tsLabel_ShowHideLog.Text = "Show Log ";
            this.tsLabel_ShowHideLog.Click += new System.EventHandler(this.tsLabelShowHideLog_Click);
            // 
            // tsProgressBar_Main
            // 
            this.tsProgressBar_Main.Name = "tsProgressBar_Main";
            this.tsProgressBar_Main.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.tsProgressBar_Main.Size = new System.Drawing.Size(408, 17);
            // 
            // tsLabel_ClearLog
            // 
            this.tsLabel_ClearLog.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLabel_ClearLog.IsLink = true;
            this.tsLabel_ClearLog.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsLabel_ClearLog.Name = "tsLabel_ClearLog";
            this.tsLabel_ClearLog.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.tsLabel_ClearLog.Size = new System.Drawing.Size(64, 18);
            this.tsLabel_ClearLog.Text = "Clear log";
            this.tsLabel_ClearLog.Click += new System.EventHandler(this.tsLabelClearLog_Click);
            // 
            // tsLabel_MainMsg
            // 
            this.tsLabel_MainMsg.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLabel_MainMsg.Margin = new System.Windows.Forms.Padding(9, 3, 0, 2);
            this.tsLabel_MainMsg.Name = "tsLabel_MainMsg";
            this.tsLabel_MainMsg.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.tsLabel_MainMsg.Size = new System.Drawing.Size(42, 18);
            this.tsLabel_MainMsg.Text = "Main";
            this.tsLabel_MainMsg.ToolTipText = "Main";
            // 
            // tsLabel_StatusMsg
            // 
            this.tsLabel_StatusMsg.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLabel_StatusMsg.Name = "tsLabel_StatusMsg";
            this.tsLabel_StatusMsg.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.tsLabel_StatusMsg.Size = new System.Drawing.Size(50, 18);
            this.tsLabel_StatusMsg.Spring = true;
            this.tsLabel_StatusMsg.Text = "Status";
            // 
            // tsLabel_Cancel
            // 
            this.tsLabel_Cancel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLabel_Cancel.IsLink = true;
            this.tsLabel_Cancel.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsLabel_Cancel.Name = "tsLabel_Cancel";
            this.tsLabel_Cancel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.tsLabel_Cancel.Size = new System.Drawing.Size(53, 18);
            this.tsLabel_Cancel.Text = "Cancel";
            this.tsLabel_Cancel.Click += new System.EventHandler(this.tsLabelCancel_Click);
            // 
            // tsLabel_DisabledCounter
            // 
            this.tsLabel_DisabledCounter.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLabel_DisabledCounter.Name = "tsLabel_DisabledCounter";
            this.tsLabel_DisabledCounter.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.tsLabel_DisabledCounter.Size = new System.Drawing.Size(65, 18);
            this.tsLabel_DisabledCounter.Text = "Disabled:";
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // timerAudioProgress
            // 
            this.timerAudioProgress.Interval = 400;
            this.timerAudioProgress.Tick += new System.EventHandler(this.timerAudioProgress_Tick);
            // 
            // tslblTimer
            // 
            this.tslblTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.tslblTimer.Name = "tslblTimer";
            this.tslblTimer.Size = new System.Drawing.Size(35, 20);
            this.tslblTimer.Text = "00:00";
            this.tslblTimer.ToolTipText = "Minutes:Seconds";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1011, 659);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.statusStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomsForge Song Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.contextMenuStrip_Tray.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tstripContainer.ContentPanel.ResumeLayout(false);
            this.tstripContainer.TopToolStripPanel.ResumeLayout(false);
            this.tstripContainer.TopToolStripPanel.PerformLayout();
            this.tstripContainer.ResumeLayout(false);
            this.tstripContainer.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tsUtilities.ResumeLayout(false);
            this.tsUtilities.PerformLayout();
            this.tsAudioPlayer.ResumeLayout(false);
            this.tsAudioPlayer.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbLog;
        private Timer timerMain;
        private Timer timerAutoUpdate;
        private NotifyIcon notifyIcon_Main;
        private ContextMenuStrip contextMenuStrip_Tray;
        private ToolStripMenuItem closeToolStripMenuItem;
        private SplitContainer scMain;
        public TextBox tbLog;
        private StatusStrip statusStripMain;
        public ToolStripStatusLabel tsLabel_ShowHideLog;
        public ToolStripProgressBar tsProgressBar_Main;
        public ToolStripStatusLabel tsLabel_ClearLog;
        public ToolStripStatusLabel tsLabel_MainMsg;
        public ToolStripStatusLabel tsLabel_StatusMsg;
        public ToolStripStatusLabel tsLabel_Cancel;
        public ToolStripStatusLabel tsLabel_DisabledCounter;
        private TabControl tcMain;
        private TabPage tpSongManager;
        private TabPage tpDuplicates;
        private TabPage tpRenamer;
        private TabPage tpSetlistManager;
        private TabPage tpSettings;
        private TabPage tpAbout;
        private ToolStrip tsUtilities;
        private ToolStripButton tsBtnLaunchRS;
        private ToolStripButton tsBtnBackup;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsBtnUpload;
        private ToolStripButton tsBtnRequest;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton tsBtnHelp;
        public ToolStripContainer tstripContainer;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem bBCodeToolStripMenuItem;
        private ToolStripMenuItem cSVToolStripMenuItem;
        private ToolStripMenuItem hTMLToolStripMenuItem;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStrip tsAudioPlayer;
        private ToolStripButton tsbPlay;
        private ToolStripButton tsbStop;
        private Timer timerAudioProgress;
        private ToolStripProgressBar tspbAudioPosition;
        private TabPage tpCachePsarcEditor;
        private ToolStripLabel tslblTimer;
    }
}