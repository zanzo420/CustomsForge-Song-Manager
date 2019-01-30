﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using CustomsForgeSongManager.DataObjects;
using GenTools;
using CustomsForgeSongManager.Properties;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using System.Drawing;
using CustomControls;

//
// Reusable generic background worker class
// TODO: cautously reimpliment background worker, i.e.,
// only use background worker if it improves the function of a method
//

namespace CustomsForgeSongManager.LocalTools
{
    internal sealed class GenericWorker : IDisposable
    {
        private AbortableBackgroundWorker bWorker;
        private Stopwatch counterStopwatch = new Stopwatch();
        private Control workOrder;

        public string WorkDescription = String.Empty;
        public dynamic WorkParm1;
        public dynamic WorkParm2;
        public dynamic WorkParm3;

        public void BackgroundProcess(object sender, AbortableBackgroundWorker backgroundWorker = null)
        {
            // keep track of UC that started worker
            workOrder = ((Control)sender);
            Globals.ResetToolStripGlobals();
            Globals.TsLabel_Cancel.Visible = true;
            Globals.TsLabel_Cancel.Enabled = true;
            Globals.TsLabel_MainMsg.Visible = true;
            Globals.TsLabel_StatusMsg.Visible = true;
            Globals.TsProgressBar_Main.Value = 0;
            Globals.WorkerFinished = Globals.Tristate.False;

            if (backgroundWorker == null)
                bWorker = new AbortableBackgroundWorker();
            else
                bWorker = backgroundWorker;

            bWorker.SetDefaults();
            counterStopwatch.Restart();

            if (WorkDescription.Equals(Constants.GWORKER_REPAIR))
                bWorker.DoWork += WorkerRepairSongs;
            else if (WorkDescription.Equals(Constants.GWORKER_ACHRIVE))
                bWorker.DoWork += WorkerArchiveSongs;
            else if (WorkDescription.Equals(Constants.GWORKER_PITCHSHIFT))
                bWorker.DoWork += WorkerPitchShiftSongs;
            else if (WorkDescription.Equals(Constants.GWORKER_ORGANIZE))
                bWorker.DoWork += WorkerOrganizeSongs;
            else if (WorkDescription.Equals(Constants.GWORKER_TAG) || WorkDescription.Equals(Constants.GWORKER_UNTAG))
                bWorker.DoWork += WorkerTagUntagSongs;
            else
                throw new Exception("I'm not that kind of worker ...");

            bWorker.RunWorkerCompleted += WorkerComplete;
            // don't run bWorker more than once
            if (!bWorker.IsBusy)
                bWorker.RunWorkerAsync();
        }

        private void WorkerProgress(int value)
        {
            if (Globals.TsProgressBar_Main != null && value <= 100)
            {
                // perma fix for periodic cross threading issue with TsProgressBar on initial startups
                GenExtensions.InvokeIfRequired(Globals.TsProgressBar_Main.GetCurrentParent(), delegate
                    {
                        Globals.TsProgressBar_Main.Value = value;
                    });
            }
        }

        private void WorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            GenExtensions.InvokeIfRequired(workOrder, delegate { Globals.TsLabel_Cancel.Visible = false; });

            if (e.Cancelled || Globals.TsLabel_Cancel.Text == "Canceling" || Globals.CancelBackgroundScan)
            {
                // bWorker.Abort(); // don't use abort
                bWorker.Dispose();
                bWorker = null;
                Globals.Log(Resources.UserCancelledProcess);
                Globals.TsLabel_MainMsg.Text = Resources.UserCancelled;
                Globals.TsLabel_StatusMsg.Text = "";
                Globals.WorkerFinished = Globals.Tristate.Cancelled;
            }
            else
            {
                WorkerProgress(100);
                counterStopwatch.Stop();
                Globals.Log(String.Format("Finished " + WorkDescription.ToLower() + " took: {0}", counterStopwatch.Elapsed));
                Globals.WorkerFinished = Globals.Tristate.True;
            }

            Globals.RescanProfileSongLists = false;
            Globals.RescanSetlistManager = false;
            Globals.RescanDuplicates = false;
            Globals.RescanSongManager = false;
            Globals.RescanRenamer = false;
            Globals.ReloadSetlistManager = true;
            Globals.ReloadDuplicates = true;
            Globals.ReloadRenamer = true;
            Globals.ReloadSongManager = true;
            Globals.ReloadProfileSongLists = true;
        }

