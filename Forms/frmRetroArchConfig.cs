using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.IO.Compression;
using Alfador.Code;

namespace Alfador.Forms
{
    public partial class frmRetroArchConfig : Form
    {
        public frmRetroArchConfig()
        {
            InitializeComponent();
        }

        private void frmRetroArchConfig_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Running RetroArch Version " + FetchRetroArchVersion();
            LoadExtensionList();
        }
     
        public void LoadExtensionList()
        {
            //ListController.ExtensionConfiguration.Sort();
            //listboxCoreSettings.Items.Clear();
            //foreach (var line in ListController.ExtensionConfiguration)
            //{
            //    listboxCoreSettings.Items.Add(line);
            //}
        }
        private void btnApplyCore_Click(object sender, EventArgs e)
        {
            frmCoreEdit frmEdit = new frmCoreEdit();
            frmEdit.ShowDialog();    
        }      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Remove entry?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string oldEntry = listboxCoreSettings.SelectedItem.ToString();
                    //ListController.ExtensionConfiguration.Remove(oldEntry);
                    LoadExtensionList();
                }
            }
            catch (Exception)
            {

            }

        }

        private void btnUpdate_Click(object sender, EventArgs f)
        {
            //string ver = frmMain.RetroVersion;

            //var retroArch = from config in ListController.EconConfiguration
            //                where config.Contains("retroarch_compile_version")
            //                select config;

            //foreach (var config in retroArch)
            //{
            //    ver = config.ToString();
            //}
            //if (ver == "")
            //{
            //    ver = "x86";
            //}
            //else
            //{
            //    string[] configString = ver.Split('=');
            //    ver = configString[1].Replace("\"", "");
            //    ver = ver.Replace(" ", "");
            //}

            if (listboxCoreSettings.SelectedItem == null)
            {
                MessageBox.Show("Select a core to update.");
            }
            else
            {
                prgUpdate.Visible = true;
                string entry = listboxCoreSettings.SelectedItem.ToString();
                string[] entries = entry.Split('|');

                string core = entries[2];
                string download = core + ".zip";

                string zipDir = Config.Instance.InstallDirectory + @"\backup\" + download;
                string coreDir = Config.Instance.InstallDirectory + @"\retroarch\cores\" + core;
                //string uri = "http://buildbot.libretro.com/nightly/windows/" + ver + "/latest/" + download;
                WebClient webClient = new WebClient();

                webClient.DownloadProgressChanged += (s, e) =>
                {
                    prgUpdate.Value = e.ProgressPercentage;
                };

                webClient.DownloadFileCompleted += (s, e) =>
                {
                    prgUpdate.Visible = false;
                    //UnpackCore(zipDir, coreDir, ver);
                    File.Delete(zipDir);
                    LogManager.UpdateLogFile("[RetroArch]: " + download + " deleted from backup directory.");

                };
                //webClient.DownloadFileAsync(new Uri(uri), zipDir);
            }

        }

        private void UnpackCore(string zipDir, string coreDir, string version)
        {
            try
            {
                string zipPath = zipDir;
                string extractPath = coreDir;

                using (ZipArchive archive = ZipFile.OpenRead(zipPath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        entry.ExtractToFile(extractPath, true);

                    }
                }

                string filename = Path.GetFileName(coreDir);
                MessageBox.Show("Updated version of " + filename + " (" + version + ") copied to the core directory.");
                LogManager.UpdateLogFile("[RetroArch]: Updated version of " + filename + " (" + version + ") copied to the core directory.");
            }
            catch (Exception e)
            {
                MessageBox.Show("There was a problem unpacking the download. Please check the log file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LogManager.UpdateLogFile("[RetroConfig]: UnpackCore() threw an exception. Trouble unpacking download, may be a corrupt file: " + e);
            }

        }

        private string FetchRetroArchVersion()
        {
            string ver = "";

            //foreach (string item in ListController.EconConfiguration)
            //{
            //    if (item.Contains("retroarch_compile_version"))
            //    {
            //        string[] configString = item.Split('=');
            //        ver = configString[1].Replace("\"", "");
            //        ver = ver.Replace(" ", "");
            //    }                
            //}
            //if (ver == "")
            //{
            //    ver = "(null)";
            //}
            return ver; 
        }

        private void btnUpdateAllCores_Click(object sender, EventArgs e)
        {
            frmCoreUpdater frmCoreUpdater = new frmCoreUpdater();
            frmCoreUpdater.ShowDialog();
        }
    }
}
