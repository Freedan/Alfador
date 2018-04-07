using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using Alfador.Code;

namespace Alfador.Forms
{
    public partial class frmMetro : MetroFramework.Forms.MetroForm
    {
        //LogViewer Fields
        private Thread logViewerWorkerThread = null;
        private delegate void UpdateLogViewDelegate();
        private UpdateLogViewDelegate updateLogViewDelegate = null;

        //File Copy Fields
        //private Thread fileCopyWorkerThread = null;
        //private delegate void RomFileCopyDelegate();
        //private RomFileCopyDelegate romFileCopyDelegate = null;

        private int copyCount = 0;
        private int copyMax = 0;

        public frmMetro()
        {
            InitializeComponent();
        }

        private void frmMetro_Load(object sender, EventArgs e)
        {
            //Testing
            metroGrid2.Rows.Add("Abadox.nes", "Nintendo", "fceulib.dll", "C:\\RetroArch\\ROMS\\nes", "C:\\retroarch.exe -L C:\\retroarch\\cores\\fceulib.dll -F C:\\retroarch\\roms\\nes\\abadox.nes ");
            metroGrid2.Rows.Add("Batman.nes", "Nintendo", "fceulib.dll", "C:\\RetroArch\\ROMS\\nes", "C:\\retroarch.exe -L C:\\retroarch\\cores\\fceulib.dll -F C:\\retroarch\\roms\\nes\\abadox.nes ");
            metroGrid2.Rows.Add("Final Fantasy.nes", "Super Nintendo", "fceulib.dll", "C:\\RetroArch\\ROMS\\nes", "C:\\retroarch.exe -L C:\\retroarch\\cores\\fceulib.dll -F C:\\retroarch\\roms\\nes\\abadox.nes ");
            metroGrid2.Rows.Add("Duck Tales.nes", "Nintendo", "fceulib.dll", "C:\\RetroArch\\ROMS\\nes", "C:\\retroarch.exe -L C:\\retroarch\\cores\\fceulib.dll -F C:\\retroarch\\roms\\nes\\abadox.nes ");
            metroGrid2.Rows.Add("Rescue Rangers.nes", "Super Nintendo", "fceulib.dll", "C:\\RetroArch\\ROMS\\nes", "C:\\retroarch.exe -L C:\\retroarch\\cores\\fceulib.dll -F C:\\retroarch\\roms\\nes\\abadox.nes ");
            //end testing

            metroTabControl1.SelectedTab = tabHomePage;
            ConfigManager.BuildConfiguration();


            //Options Form State Machine

            chkRetroArchIntegrated.Checked = Config.Instance.RetroArchIntegrated;
            txtInstallDirectory.Text = Config.Instance.InstallDirectory;

            //Config.Instance.InstallDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            //Config.Instance.RomDirectory = Config.Instance.InstallDirectory + @"\roms";
            //Config.Instance.ConfigDirectory = Config.Instance.InstallDirectory + @"\config";

            //ConfigManager.WriteConfigToFile();


            this.updateLogViewDelegate = new UpdateLogViewDelegate(this.UpdateLogView);
            //this.romFileCopyDelegate = new RomFileCopyDelegate(this.CopyRomFiles);
            //UpdateFavoritesComboBox();
            lblCopiedFile.Text = "";
            metroProgressBar1.Maximum = 0;
        }

















        private void btnCreateM3uPlaylist_Click(object sender, EventArgs e)
        {
            //Multi-disc PlayStation games (other systems?) require an m3u playlist when loading
            //with Mednafen. The format is simply the cue files listed in order, example:
            //Final Fantasy IX (USA) (Disc 1) (v1.1).cue
            //Final Fantasy IX (USA) (Disc 2) (v1.1).cue
            //Final Fantasy IX (USA) (Disc 3) (v1.1).cue
            //Final Fantasy IX (USA) (Disc 4) (v1.1).cue
            //The m3u file then needs to be copied along with respective bin/cue files to the psx ROM
            //directory. 
            //We only want the m3u file to show in the ROM tree

            OpenFileDialog importFile = new OpenFileDialog();
            importFile.Multiselect = true;

            string s = Config.Instance.InstallDirectory;

            importFile.InitialDirectory =  Config.Instance.RomDirectory;
            importFile.Title = "Select CUE Files";
            importFile.Filter = ".cue Files|*.cue";
                      
            try
            {
                if (importFile.ShowDialog() == DialogResult.OK)
                {
                    List<string> files = new List<string>();

                    foreach (string f in importFile.FileNames)
                    {
                        files.Add(f);
                    }

                    //frmNamePlaylist frmPlay = new frmNamePlaylist(files);
                    //frmPlay.ShowDialog();


                    // Launch Dialog confirming

                }
            }
            catch (Exception)
            {

            }
        }



