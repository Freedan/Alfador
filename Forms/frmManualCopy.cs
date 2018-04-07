using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfador.Forms
{
    public partial class frmManualCopy : MetroFramework.Forms.MetroForm
    {
        private List<string> badRoms = new List<string>();
        private List<string> removeList = new List<string>();

        private string fileName;
        private string filePath;
        private string extension;
        private bool cueCheck;
        int listIndex;

        public frmManualCopy()
        {
            InitializeComponent();
        }

        #region Form Load Events

        private void frmManualCopy_Load(object sender, EventArgs e)
        {
            badRoms = RomManager.FetchInvalidCopyList();

            //For manual testing:

            //badRoms.Add(@"C:\Users\brent\Desktop\RomFetchTest\G.I. Joe - A Real American Hero (USA).zak");
            //badRoms.Add(@"C:\Users\brent\Desktop\RomFetchTest\Guardian Legend, The (USA).ted");
            //badRoms.Add(@"C:\Users\brent\Desktop\RomFetchTest\Legend, The (USA).delme");
            //badRoms.Add(@"C:\Users\brent\Desktop\RomFetchTest\Isolated Warrior (E).zip");

            //End Testing

            PopulateFormFields();
            LoadBadRomsToList();

            btnAddExtension.Enabled = false;
            btnCopyRom.Enabled = false;
            btnExtractRom.Enabled = false;
            btnIgnoreFileType.Enabled = false;
            btnIgnoreFile.Enabled = false;
        }

        private void PopulateFormFields()
        {
            foreach (var item in Config.Instance.CoreList) { cmboCore.Items.Add(item); }
            foreach (var item in Config.Instance.RomDirectorySystemAlias) { cmboSystem.Items.Add(item.Key); }
        }

        private void LoadBadRomsToList()
        {
            listUnknownRoms.Items.Clear();
            foreach (var g in badRoms) { listUnknownRoms.Items.Add(g); }
        }

        private void listUnknownRoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            cueCheck = false;
            filePath = listUnknownRoms.SelectedItem.ToString();   
            fileName = Path.GetFileNameWithoutExtension(filePath);
            extension = Path.GetExtension(filePath);

            listIndex = listUnknownRoms.SelectedIndex;
            
            btnAddExtension.Enabled = true;
            btnCopyRom.Enabled = true;
            btnExtractRom.Enabled = true;
            btnIgnoreFileType.Enabled = true;
            btnIgnoreFile.Enabled = true;
            
            switch (extension)
            {
                case ".iso":
                    btnAddExtension.Enabled = false;
                    btnIgnoreFileType.Enabled = false;
                    btnExtractRom.Enabled = false;
                    break;

                case ".zip":
                    btnAddExtension.Enabled = false;
                    btnIgnoreFileType.Enabled = false;
                    break;

                case ".bin":
                    btnAddExtension.Enabled = false;
                    btnIgnoreFileType.Enabled = false;
                    btnExtractRom.Enabled = false;
                    break;

                default:
                    btnAddExtension.Enabled = true;
                    btnIgnoreFileType.Enabled = true;
                    btnExtractRom.Enabled = true;
                    break;
            }
        }
        #endregion

        #region Form Events    

        private async void btnCopyRom_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmboSystem.Text == "" || cmboCore.Text == "")
                {
                    MetroMessageBox.Show(this, "Please select a valid target system and/or core.", "Missing Configuration Detail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {

                    string sysDir = Config.Instance.RomDirectorySystemAlias[cmboSystem.Text];
                   

                   



                    //Refactor with image formats, switch statements, and async copying



                    if (cmboSystem.Text == ".ps2")
                    {
                        await Task.Run(() => CopyFileOnly(sysDir, filePath)); 
                        listUnknownRoms.Items.RemoveAt(listIndex);
                        ResetForm();
                    }
                    else
                    {
                        if (extension == ".cue")
                        {
                            await Task.Run(() => CopyFileOnly(sysDir, filePath));
                            listUnknownRoms.Items.RemoveAt(listIndex);
                            ResetForm();
                        }
                        else
                        {
                            foreach (string r in badRoms)
                            {
                                string file = Path.GetFileName(r);
                                string ext = Path.GetExtension(r);
                                int badRomIndex = badRoms.IndexOf(r);

                                if (file == fileName && ext == ".cue")
                                {
                                    cueCheck = true;
                                    badRoms.RemoveAt(badRomIndex);
                                    break;
                                }
                            }
                            if (cueCheck == false)
                            {
                                if (MessageBox.Show("Selected file doesn't appear to have an accompanying cue sheet. Would you like to create one?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    //FileController.CreateCueSheet(filePath, sysDir);
                                    await Task.Run(() => CopyFileOnly(sysDir, filePath));
                                    listUnknownRoms.Items.RemoveAt(listIndex);
                                    ResetForm();
                                }
                                else
                                {
                                    await Task.Run(() => CopyFileOnly(sysDir, filePath));
                                   
                                    listUnknownRoms.Items.RemoveAt(listIndex);
                                    ResetForm();
                                }
                            }
                            else
                            {
                                await Task.Run(() => CopyFileOnly(sysDir, filePath));
                                listUnknownRoms.Items.RemoveAt(listIndex);
                                ResetForm();
                                //Cuesheet is in list, dont create new list
                                //Need to also check local directory
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogManager.UpdateLogFile("[ManualCopy]: Encountered an error while attempting to copy a file: " + ex);
            }
        }

        private async void btnAddExtension_Click(object sender, EventArgs e)
        {
            try
            {
                string sysDir = Config.Instance.RomDirectorySystemAlias[cmboSystem.Text];
                string core = cmboCore.Text;
                

                if (cmboSystem.Text == "" || cmboCore.Text == "")
                {
                    MetroMessageBox.Show(this, "Please select a valid target system and/or core.", "Missing Configuration Detail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    if (extension == ".iso" || extension == ".bin")
                    {
                        MetroMessageBox.Show(this, "Adding a disc image format as a valid extension will break functionality. Skipping file.", "Woops", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else
                    {
                        await Task.Run(() => CopyFileAndAddExtension(filePath));                        
                        listUnknownRoms.Items.RemoveAt(listIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                LogManager.UpdateLogFile("[ManualCopy]: Encountered an error adding an extension: " + ex);
            }
        }

        private void btnFixExtension_Click(object sender, EventArgs e)
        {
            //Current iteration of this method will modify the file extension based on common file formats
            //string system = cmboSystem.Text;
            //string extension = "";

            //switch (system)
            //{
            //    case "snes":
            //        extension = "smc";
            //        break;

            //    case "gb":
            //        extension = "gb";
            //        break;

            //    case "nes":
            //        extension = "nes";
            //        break;

            //    case "gba":
            //        extension = "gba";
            //        break;

            //    case "gen":
            //        extension = "gen";
            //        break;

            //    case "n64":
            //        extension = "n64";
            //        break;

            //    case "pce":
            //        extension = "pce";
            //        break;

            //    case "psx":
            //        extension = "iso";
            //        break;

            //    case "ps2":
            //        extension = "iso";
            //        break;

            //    default:

            //        break;
            //}
        }

        private void btnIgnoreFile_Click(object sender, EventArgs e)
        {
                listUnknownRoms.Items.Remove(fileName);
        }

        private void btnIgnoreFileType_Click(object sender, EventArgs e)
        {
            try
            {
                Config.Instance.IgnoreExtensions.Add(extension);
                ConfigManager.WriteConfigToFile();

                CheckListForIgnoredExtensions();
                RemoveIgnoredExtensionsFromCopyList();
                LoadBadRomsToList();
            }
            catch (Exception ex)
            {
                LogManager.UpdateLogFile("[ManualCopy]: Encountered an error trying to add extension to the ignore list: " + ex);
            }
        }

        private async void btnExtractRom_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmboSystem.Text == "" || listUnknownRoms.SelectedItem == null)
                {
                    MetroMessageBox.Show(this, "Please select a valid target system and/or core.", "Missing Configuration Detail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    fileName = Path.GetFileNameWithoutExtension(listUnknownRoms.SelectedItem.ToString());                    
                    string sysDir = Config.Instance.RomDirectorySystemAlias[cmboSystem.Text];
                    string extractPath = Config.Instance.RomDirectory + sysDir;
                    
                    string response = await Task<string>.Run(() => ExtractAndCopyZipFile(filePath, extractPath));

                    MetroMessageBox.Show(this, response, "Extraction Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    listUnknownRoms.Items.Remove(filePath);
                }
            }
            catch (Exception ex)
            {
                LogManager.UpdateLogFile("[ManualCopy]: Extract() Threw an Exception: " + ex);
            }            
        }

        private string ExtractAndCopyZipFile(string zipPath, string extractPath)
        {
            try
            {
                using (ZipArchive archive = ZipFile.OpenRead(zipPath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        entry.ExtractToFile(Path.Combine(extractPath, entry.FullName), true);
                    }
                }

                return fileName + " was extracted to " + extractPath;
            }
            catch (Exception ex)
            {
                LogManager.UpdateLogFile("[ManualCopy]: Could not extract archvie file to destination: " + ex);
                return "Could not extract archvie file to destination. Please check the log file for more information.";
            }

        }

        private void cmboSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selection = cmboSystem.SelectedItem.ToString();

            //if (selection == "ps2")
            //{
            //    cmboCore.Text = "N/A";
            //}
            //else
            //{
            //    //string core = ParseController.FetchDefaultCore(selection, ListController.ExtensionConfiguration);

            //    cmboCore.Text = core;
            //}
        }

        #endregion

        #region Class Methods

        public static void CopyFileAndAddExtension(string filePath)
        {


            string extension = Path.GetExtension(filePath);
            string fileName = Path.GetFileName(filePath);
            string romDirectory = Config.Instance.ExtensionDirectoryMappings[extension];
            string installPath = Config.Instance.RomDirectory + romDirectory + "\\" + fileName;


            Config.Instance.ValidExtensions.Add(extension);
            ConfigManager.WriteConfigToFile();

            System.IO.File.Copy(filePath, installPath, true);



            LogManager.UpdateLogFile("[ManualCopy]: New file extension " + extension + " added to list.");
            LogManager.UpdateLogFile("[ManualCopy]: File " + filePath + " copied to " + romDirectory + " directory");
        }

        public static void CopyFileOnly(string systemPath, string filePath)
        {

            string targetPath = Config.Instance.RomDirectory + systemPath + "\\" + Path.GetFileName(filePath);
            System.IO.File.Copy(filePath, targetPath, true);

            LogManager.UpdateLogFile("[ManualCopy]: File " + filePath + " copied to " + systemPath + " directory");
        }

        private void CheckListForIgnoredExtensions()
        {
            string ext;

            foreach (var g in badRoms)
            {
                ext = Path.GetExtension(g);

                if (Config.Instance.IgnoreExtensions.Contains(ext))
                {
                    removeList.Add(g);
                }
            }
        }

        private void RemoveIgnoredExtensionsFromCopyList()
        {
            foreach (var g in removeList)
            {
                badRoms.Remove(g);
            }
        }

        private void ResetForm()
        {
            btnAddExtension.Enabled = true;
            btnCopyRom.Enabled = true;
            btnExtractRom.Enabled = true;
            btnIgnoreFileType.Enabled = true;
            btnIgnoreFile.Enabled = true;

            cmboCore.Text = "";
            cmboSystem.Text = "";
        }


       

        #endregion


    }
}
