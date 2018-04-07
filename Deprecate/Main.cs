using System;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//using XInputDotNetPure;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Econ2015
{
    public partial class frmMain : Form
    {
        //public static string InstallDirectory = Path.GetDirectoryName(Application.ExecutablePath);
        //public static string RetroVersion;

        public frmMain()
        {
            InitializeComponent();
        }



        //        private void frmMain_Load(object sender, EventArgs e)
        //        {



        //            //ListDirectory(treeRoms, Config.Instance.RomDirectory);
        //            //lblVersion.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();

        //            //ListController.LoadListIntoMemory(list: ListController.FavoriteGameList, file: "favorites.dat");
        //            //ListController.LoadListIntoMemory(list: ListController.IgnoreExtensionList, file: "ignore_extensions.dat");
        //            //ListController.LoadListIntoMemory(list: ListController.RecentGameList, file: "recent.dat");
        //            //ListController.LoadListIntoMemory(list: ListController.ExtensionConfiguration, file: "extension_config.dat");
        //            //ListController.LoadListIntoMemory(list: ListController.EconConfiguration, file: "econ_config.dat");
        //            //ListController.LoadListIntoMemory(list: ListController.CoreList, file: "cores.dat");

        //            //RetroVersion = FetchRetroArchVersion();

        //            UpdateRecentMenuList();
        //            //UpdateFavoritesMenuList();
        //        }

        //        private void btnPlay_Click(object sender, EventArgs e)
        //        {
        //            //CheckForBiosFiles();
        //            //try
        //            //{
        //            //    string treePath = Regex.Replace(treeRoms.SelectedNode.ToString(), "TreeNode: ", "");
        //            //    string treeNode = Regex.Replace(treeRoms.SelectedNode.Parent.ToString(), "TreeNode: ", "");
        //            //    string filePath = Config.InstallDirectory + "\\roms\\" + treeNode + "\\" + treePath;

        //            //    RomController rom = new RomController(filePath);
        //            //    WindowsController.CallCommandLine(rom.GenerateLaunchString());

        //            //    //PS2 Launch
        //            //    //if (rom.Extension == "ps2")
        //            //    //{
        //            //    //    LaunchPS2FromCommandLine(rom.FullFilePath);
        //            //    //    AddRecentGameToList(rom.FullFilePath);
        //            //    //}
        //            //    //else
        //            //    //{
        //            //    //    LaunchFromCommandLine(rom.FullFilePath, rom.Extension);
        //            //    //    AddRecentGameToList(rom.FullFilePath);
        //            //    //}

        //            //}
        //            //catch (FileNotFoundException Ex)
        //            //{
        //            //    LogController.UpdateLogFile("[Main]: There was a problem finding the file: " + Ex);
        //            //}
        //            //catch (NullReferenceException)
        //            //{
        //            //    //MessageBox.Show("Please select a ROM from the list.");
        //            //}
        //            //catch (Win32Exception Ex)
        //            //{
        //            //    LogController.UpdateLogFile("[Main]: There was a problem finding the file: " + Ex);
        //            //}
        //        }







        //        private void CheckForBiosFiles()
        //        {
        //            //string retroArchBiosPath = Config.Instance.InstallDirectory + @"\retroarch\system";
        //            //var biosCheck = Directory.EnumerateFiles(retroArchBiosPath, "*.*", SearchOption.AllDirectories);


        //        }

        //        #region Form Events
        //        //private void mnuLogFile_Click(object sender, EventArgs e)
        //        //{
        //        //    if (System.Windows.Forms.Application.OpenForms["frmLog"] == null)
        //        //    {
        //        //        Form frmLog = new forms.frmLog();
        //        //        frmLog.Show();
        //        //    }
        //        //}

        //        private void mnuRetroArchConfig_Click(object sender, EventArgs e)
        //        {
        //            //Form frmRetroArchConfig = new forms.frmRetroArchConfig();
        //            //frmRetroArchConfig.ShowDialog();
        //        }

        //        //private void mnuClearLogFile_Click(object sender, EventArgs e)
        //        //{
        //        //    ListController.ClearConfigurationFile("\\econ.log", LogController.LogEntries);

        //        //    if (System.Windows.Forms.Application.OpenForms["frmLog"] != null)
        //        //    {
        //        //        (Application.OpenForms["frmLog"] as frmLog).LoadLogViewer();
        //        //    }
        //        //}

        //        private void mnuManageLibrary_Click(object sender, EventArgs e)
        //        {
        //            //Form frmManageRomLibrary = new forms.frmRomLibrary();
        //            //frmManageRomLibrary.ShowDialog();
        //        }

        //        #endregion

        //        #region Form Methods
        //        //private static string FetchRetroArchVersion()
        //        //{
        //        //    string ver = "";

        //        //    var retroArch = from config in ListController.EconConfiguration
        //        //                    where config.Contains("retroarch_compile_version")
        //        //                    select config;

        //        //    foreach (var config in retroArch)
        //        //    {
        //        //        ver = config.ToString();
        //        //    }
        //        //    if (ver == "")
        //        //    {
        //        //        return ver = "x86";
        //        //    }
        //        //    else
        //        //    {
        //        //        string[] configString = ver.Split('=');
        //        //        ver = configString[1].Replace("\"", "");
        //        //        return ver = ver.Replace(" ", "");
        //        //    }
        //        //}

        //        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //        {
        //            #region Escape Key
        //            if (keyData == Keys.Escape)
        //            {
        //                this.Close();
        //            }
        //            #endregion

        //            return base.ProcessCmdKey(ref msg, keyData);
        //        }

        //        //private void LaunchPS2FromCommandLine(string romPath)
        //        //{
        //        //    //Refactor to accomodate version change
        //        //    string execute = "\"" + "\"" + InstallDirectory + "\\pcsx2\\pcsx2-r5875.exe\" --nogui --fullscreen --fullboot " + "\"" + romPath + "\"" + "\""; 
        //        //    WindowsController.CallCommandLine(execute);
        //        //}
        //        //private void LaunchFromCommandLine(string romPath, string extension) //change to extension
        //        //{
        //        //    string core = ParseController.FetchDefaultCore(extension, ListController.ExtensionConfiguration);
        //        //    string execute = "\"" + "\"" + InstallDirectory + "\\retroarch\\retroarch.exe\" -f -L " + "\"" + InstallDirectory + @"\retroarch\cores\" + core + "\" " + "\"" + romPath + "\"" + "\" >> retro.log 2>&1";
        //        //    WindowsController.CallCommandLine(execute);
        //        //}

        //        public void ListDirectory(TreeView treeView, string path)
        //        {
        //            treeView.Nodes.Clear();
        //            var rootDirectoryInfo = new DirectoryInfo(path);
        //            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        //        }

        //        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        //        {
        //            var directoryNode = new TreeNode(directoryInfo.Name);
        //            string extension;

        //            try
        //            {
        //                foreach (var directory in directoryInfo.GetDirectories())
        //                    directoryNode.Nodes.Add(CreateDirectoryNode(directory));
        //                foreach (var file in directoryInfo.GetFiles())
        //                {
        //                    //extension = ParseController.FetchFileExtensionWithoutPeriod(file.ToString());

        //                    ////Filter excluded extensions here
        //                    //if (extension == "srm" || extension == "state" || extension == "bin")
        //                    //{
        //                    //    //Do nuffin
        //                    //}
        //                    //else
        //                    //{
        //                    //    directoryNode.Nodes.Add(new TreeNode(file.Name));
        //                    //}
        //                }
        //            }
        //            catch (Exception Ex)
        //            {
        //                //LogManager.UpdateLogFile("[Main]: Could not load the tree view: " + Ex);
        //            }

        //            return directoryNode;
        //        }

        //        public void RefreshRomTreeList()
        //        {
        //            //ListDirectory(treeRoms, Config.Instance.InstallDirectory + @"\roms\");
        //        }

        //        #endregion

        //        #region Favorites Menu

        //        private void AddFavoriteGameToList(object sender, EventArgs e)
        //        {
        //            //try
        //            //{
        //            //    string treePath = Regex.Replace(treeRoms.SelectedNode.ToString(), "TreeNode: ", "");
        //            //    string treeNode = Regex.Replace(treeRoms.SelectedNode.Parent.ToString(), "TreeNode: ", "");
        //            //    string filePath = Config.Instance.InstallDirectory + "\\roms\\" + treeNode + "\\" + treePath;

        //            //    RomController rom = new RomController(filePath);

        //            //    bool entryExistsCheck = ListController.ListSearchForBooleanMatch(ListController.FavoriteGameList, rom.FullFilePath);
        //            //    bool invalidFileCheck = CheckForInvalidExtension(filePath);

        //            //    if (invalidFileCheck || entryExistsCheck)
        //            //    {
        //            //        //Item is already on the favorite list, do nothing or isnt valid.
        //            //    }
        //            //    else
        //            //    {
        //            //        ListController.AddEntryToListFile(file: "favorites.dat", entry: rom.FullFilePath, list: ListController.FavoriteGameList);
        //            //    }

        //            //    //UpdateFavoritesMenuList();
        //            //}
        //            //catch (Exception)
        //            //{

        //            //}
        //        }

        //        private bool CheckForInvalidExtension(string file)
        //        {
        //            bool invalidCheck = false;
        //            string fileCheck = Path.GetExtension(file);

        //            if (fileCheck.Contains("."))
        //            {
        //                invalidCheck = false;
        //            }
        //            else
        //            {
        //                invalidCheck = true;
        //            }
        //            return invalidCheck;
        //        }

        //        //private void UpdateFavoritesMenuList()
        //        //{
        //        //    mnuFavorites.DropDownItems.Clear();
        //        //    foreach (var r in ListController.FavoriteGameList)
        //        //    {
        //        //        ToolStripMenuItem a = new ToolStripMenuItem(r, null, favoriteItem_Click);
        //        //        mnuFavorites.DropDownItems.Add(a);
        //        //    }
        //        //}

        //        //private void mnuClearFavoritesList_Click(object sender, EventArgs e)
        //        //{
        //        //    ListController.ClearConfigurationFile("\\config\\favorites.dat", ListController.FavoriteGameList);
        //        //    UpdateFavoritesMenuList();
        //        //}

        //        private void favoriteItem_Click(object sender, EventArgs e)
        //        {
        //            //RomController rom = new RomController(sender.ToString());
        //            //WindowsController.CallCommandLine(rom.GenerateLaunchString());
        //            //LaunchFromCommandLine(rom.FullFilePath, rom.Extension);

        //        }

        //        #endregion

        //        #region Recent Menu

        //        private void AddRecentGameToList(string path)
        //        //{
        //        //    bool check = ListController.ListSearchForBooleanMatch(ListController.RecentGameList, path);

        //        //    if (check)
        //        //    {
        //        //        //ROM is already on the recent list, so don't do a darn thing
        //        //    }
        //        //    else
        //        //    {
        //        //        ListController.AddEntryToListFile(file: "recent.dat", entry: path, list: ListController.RecentGameList);
        //        //    }

        //        //    UpdateRecentMenuList();
        //        }

        //        private void UpdateRecentMenuList()
        //        {
        //            mnuRecent.DropDownItems.Clear();
        //            foreach (var r in ListController.RecentGameList)
        //            {
        //                ToolStripMenuItem a = new ToolStripMenuItem(r, null, recentItem_Click);
        //                mnuRecent.DropDownItems.Add(a);
        //            }
        //        }

        //        private void mnuClearRecentList_Click(object sender, EventArgs e)
        //        {
        //            ListController.ClearConfigurationFile("\\config\\recent.dat", ListController.RecentGameList);
        //            UpdateRecentMenuList();
        //        }

        //        private void recentItem_Click(object sender, EventArgs e)
        //        {
        //            RomController rom = new RomController(sender.ToString());
        //            WindowsController.CallCommandLine(rom.GenerateLaunchString());
        //            //LaunchFromCommandLine(rom.FullFilePath, rom.Extension);
        //        }

        //        #endregion









        //        //Nothing but dirty testing below.......


        //        private void PollController()
        //        {
        //            //Launch This when launching psx rom
        //            while (true)
        //            {

        //                //GamePadState state = GamePad.GetState(PlayerIndex.One);

        //                //if (state.Triggers.Left > 0 && state.Triggers.Right > 0)
        //                //{
        //                //    //Determine button combo to change disk
        //                //    //In Retroarch config Eject, Next Disk, Previous disk to keystrokes
        //                //    //Run keystrokes here with pauses
        //                //    MessageBox.Show("Button was pressed");
        //                //    Thread.Sleep(1000);
        //                //}
        //                //Console.WriteLine("IsConnected {0} Packet #{1}", state.IsConnected, state.PacketNumber);
        //                //Console.WriteLine("\tTriggers {0} {1}", state.Triggers.Left, state.Triggers.Right);
        //                //Console.WriteLine("\tD-Pad {0} {1} {2} {3}", state.DPad.Up, state.DPad.Right, state.DPad.Down, state.DPad.Left);
        //                //Console.WriteLine("\tButtons Start {0} Back {1} LeftStick {2} RightStick {3} LeftShoulder {4} RightShoulder {5} Guide {6} A {7} B {8} X {9} Y {10}",
        //                //    state.Buttons.Start, state.Buttons.Back, state.Buttons.LeftStick, state.Buttons.RightStick, state.Buttons.LeftShoulder, state.Buttons.RightShoulder,
        //                //    state.Buttons.Guide, state.Buttons.A, state.Buttons.B, state.Buttons.X, state.Buttons.Y);
        //                //Console.WriteLine("\tSticks Left {0} {1} Right {2} {3}", state.ThumbSticks.Left.X, state.ThumbSticks.Left.Y, state.ThumbSticks.Right.X, state.ThumbSticks.Right.Y);
        //                //GamePad.SetVibration(PlayerIndex.One, state.Triggers.Left, state.Triggers.Right);
        //                //Thread.Sleep(16);
        //            }
        //        }

        //        private void mnuTestMethod_Click(object sender, EventArgs e)
        //       {



        //            //TestConfig eConfig = JsonConvert.DeserializeObject<TestConfig>(File.ReadAllText(@"C:\Users\brent\Source\Workspaces\Econ2015\Econ2015\Econ2015\resources\config.json"));

        //            //TestConfig econfig = new TestConfig();
        //            //using (StreamReader file = File.OpenText(@"C:\Users\brent\Source\Workspaces\Econ2015\Econ2015\Econ2015\resources\config.json"))
        //            //{
        //            //    JsonSerializer serializer = new JsonSerializer();
        //            //    econfig = (TestConfig)serializer.Deserialize(file, typeof(TestConfig));
        //            //}

        //            //Config.InstallDirectory = econfig.InstallDirectory;

        //            //foreach (var item in econfig.IgnoreExtensions)
        //            //{
        //            //    Config.IgnoreExtensions.Add(item);
        //            //}


        //            //JavaScriptSerializer ser = new JavaScriptSerializer();
        //            //Rom r1 = ser.Deserialize<Rom>(JSONstring);

        //            //txtIndex.Text = r1.index.ToString();
        //            //txtFileName.Text = r1.name;
        //            //txtAlias.Text = r1.systemAlias;
        //            //txtCommandString.Text = r1.commandString;
        //            //txtExtension.Text = r1.extension;
        //            //txtCore.Text = r1.core;
        //            //txtRomFolder.Text = r1.directory;





        //            frmMetro frmMetro = new frmMetro();
        //            frmMetro.Show();
        //            //string source = @"C:\Users\Brent\Desktop\test_roms\snes\Der Langrisser.SMC";

        //            //string fileName = ParseController.FetchFileName(source);
        //            //string extension = ParseController.FetchFileExtensionWithPeriod(source);
        //            //string directory = ParseController.FetchDirectory(source);

        //            //string sourceFile = directory + fileName + "." + extension;
        //            //string installFile = ParseController.FetchLocalInstallDirectory(extension) + "\\" + fileName + extension;

        //            ////label1.Text = fileName;
        //            //System.IO.File.Copy(sourceFile, installFile, true);

        //            //FileController.CopyFilesAndChangeExtension(@"C:\Users\Brent\Desktop\Wiz.ps2", "iso");
        //            //ListController.InvalidCopyList.Add(@"C:\Users\Brent\Desktop\Wizardry Tale of the Forsaken Land.iso");
        //            //ListController.InvalidCopyList.Add(@"C:\Users\Brent\Desktop\Wizardry Tale of the Forsaken Land.zip");
        //            //frmManualCopy frm = new frmManualCopy();
        //            //frm.Show();

        //            //ListController.InvalidCopyList.Add(@"C:\Users\Brent\Desktop\Wizardry Tale of the Forsaken Land.zip");

        //            //ListController.InvalidCopyList.Add("Final Fantasy IX(USA)(Disc 1)(v1.1).bin");
        //            //ListController.InvalidCopyList.Add("Final Fantasy IX(USA)(Disc 2)(v1.1).bin");         

        //            //ListController.InvalidCopyList.Add("Final Fantasy IX(USA)(Disc 1)(v1.1).cue");
        //            //ListController.InvalidCopyList.Add("Final Fantasy IX(USA)(Disc 2)(v1.1).cue");

        //            //ListController.InvalidCopyList.Add("Random ISO Buster.iso");
        //            //ListController.InvalidCopyList.Add("Really Sweet Game.bin");
        //            //ListController.InvalidCopyList.Add("Collection of Awesomness.m3u");

        //            //frmManualCopy frmCopy = new frmManualCopy();
        //            //frmCopy.ShowDialog();            
        //        }




    }
}