        //Crashing Out from blank list
        //private void UpdateFavoritesComboBox()
        //{
        //    cmbFavorites.Items.Clear();
        //    if (Config.FavoriteGameList.Count != 0)
        //    {
        //        foreach (var r in Config.FavoriteGameList)
        //        {
        //            cmbFavorites.Items.Add(r);
        //        }
        //    }            
        //}

        private void ClearFavoritesComboBox()
        {
            Config.Instance.FavoriteGameList.Clear();
            //UpdateFavoritesComboBox();
        }

        private void ExecuteEconUpdater()
        {
            Process.Start(Config.Instance.InstallDirectory + @"\EconUpdater.exe");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                //string treePath = Regex.Replace(treeRoms.SelectedNode.ToString(), "TreeNode: ", "");
                //string treeNode = Regex.Replace(treeRoms.SelectedNode.Parent.ToString(), "TreeNode: ", "");
                //string filePath = Config.Instance.RomDirectory + "\\" + treeNode + "\\" + treePath;

                //RomController rom = new RomController(filePath);
                //WindowsController.CallCommandLine(rom.GenerateLaunchString());

                //PS2 Launch
                //if (rom.Extension == "ps2")
                //{
                //    LaunchPS2FromCommandLine(rom.FullFilePath);
                //    AddRecentGameToList(rom.FullFilePath);
                //}
                //else
                //{
                //    LaunchFromCommandLine(rom.FullFilePath, rom.Extension);
                //    AddRecentGameToList(rom.FullFilePath);
                //}

            }
            catch (FileNotFoundException Ex)
            {
                LogManager.UpdateLogFile("[Main]: There was a problem finding the file: " + Ex);
            }
            catch (NullReferenceException)
            {
                //MessageBox.Show("Please select a ROM from the list.");
            }
            catch (Win32Exception Ex)
            {
                LogManager.UpdateLogFile("[Main]: There was a problem finding the file: " + Ex);
            }
        }

        private void btnImportLibrary_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog importUserRoms = new FolderBrowserDialog();

