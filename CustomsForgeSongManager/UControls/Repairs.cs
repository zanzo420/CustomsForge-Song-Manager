﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using CFSM.GenTools;
using CustomsForgeSongManager.DataObjects;
using CustomsForgeSongManager.Forms;


namespace CustomsForgeSongManager.UControls
{
    public partial class Repairs : UserControl
    {
        //TODO: add backup for each song separately

        List<string> failedRepairsLog;

        public Repairs()
        {
            InitializeComponent();
            lblProgress.Text = "Progress: 0/" + Globals.SongCollection.Count().ToString();
            failedRepairsLog = new List<string>();
        }

        public void RepairAllCDLC()
        {
            List<string> log = new List<string>();
            int progress = 0, failed = 0, songCount = Globals.SongCollection.Count();

            if (!File.Exists("remastered.exe"))
            {
                MessageBox.Show("Required assemblies are missing, please reinstall CFSM and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (SongData song in Globals.SongCollection)
            {
                if (!song.OfficialDLC)
                {
                    string message = GenExtensions.RunExtExe("remastered.exe", true, true, false, @"""" + song.FilePath + @"""");

                    if (message.ToLower().Contains("repair was sucessful"))
                        dgvLog.Rows.Add(song.Artist + "-" + song.Title, "Repair sucessful!");
                    else if (message.ToLower().Contains("skipped"))
                        dgvLog.Rows.Add(song.Artist + "-" + song.Title, "Skipped! (already repaired)");
                    else
                    {
                        dgvLog.Rows.Add(song.Artist + "-" + song.Title, "Error! (saved to the log)");

                        message = message.Remove(message.IndexOf("\r\n\r\n - 'Notice") + 1);
                        log.Add(message);

                        failed++;
                        lblFailedRepairs.Text = failed.ToString();
                    }
                }

                progress++;

                lblProgress.Text = "Progress: " + progress.ToString() + "/" + songCount.ToString();
            }

            failedRepairsLog = log;
            MessageBox.Show("Song collection repairing done!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRepairCDLCs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to repair all your CDLC songs?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RepairAllCDLC();
            }
        }

        private void btnRemoveBackup_Click(object sender, EventArgs e)
        {
            string repairedPath, backupPath;

            if (MessageBox.Show("Are you sure you want to remove your backuped songs?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    List<string> backups = Directory.GetFiles(Path.Combine(AppSettings.Instance.RSInstalledDir, "dlc"), "*_p.psarc.org", SearchOption.AllDirectories).ToList();

                    for (int i = backups.Count - 1; i >= 0; i--)
                    {
                        backupPath = backups[i];
                        repairedPath = backups[i].Replace("org", "");

                        if (File.Exists(repairedPath))
                            File.Delete(backupPath);
                        else
                            File.Move(backupPath, repairedPath);
                    }
                }
                catch (IOException ex)
                {
                    Globals.Log(ex.Message);
                }
            }
        }

        private void btnRestoreBackup_Click(object sender, EventArgs e)
        {
            string repairedPath, backupPath;

            try
            {
                if (MessageBox.Show("Are you sure you want to remove your backuped songs?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<string> backups = Directory.GetFiles(Path.Combine(AppSettings.Instance.RSInstalledDir, "dlc"), "*_p.psarc.org", SearchOption.AllDirectories).ToList();

                    for (int i = backups.Count - 1; i >= 0; i--)
                    {
                        backupPath = backups[i];
                        repairedPath = backups[i].Replace("org", "");

                        if (File.Exists(repairedPath))
                            File.Delete(repairedPath);

                        File.Move(backupPath, repairedPath);
                    }
                }
            }
            catch (IOException ex)
            {
                Globals.Log(ex.Message);
            }
        }

        private void btnShowLogOfFailedRepairs_Click(object sender, EventArgs e)
        {
            string stringLog = string.Join("\n", failedRepairsLog);

            if (string.IsNullOrEmpty(stringLog))
                stringLog = "No song repairs failed!";

            using (var noteViewer = new frmNoteViewer())
            {
                noteViewer.PopulateText(stringLog);
                noteViewer.ShowDialog();
            }
        }
    }
}

