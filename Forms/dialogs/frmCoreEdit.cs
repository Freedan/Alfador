using Alfador.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfador.Forms
{
    public partial class frmCoreEdit : Form
    {
        public frmCoreEdit()
        {
            InitializeComponent();
        }

        private void frmCoreEdit_Load(object sender, EventArgs e)
        {
            LoadCoreList();
            LoadSystemList();
        }

        private void LoadSystemList()
        {
            cmboSystem.Items.Clear();
            string path = Config.Instance.InstallDirectory + @"\roms\";
            string pathName;
            var directoryList = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);

            foreach (var e in directoryList)
            {
                pathName = Path.GetFileName(e);
                cmboSystem.Items.Add(pathName);
            }
        }

        private void LoadCoreList()
        {
            cmboCore.Items.Clear();
            string path = Config.Instance.InstallDirectory + @"\retroarch\cores\";
            string fileName;
            var coreList = Directory.EnumerateFiles(path);

            foreach (var e in coreList)
            {
                fileName = Path.GetFileName(e);
                cmboCore.Items.Add(fileName);
            }
        }

        private void btnApplyCore_Click(object sender, EventArgs e)
        {
            if (cmboCore.Text == "" || cmboSystem.Text == "")
            {
                MessageBox.Show("Missing a core and/or system entry");
            }
            else
            {
                string oldExtension = "";
                bool checkIfExtensionExists = false;
                string systemDirectory = cmboSystem.Text;
                string core = cmboCore.Text;
                string extension = txtExtension.Text;
                string entry = extension + "|" + systemDirectory + "|" + core;

                //var query = ListController.ExtensionConfiguration.Where(a => a.Contains(extension));

                //foreach (var l in ListController.ExtensionConfiguration)
                //{
                //    string[] entries = l.Split('|');

                //    if (entries[0] == extension)
                //    {
                //        oldExtension = entries[0] + "|" + entries[1] + "|" + entries[2];
                //        checkIfExtensionExists = true;
                //        break;
                //    }
                //}

                if (checkIfExtensionExists)
                {
                    //Need to match on extension only

                    ModifyExtensionSetting(oldExtension, entry);
                    LogManager.UpdateLogFile("[RetroConfig]: " + oldExtension + " has been modified to " + entry);
                }
                else
                {
                    LogManager.UpdateLogFile("[RetroConfig]: " + entry + " added to extension_config.dat.");
                    //ListController.AddEntryToListFile("extension_config.dat", entry, ListController.ExtensionConfiguration);
                }
                this.Close();
                //LoadExtensionList();
                //txtExtension.Clear();
                //cmboCore.SelectedIndex = -1;
            }
        }
        private void ModifyExtensionSetting(string oldEntry, string newEntry)
        {

            //var query = ListController.ExtensionConfiguration.Where(a => a.Contains(entry));
            //string match = query.SingleOrDefault();
            ////ListController.ExtensionConfiguration.Remove(oldEntry);
            ////ListController.ExtensionConfiguration.Add(newEntry);
            ////ListController.WriteListToFile("extension_config.dat", ListController.ExtensionConfiguration);
        }

        private void frmCoreEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmRetroArchConfig"] != null)
            {
                (Application.OpenForms["frmRetroArchConfig"] as frmRetroArchConfig).LoadExtensionList();
            }
        }
    }
}