        private void WorkerRepairSongs(object sender, DoWorkEventArgs e)
        {
            if (!bWorker.CancellationPending)
            {
                var coreTester = false;
                var coreCount = SysExtensions.GetCoreCount();
                if (coreCount == null || coreCount == 0)
                    coreCount = 1;

                // optimize tasks for multicore processors
                if (coreCount > 1)
                {
                    var diaMsg = ".NET Framework reports that you have a (" + coreCount + ") core processor ..." + Environment.NewLine +
                                 "Would you like to try running the CFSM repair options using" + Environment.NewLine +
                                 "the new multicore support feature?" + Environment.NewLine + Environment.NewLine +
                                 "Repairs can be made using the old method if you answer 'No'" + Environment.NewLine +
                                 "Please let the developers know how the featue worked for you.";

                    if (DialogResult.Yes == BetterDialog2.ShowDialog(diaMsg, "Multicore Processor Beta Test ...", null, "Yes", "No", Bitmap.FromHicon(SystemIcons.Hand.Handle), "ReadMe", 0, 150))
                        coreTester = true;
                }

                if (coreTester)
                {
                    List<Task> tasks = new List<Task>();
                    RepairOptions repairOptions = WorkParm2;
                    List<SongData> songsList = WorkParm1;
                    var songsSubLists = GenExtensions.SplitList(songsList, coreCount);

                    for (int i = 0; i < coreCount; i++)
                    {
                        tasks.Add(Task.Factory.StartNew(() =>
                            {
                                var result = RepairTools.RepairSongs(songsSubLists[i], repairOptions).ToString();
                                if (!String.IsNullOrEmpty(result))
                                    Globals.Log("<ERROR> " + result);
                            }));
                    }

                    Thread.Sleep(100);
                    Task.WaitAll(tasks.ToArray());

                    // alt wait method for testing
                    //var timeDelay = coreCount * 100;
                    //for (int i = 0; i < coreCount; i++)
                    //{
                    //    while (!tasks[i].IsCompleted)
                    //    {
                    //        Application.DoEvents();
                    //        Thread.Sleep(timeDelay);
                    //    }
                    //}

                    foreach (var task in tasks)
                        task.Dispose();
                }
                else // single core processor
                    RepairTools.RepairSongs(WorkParm1, WorkParm2);
            }
        }

        private void WorkerPitchShiftSongs(object sender, DoWorkEventArgs e)
        {
            if (!bWorker.CancellationPending)
                PitchShiftTools.PitchShiftSongs(WorkParm1, WorkParm2, WorkParm3);
        }

        private void WorkerArchiveSongs(object sender, DoWorkEventArgs e)
        {
            if (!bWorker.CancellationPending)
                FileTools.ArchiveFiles(WorkParm1, WorkParm2, WorkParm3);
        }

        private void WorkerOrganizeSongs(object sender, DoWorkEventArgs e)
        {
            if (!bWorker.CancellationPending)
                FileTools.ArtistFolders(WorkParm1, WorkParm2, WorkParm3);
        }

        private void WorkerTagUntagSongs(object sender, DoWorkEventArgs e)
        {
            if (!bWorker.CancellationPending)
                Globals.Tagger.TagUntagSongs(WorkParm1, WorkParm2);
        }

        [SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "bWorker")]
        public void Dispose()
        {
        }

        public static void ReportProgress(int processed = 0, int total = 0, int skipped = 0, int failed = 0)
        {
            int progress;
            if (total > 0)
                progress = processed * 100 / total;
            else
                progress = 100;

            // load to ProgressStatus so current data can be shared externally
            var rs = new ProgressStatus()
                {
                    Progress = progress,
                    Processed = processed,
                    Total = total,
                    Skipped = skipped,
                    Failed = failed
                };

            if (Globals.TsProgressBar_Main != null && progress <= 100)
                GenExtensions.InvokeIfRequired(Globals.TsProgressBar_Main.GetCurrentParent(), delegate { Globals.TsProgressBar_Main.Value = progress; });

            GenExtensions.InvokeIfRequired(Globals.TsLabel_MainMsg.GetCurrentParent(), delegate { Globals.TsLabel_MainMsg.Text = String.Format("Files Processed: {0} of {1}", processed, total); });
            GenExtensions.InvokeIfRequired(Globals.TsLabel_StatusMsg.GetCurrentParent(), delegate { Globals.TsLabel_StatusMsg.Text = String.Format("Skipped: {0}  Failed: {1}", skipped, failed); });
        }

        public static void InitReportProgress()
        {
            GenExtensions.InvokeIfRequired(Globals.TsLabel_MainMsg.GetCurrentParent(), delegate { Globals.TsLabel_MainMsg.Text = String.Format("Files Processed: {0} of {1}", 0, 0); });
            GenExtensions.InvokeIfRequired(Globals.TsLabel_MainMsg.GetCurrentParent(), delegate { Globals.TsLabel_MainMsg.Visible = true; });
            GenExtensions.InvokeIfRequired(Globals.TsLabel_StatusMsg.GetCurrentParent(), delegate { Globals.TsLabel_StatusMsg.Text = String.Format("Skipped: {0}  Failed: {1}", 0, 0); });
            GenExtensions.InvokeIfRequired(Globals.TsLabel_StatusMsg.GetCurrentParent(), delegate { Globals.TsLabel_StatusMsg.Visible = true; });
            GenExtensions.InvokeIfRequired(Globals.TsProgressBar_Main.GetCurrentParent(), delegate { Globals.TsProgressBar_Main.Value = 0; });
        }
    }

    public class ProgressStatus
    {
        public int Failed { get; set; }
        public int Processed { get; set; }
        public int Progress { get; set; }
        public int Skipped { get; set; }
        public int Total { get; set; }
    }

}