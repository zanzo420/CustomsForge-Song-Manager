﻿namespace CustomsForgeManager.Forms
{
    partial class frmSongInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSongInfo));
            this.gb_MainSongInfoPanel = new System.Windows.Forms.GroupBox();
            this.tlp_MainSongInfoWrapper = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_PanelSongTitleLbl = new System.Windows.Forms.Label();
            this.lbl_PanelSongAlbumLbl = new System.Windows.Forms.Label();
            this.lbl_PanelSongArtistLbl = new System.Windows.Forms.Label();
            this.lbl_PanelSongYearLbl = new System.Windows.Forms.Label();
            this.lbl_PanelSongTuningLbl = new System.Windows.Forms.Label();
            this.lbl_PanelSongDDLbl = new System.Windows.Forms.Label();
            this.lbl_PanelSongArrangementsLbl = new System.Windows.Forms.Label();
            this.lbl_PanelSongAuthorLbl = new System.Windows.Forms.Label();
            this.lbl_PanelSongTitle = new System.Windows.Forms.Label();
            this.lbl_PanelSongAlbum = new System.Windows.Forms.Label();
            this.lbl_PanelSongArtist = new System.Windows.Forms.Label();
            this.lbl_PanelSongYear = new System.Windows.Forms.Label();
            this.lbl_PanelSongTuning = new System.Windows.Forms.Label();
            this.lbl_PanelSongDD = new System.Windows.Forms.Label();
            this.lbl_PanelSongArrangements = new System.Windows.Forms.Label();
            this.lbl_PanelSongAuthor = new System.Windows.Forms.Label();
            this.dgv_Arrangements = new System.Windows.Forms.DataGridView();
            this.colLead = new System.Windows.Forms.DataGridViewImageColumn();
            this.colRhythm = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBass = new System.Windows.Forms.DataGridViewImageColumn();
            this.colVocals = new System.Windows.Forms.DataGridViewImageColumn();
            this.gb_MainSongInfoPanel.SuspendLayout();
            this.tlp_MainSongInfoWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Arrangements)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_MainSongInfoPanel
            // 
            this.gb_MainSongInfoPanel.Controls.Add(this.tlp_MainSongInfoWrapper);
            this.gb_MainSongInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_MainSongInfoPanel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.gb_MainSongInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.gb_MainSongInfoPanel.Name = "gb_MainSongInfoPanel";
            this.gb_MainSongInfoPanel.Size = new System.Drawing.Size(411, 402);
            this.gb_MainSongInfoPanel.TabIndex = 4;
            this.gb_MainSongInfoPanel.TabStop = false;
            this.gb_MainSongInfoPanel.Text = "Song Info Panel";
            // 
            // tlp_MainSongInfoWrapper
            // 
            this.tlp_MainSongInfoWrapper.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlp_MainSongInfoWrapper.ColumnCount = 2;
            this.tlp_MainSongInfoWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_MainSongInfoWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongTitleLbl, 0, 1);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongAlbumLbl, 0, 2);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongArtistLbl, 0, 3);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongYearLbl, 0, 4);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongTuningLbl, 0, 5);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongDDLbl, 0, 6);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongArrangementsLbl, 0, 7);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongAuthorLbl, 0, 9);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongTitle, 1, 1);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongAlbum, 1, 2);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongArtist, 1, 3);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongYear, 1, 4);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongTuning, 1, 5);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongDD, 1, 6);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongArrangements, 1, 7);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.lbl_PanelSongAuthor, 1, 9);
            this.tlp_MainSongInfoWrapper.Controls.Add(this.dgv_Arrangements, 1, 8);
            this.tlp_MainSongInfoWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_MainSongInfoWrapper.Location = new System.Drawing.Point(3, 16);
            this.tlp_MainSongInfoWrapper.Name = "tlp_MainSongInfoWrapper";
            this.tlp_MainSongInfoWrapper.RowCount = 11;
            this.tlp_MainSongInfoWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_MainSongInfoWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_MainSongInfoWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_MainSongInfoWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_MainSongInfoWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_MainSongInfoWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_MainSongInfoWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_MainSongInfoWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_MainSongInfoWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlp_MainSongInfoWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_MainSongInfoWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_MainSongInfoWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_MainSongInfoWrapper.Size = new System.Drawing.Size(405, 383);
            this.tlp_MainSongInfoWrapper.TabIndex = 0;
            // 
            // lbl_PanelSongTitleLbl
            // 
            this.lbl_PanelSongTitleLbl.AutoSize = true;
            this.lbl_PanelSongTitleLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_PanelSongTitleLbl.Location = new System.Drawing.Point(58, 24);
            this.lbl_PanelSongTitleLbl.Name = "lbl_PanelSongTitleLbl";
            this.lbl_PanelSongTitleLbl.Size = new System.Drawing.Size(60, 20);
            this.lbl_PanelSongTitleLbl.TabIndex = 0;
            this.lbl_PanelSongTitleLbl.Text = "Song Title:";
            this.lbl_PanelSongTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PanelSongAlbumLbl
            // 
            this.lbl_PanelSongAlbumLbl.AutoSize = true;
            this.lbl_PanelSongAlbumLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_PanelSongAlbumLbl.Location = new System.Drawing.Point(78, 46);
            this.lbl_PanelSongAlbumLbl.Name = "lbl_PanelSongAlbumLbl";
            this.lbl_PanelSongAlbumLbl.Size = new System.Drawing.Size(40, 20);
            this.lbl_PanelSongAlbumLbl.TabIndex = 1;
            this.lbl_PanelSongAlbumLbl.Text = "Album:";
            this.lbl_PanelSongAlbumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PanelSongArtistLbl
            // 
            this.lbl_PanelSongArtistLbl.AutoSize = true;
            this.lbl_PanelSongArtistLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_PanelSongArtistLbl.Location = new System.Drawing.Point(77, 68);
            this.lbl_PanelSongArtistLbl.Name = "lbl_PanelSongArtistLbl";
            this.lbl_PanelSongArtistLbl.Size = new System.Drawing.Size(41, 20);
            this.lbl_PanelSongArtistLbl.TabIndex = 1;
            this.lbl_PanelSongArtistLbl.Text = "Artist:";
            this.lbl_PanelSongArtistLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PanelSongYearLbl
            // 
            this.lbl_PanelSongYearLbl.AutoSize = true;
            this.lbl_PanelSongYearLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_PanelSongYearLbl.Location = new System.Drawing.Point(82, 90);
            this.lbl_PanelSongYearLbl.Name = "lbl_PanelSongYearLbl";
            this.lbl_PanelSongYearLbl.Size = new System.Drawing.Size(36, 20);
            this.lbl_PanelSongYearLbl.TabIndex = 1;
            this.lbl_PanelSongYearLbl.Text = "Year:";
            this.lbl_PanelSongYearLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PanelSongTuningLbl
            // 
            this.lbl_PanelSongTuningLbl.AutoSize = true;
            this.lbl_PanelSongTuningLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_PanelSongTuningLbl.Location = new System.Drawing.Point(73, 112);
            this.lbl_PanelSongTuningLbl.Name = "lbl_PanelSongTuningLbl";
            this.lbl_PanelSongTuningLbl.Size = new System.Drawing.Size(45, 20);
            this.lbl_PanelSongTuningLbl.TabIndex = 1;
            this.lbl_PanelSongTuningLbl.Text = "Tuning:";
            this.lbl_PanelSongTuningLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PanelSongDDLbl
            // 
            this.lbl_PanelSongDDLbl.AutoSize = true;
            this.lbl_PanelSongDDLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_PanelSongDDLbl.Location = new System.Drawing.Point(15, 134);
            this.lbl_PanelSongDDLbl.Name = "lbl_PanelSongDDLbl";
            this.lbl_PanelSongDDLbl.Size = new System.Drawing.Size(103, 20);
            this.lbl_PanelSongDDLbl.TabIndex = 1;
            this.lbl_PanelSongDDLbl.Text = "Dynamic Difficulty:";
            this.lbl_PanelSongDDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PanelSongArrangementsLbl
            // 
            this.lbl_PanelSongArrangementsLbl.AutoSize = true;
            this.lbl_PanelSongArrangementsLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_PanelSongArrangementsLbl.Location = new System.Drawing.Point(36, 156);
            this.lbl_PanelSongArrangementsLbl.Name = "lbl_PanelSongArrangementsLbl";
            this.lbl_PanelSongArrangementsLbl.Size = new System.Drawing.Size(82, 20);
            this.lbl_PanelSongArrangementsLbl.TabIndex = 1;
            this.lbl_PanelSongArrangementsLbl.Text = "Arrangements:";
            this.lbl_PanelSongArrangementsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PanelSongAuthorLbl
            // 
            this.lbl_PanelSongAuthorLbl.AutoSize = true;
            this.lbl_PanelSongAuthorLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_PanelSongAuthorLbl.Location = new System.Drawing.Point(72, 209);
            this.lbl_PanelSongAuthorLbl.Name = "lbl_PanelSongAuthorLbl";
            this.lbl_PanelSongAuthorLbl.Size = new System.Drawing.Size(46, 24);
            this.lbl_PanelSongAuthorLbl.TabIndex = 1;
            this.lbl_PanelSongAuthorLbl.Text = "Author:";
            this.lbl_PanelSongAuthorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PanelSongTitle
            // 
            this.lbl_PanelSongTitle.AutoSize = true;
            this.lbl_PanelSongTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_PanelSongTitle.Location = new System.Drawing.Point(126, 24);
            this.lbl_PanelSongTitle.Name = "lbl_PanelSongTitle";
            this.lbl_PanelSongTitle.Size = new System.Drawing.Size(0, 20);
            this.lbl_PanelSongTitle.TabIndex = 2;
            this.lbl_PanelSongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PanelSongAlbum
            // 
            this.lbl_PanelSongAlbum.AutoSize = true;
            this.lbl_PanelSongAlbum.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_PanelSongAlbum.Location = new System.Drawing.Point(126, 46);
            this.lbl_PanelSongAlbum.Name = "lbl_PanelSongAlbum";
            this.lbl_PanelSongAlbum.Size = new System.Drawing.Size(0, 20);
            this.lbl_PanelSongAlbum.TabIndex = 2;
            this.lbl_PanelSongAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PanelSongArtist
            // 
            this.lbl_PanelSongArtist.AutoSize = true;
            this.lbl_PanelSongArtist.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_PanelSongArtist.Location = new System.Drawing.Point(126, 68);
            this.lbl_PanelSongArtist.Name = "lbl_PanelSongArtist";
            this.lbl_PanelSongArtist.Size = new System.Drawing.Size(0, 20);
            this.lbl_PanelSongArtist.TabIndex = 2;
            this.lbl_PanelSongArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PanelSongYear
            // 
            this.lbl_PanelSongYear.AutoSize = true;
            this.lbl_PanelSongYear.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_PanelSongYear.Location = new System.Drawing.Point(126, 90);
            this.lbl_PanelSongYear.Name = "lbl_PanelSongYear";
            this.lbl_PanelSongYear.Size = new System.Drawing.Size(0, 20);
            this.lbl_PanelSongYear.TabIndex = 2;
            this.lbl_PanelSongYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PanelSongTuning
            // 
            this.lbl_PanelSongTuning.AutoSize = true;
            this.lbl_PanelSongTuning.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_PanelSongTuning.Location = new System.Drawing.Point(126, 112);
            this.lbl_PanelSongTuning.Name = "lbl_PanelSongTuning";
            this.lbl_PanelSongTuning.Size = new System.Drawing.Size(0, 20);
            this.lbl_PanelSongTuning.TabIndex = 2;
            this.lbl_PanelSongTuning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PanelSongDD
            // 
            this.lbl_PanelSongDD.AutoSize = true;
            this.lbl_PanelSongDD.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_PanelSongDD.Location = new System.Drawing.Point(126, 134);
            this.lbl_PanelSongDD.Name = "lbl_PanelSongDD";
            this.lbl_PanelSongDD.Size = new System.Drawing.Size(0, 20);
            this.lbl_PanelSongDD.TabIndex = 2;
            this.lbl_PanelSongDD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PanelSongArrangements
            // 
            this.lbl_PanelSongArrangements.AutoSize = true;
            this.lbl_PanelSongArrangements.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_PanelSongArrangements.Location = new System.Drawing.Point(126, 156);
            this.lbl_PanelSongArrangements.Name = "lbl_PanelSongArrangements";
            this.lbl_PanelSongArrangements.Size = new System.Drawing.Size(0, 20);
            this.lbl_PanelSongArrangements.TabIndex = 2;
            this.lbl_PanelSongArrangements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PanelSongAuthor
            // 
            this.lbl_PanelSongAuthor.AutoSize = true;
            this.lbl_PanelSongAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_PanelSongAuthor.Location = new System.Drawing.Point(126, 209);
            this.lbl_PanelSongAuthor.Name = "lbl_PanelSongAuthor";
            this.lbl_PanelSongAuthor.Size = new System.Drawing.Size(0, 24);
            this.lbl_PanelSongAuthor.TabIndex = 2;
            this.lbl_PanelSongAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_Arrangements
            // 
            this.dgv_Arrangements.AllowUserToAddRows = false;
            this.dgv_Arrangements.AllowUserToDeleteRows = false;
            this.dgv_Arrangements.AllowUserToResizeColumns = false;
            this.dgv_Arrangements.AllowUserToResizeRows = false;
            this.dgv_Arrangements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_Arrangements.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Arrangements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Arrangements.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Arrangements.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_Arrangements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Arrangements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Arrangements.ColumnHeadersVisible = false;
            this.dgv_Arrangements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLead,
            this.colRhythm,
            this.colBass,
            this.colVocals});
            this.dgv_Arrangements.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Arrangements.Enabled = false;
            this.dgv_Arrangements.Location = new System.Drawing.Point(126, 181);
            this.dgv_Arrangements.MultiSelect = false;
            this.dgv_Arrangements.Name = "dgv_Arrangements";
            this.dgv_Arrangements.ReadOnly = true;
            this.dgv_Arrangements.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Arrangements.RowHeadersVisible = false;
            this.dgv_Arrangements.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Arrangements.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_Arrangements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Arrangements.ShowCellErrors = false;
            this.dgv_Arrangements.ShowEditingIcon = false;
            this.dgv_Arrangements.Size = new System.Drawing.Size(80, 23);
            this.dgv_Arrangements.TabIndex = 3;
            // 
            // colLead
            // 
            this.colLead.HeaderText = "Lead";
            this.colLead.Image = global::CustomsForgeManager.Properties.Resources.Letter_L;
            this.colLead.MinimumWidth = 20;
            this.colLead.Name = "colLead";
            this.colLead.ReadOnly = true;
            this.colLead.Width = 20;
            // 
            // colRhythm
            // 
            this.colRhythm.HeaderText = "Rhythm";
            this.colRhythm.Image = global::CustomsForgeManager.Properties.Resources.Letter_R;
            this.colRhythm.MinimumWidth = 20;
            this.colRhythm.Name = "colRhythm";
            this.colRhythm.ReadOnly = true;
            this.colRhythm.Width = 20;
            // 
            // colBass
            // 
            this.colBass.HeaderText = "Bass";
            this.colBass.Image = global::CustomsForgeManager.Properties.Resources.Letter_B;
            this.colBass.MinimumWidth = 20;
            this.colBass.Name = "colBass";
            this.colBass.ReadOnly = true;
            this.colBass.Width = 20;
            // 
            // colVocals
            // 
            this.colVocals.HeaderText = "Vocals";
            this.colVocals.Image = global::CustomsForgeManager.Properties.Resources.Letter_V;
            this.colVocals.MinimumWidth = 20;
            this.colVocals.Name = "colVocals";
            this.colVocals.ReadOnly = true;
            this.colVocals.Width = 20;
            // 
            // frmSongInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 402);
            this.Controls.Add(this.gb_MainSongInfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSongInfo";
            this.ShowIcon = false;
            this.Text = "Song Info";
            this.Load += new System.EventHandler(this.frmSongInfo_Load);
            this.gb_MainSongInfoPanel.ResumeLayout(false);
            this.tlp_MainSongInfoWrapper.ResumeLayout(false);
            this.tlp_MainSongInfoWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Arrangements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_MainSongInfoPanel;
        private System.Windows.Forms.TableLayoutPanel tlp_MainSongInfoWrapper;
        private System.Windows.Forms.Label lbl_PanelSongTitleLbl;
        private System.Windows.Forms.Label lbl_PanelSongAlbumLbl;
        private System.Windows.Forms.Label lbl_PanelSongArtistLbl;
        private System.Windows.Forms.Label lbl_PanelSongYearLbl;
        private System.Windows.Forms.Label lbl_PanelSongTuningLbl;
        private System.Windows.Forms.Label lbl_PanelSongDDLbl;
        private System.Windows.Forms.Label lbl_PanelSongArrangementsLbl;
        private System.Windows.Forms.Label lbl_PanelSongAuthorLbl;
        private System.Windows.Forms.Label lbl_PanelSongTitle;
        private System.Windows.Forms.Label lbl_PanelSongAlbum;
        private System.Windows.Forms.Label lbl_PanelSongArtist;
        private System.Windows.Forms.Label lbl_PanelSongYear;
        private System.Windows.Forms.Label lbl_PanelSongTuning;
        private System.Windows.Forms.Label lbl_PanelSongDD;
        private System.Windows.Forms.Label lbl_PanelSongArrangements;
        private System.Windows.Forms.Label lbl_PanelSongAuthor;
        private System.Windows.Forms.DataGridView dgv_Arrangements;
        private System.Windows.Forms.DataGridViewImageColumn colLead;
        private System.Windows.Forms.DataGridViewImageColumn colRhythm;
        private System.Windows.Forms.DataGridViewImageColumn colBass;
        private System.Windows.Forms.DataGridViewImageColumn colVocals;
    }
}