            if (importUserRoms.ShowDialog() == DialogResult.OK)
            {
                string path = importUserRoms.SelectedPath;
                
                //aysnc
                RomManager.RunImportLogic(path);
                

                List<string> validList = RomManager.FetchValidCopyList();
                List<string> invalidList = RomManager.FetchInvalidCopyList();

                PromptForCopy(validList, invalidList);
                
                //So at this point we need to do several checks. 
                //If the Valid copy list isn't 0 then copy valid files
                //When those files are copied, give us a message and move onto the next thread.
                //If the inValid copy list isnt 0 then copy invalid files


            }            
        }

        #region FileCopy Logic

       
        private async void PromptForCopy(List<string> validList, List<string> invalidList)
        {
            if (validList.Count != 0)
            {
                string responseMessage;

                if (validList.Count == 1)
                {
                    responseMessage = " ROM was discovered. Proceed with import?";
                }
                else
                {
                    responseMessage = " ROMs were discovered. Proceed with import?";
                }

                if (MetroMessageBox.Show(this, validList.Count + responseMessage, "Confirm Import", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    foreach (var g in validList)
                    {
                        copyMax += 1;
                        metroProgressBar1.Maximum += 1;
                    }

                    await StartCopy(validList);
                }
                else
                {
                    LogManager.UpdateLogFile("[RomManager]: User cancelled out of ROM import.");
                }
            }
            else
            {
                MetroMessageBox.Show(this, "0 valid ROMs were discovered.", "No ROMs Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                LogManager.UpdateLogFile("[RomManager]: 0 valid ROMs were discovered.");
            }

            if (invalidList.Count != 0)
            {
                Form frmManualCopy = new Forms.frmManualCopy();
                frmManualCopy.Show();
            }
            else
            {
                LogManager.UpdateLogFile("[RomManager]: 0 invalid ROMs were discovered.");
            }
        }

        private async Task StartCopy(List<string> fileList)
        {
            foreach (var file in fileList)
            {
                //Task<string> CopyFileTask = CopyRomFiles(file);

                //lblCopiedFile.Text = await CopyFileTask;

                lblCopiedFile.Text = await CopyRomFiles(file);
            }

            ConfigManager.WriteConfigToFile();
        }


        private async Task<string> CopyRomFiles(string g)
        {
            
            string fileName = Path.GetFileName(g);
            string extension = Path.GetExtension(g);
            string directory = Path.GetDirectoryName(g);

            string sourceFile = directory + "\\" + fileName;
            
            string installFile = RomManager.FetchLocalInstallDirectory(extension) + "\\" + fileName;
            string romDirectory = Config.Instance.RomDirectory + Config.Instance.ExtensionDirectoryMappings[extension];

            //Breaks here, need to verify destination directory

            if (!Directory.Exists(romDirectory))
            {
                Directory.CreateDirectory(romDirectory);
            }

            using (FileStream SourceStream = File.Open(sourceFile, FileMode.Open))
            {
                using (FileStream DestinationStream = File.Create(installFile))
                {
                    lblCopiedFile.Text = "(" + copyCount + "/" + copyMax + ") Copying " + fileName + "...";
                    //Add a log file entry
                    await SourceStream.CopyToAsync(DestinationStream);
                }
            }
            //Confirm copy?
            copyCount += 1;
            metroProgressBar1.Value += 1;

            RomManager.AddRomToLibrary(g);




            return "(" + copyCount + "/" + copyMax + ") " + fileName + " Copied.";

        }

        



        #endregion

        #region LogViewer Logic

        private void UpdateLogView()
        {
            txtLog.Clear();

            foreach (var e in LogManager.LogEntries)
            {
                txtLog.AppendText(e + "\n");
            }
        }

        private void LoadLogList()
        {
            LogManager.LogEntries.Clear();
            LogManager.LogEntries = LogManager.LoadLogFile("econ.log");
            this.Invoke(this.updateLogViewDelegate);
        }

        private void metroTabControl1_Click(object sender, EventArgs e)
        {
            this.logViewerWorkerThread = new Thread(new ThreadStart(this.LoadLogList));
            this.logViewerWorkerThread.Start();
        }

        private void btnClearLogFile_Click(object sender, EventArgs e)
        {
            LogManager.ClearLogFile();
        }


        #endregion






        private void btnTest_Click(object sender, EventArgs e)
        {

      
        }

        private void xbtnWriteConfig_Click(object sender, EventArgs e)
        {
            ConfigManager.WriteConfigToFile();
        }

        private void chkRetroArchIntegrated_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRetroArchIntegrated.Checked)
            {
                Config.Instance.RetroArchIntegrated = true;

            }
            else
            {
                Config.Instance.RetroArchIntegrated = false;
            }

            ConfigManager.WriteConfigToFile();
        }

        private void btnCreateCueSheet_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectBin = new OpenFileDialog();
            selectBin.Multiselect = true;

            selectBin.InitialDirectory = Config.Instance.InstallDirectory + "\\roms\\";
            selectBin.Title = "Select bin File";
            selectBin.Filter = ".bin Files|*.bin";


            try
            {
                if (selectBin.ShowDialog() == DialogResult.OK)
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.InitialDirectory = Config.Instance.InstallDirectory + "\\roms\\";
                    saveFile.Title = "Save CUE Sheet";
                    saveFile.Filter = ".cue Files|*.cue";
                    saveFile.FileName = Path.GetFileName(selectBin.FileName);

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        string sysDir = Path.GetDirectoryName(saveFile.FileName);
                        AlfadorTools.CreateCueSheet(selectBin.FileName, sysDir);
                    }


                }
            }
            catch (Exception)
            {

            }
        }

        private void btnExportRomLibrary_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            AlfadorTools.ExportRomFiles();
            this.Cursor = Cursors.Default;
            AlfadorTools.CallSaveFileDialog();
        }

        private void btnCleanBackupFiles_Click(object sender, EventArgs e)
        {
            AlfadorTools.DeleteBackupDirectory();
        }

        private void btnImportSaveRam_Click(object sender, EventArgs e)
        {
            AlfadorTools.ImportSaveRam();
        }

        private void btnExportSaveRam_Click(object sender, EventArgs e)
        {
            AlfadorTools.ExportSaveRam();
        }

        private void btnImportBIOS_Click(object sender, EventArgs e)
        {
            AlfadorTools.ImportBIOSFiles();
        }
    }
}
