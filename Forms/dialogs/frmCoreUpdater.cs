using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfador.Forms
{
    public partial class frmCoreUpdater : Form
    {
        public frmCoreUpdater()
        {
            InitializeComponent();
        }

        //        private void Download(string file, string dir, string coreDir, string core)
        //        {
        //            WebClient webClient = new WebClient();

        //            webClient.DownloadProgressChanged += (s, e) =>
        //            {
        //                prgUpdate.Value = e.ProgressPercentage;
        //            };

        //            webClient.DownloadFileCompleted += (s, e) =>
        //            {
        //                UnpackCore(dir, coreDir, "x86_64");
        //                File.Delete(dir);
        //            };

        //            webClient.DownloadFileCompleted += (s, e) =>
        //            {
        //                progressBar1.Value += 1;
        //                label1.Text = "Downloaded " + core;

        //                if (progressBar1.Value == progressBar1.Maximum)
        //                {
        //                    label1.Text = "Download Complete.";
        //                    label2.Text = "Extracted.";

        //                    MessageBox.Show("Completed Core Update");
        //                    this.Close();
        //                }
        //            };
        //            webClient.DownloadFileAsync(new Uri(file), dir);
        //        }

        //        private void UnpackCore(string zipDir, string coreDir, string version)
        //        {
        //            try
        //            {
        //                string zipPath = zipDir;
        //                string extractPath = coreDir;

        //                using (ZipArchive archive = ZipFile.OpenRead(zipPath))
        //                {
        //                    foreach (ZipArchiveEntry entry in archive.Entries)
        //                    {
        //                        entry.ExtractToFile(extractPath, true);
        //                    }
        //                }

        //                string filename = Path.GetFileName(coreDir);
        //                LogManager.UpdateLogFile("[RetroArch]: Updated version of " + filename + " (" + version + ") copied to the core directory.");
        //            }
        //            catch (Exception e)
        //            {
        //                LogManager.UpdateLogFile("[RetroConfig]: UnpackCore() threw an exception. Trouble unpacking download, may be a corrupt file: " + e);
        //            }
        //        }

        //        private void frmCoreUpdater_Load(object sender, EventArgs e)
        //        {
        //            //string ver = frmMain.RetroVersion;
        //            foreach (var entry in ListController.CoreList)
        //            {
        //                string[] entries = entry.Split('|');

        //                string core = entries[0];
        //                string download = core + ".zip";

        //                string zipDir = Config.Instance.InstallDirectory + @"\backup\" + download;
        //                string coreDir = Config.Instance.InstallDirectory + @"\retroarch\cores\" + core;
        //                //string uri = "http://buildbot.libretro.com/nightly/windows/" + ver + "/latest/" + download;

        //                //Download(uri, zipDir, coreDir, core);
        //            }
        //        }
    }
}
