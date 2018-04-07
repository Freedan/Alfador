using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfador
{
    class RomManager
    {
        private static List<string> ExternalRomList;
        private static List<string> InternalRomList;
        private static List<string> InternalExternalDiffList;
        private static List<string> QueriedRomList;
        private static List<string> QueriedRomListFullPath;
        private static List<string> ValidRomType;
        private static List<string> InvalidRomType;

        private static List<string> ValidCopyList { get; set; }
        private static List<string> InvalidCopyList { get; set; }        

        private static string fileName;
        private static string fileExtension;
        private static string fileDirectory;
        private static string filePath;
        

        public static void RunImportLogic(string path)
        {
            FetchNonLibraryRomList(path);
            FetchLibraryRomList();
            FetchInternalExternalDiffList();
            ValidateRomFilesInDiffList();
            UpdateDiffListWithFullPathInfo();
        }

        public static List<string> FetchValidCopyList()
        {
            return ValidCopyList;
        }

        public static List<string> FetchInvalidCopyList()
        {
            return InvalidCopyList;
        }

        public static void FetchNonLibraryRomList(string path)
        {
            //This method populates two lists in the ListController class
            //Because of later matching logic, we need two lists for comparison purposes
            //One list (UserGamesFileOnly) contains a list of the user-selected ROM file names
            //The second (UserGameFullPath) contains a list of the user-selected ROM files with full path information
            //First we need to start fresh by clearing the lists

            ExternalRomList = new List<string>();
            QueriedRomList = new List<string>();
            QueriedRomListFullPath = new List<string>();
            //ListController.UserGamesFileOnly.Clear();
            //ListController.UserGamesFullPath.Clear();

            string userDirectoryPath = path;
            //string fileName;
            //string extension;
            bool badFile = false;

            //Let's grab a list of all the files the user has selected
            var NonLibraryRomList = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

            foreach (string g in NonLibraryRomList)
            {
                //Now we need to loop through the above list and identify any files with invalid extensions
                //(as determined by our IgnoreExtensionList). Also don't forget to reset the badFile flag on each iteration.
                badFile = false;

                fileName = Path.GetFileNameWithoutExtension(g);
                fileExtension = Path.GetExtension(g);




                if (Config.Instance.IgnoreExtensions.Contains(fileExtension))
                {
                    badFile = true;
                }

                if (!badFile)
                {
                    QueriedRomList.Add(fileName + fileExtension);
                    QueriedRomListFullPath.Add(g);
                }
            }
        }

        public static void FetchLibraryRomList()
        {
            InternalRomList = new List<string>();

            string path = Config.Instance.InstallDirectory + @"\roms";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var libraryRomList = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

            foreach (string g in libraryRomList)
            {
                fileExtension = Path.GetExtension(g);

                if (fileExtension != ".srm")
                {
                    if (fileExtension != ".state")
                    {
                        fileName = Path.GetFileNameWithoutExtension(g);
                        InternalRomList.Add(fileName + fileExtension);
                    }
                }
            }
        }

        public static void FetchInternalExternalDiffList()
        {
            InternalExternalDiffList = new List<string>();
            InternalExternalDiffList = QueriedRomList.Except(InternalRomList).ToList();
        }

        public static void ValidateRomFilesInDiffList()
        {
            InvalidRomType = new List<string>();
            ValidRomType = new List<string>();
            
            foreach (string g in InternalExternalDiffList)
            {
                fileExtension = Path.GetExtension(g);
                

                if (Config.Instance.ValidExtensions.Contains(fileExtension))
                {
                    ValidRomType.Add(g);
                }
                else
                {
                    InvalidRomType.Add(g);
                }     
            }
        }

        public static void UpdateDiffListWithFullPathInfo()
        {
            ValidCopyList = new List<string>();
            InvalidCopyList = new List<string>();
            
            

            foreach (var g in QueriedRomListFullPath)
            {
                fileDirectory = Path.GetDirectoryName(g);
                fileName = Path.GetFileNameWithoutExtension(g);
                fileExtension = Path.GetExtension(g);

                foreach (var entry in ValidRomType)
                {
                    if (fileName + fileExtension == entry)
                    {
                        filePath = fileDirectory + "\\" + fileName + fileExtension;
                        ValidCopyList.Add(filePath);
                        break;
                    }
                }

                foreach (var entry in InvalidRomType)
                {
                    if (fileName + fileExtension == entry)
                    {
                        filePath = fileDirectory + fileName + fileExtension;
                        InvalidCopyList.Add(filePath);
                        break;
                    }
                }
            }
        }

        public static string FetchLocalInstallDirectory(string extension)
        {
            string path = "";
            string ext = extension.ToLower();

            if (Config.Instance.ExtensionDirectoryMappings.ContainsKey(ext))
            {
                //string dir = Config.Instance.ExtensionDirectoryMappings[ext];
                path = Config.Instance.InstallDirectory + "\\roms" + Config.Instance.ExtensionDirectoryMappings[ext];
            }

            //foreach (var e in Config.Instance.ExtensionDirectoryMappings)
            //{
            //    string[] entries = e.Split('|');

            //    if (entries[0] == extension.ToLower())
            //    {
            //        path = Config.Instance.InstallDirectory + "\\roms\\" + entries[1];
            //        break;
            //    }
            //}
            return path;
        }

        public static void AddRomToLibrary(string file)
        {
            //Doing this in constructor breaks runtime when building the configuration. Needs research
            Rom rom = new Rom();

            string extension = Path.GetExtension(file);
            string parentDirectory = Config.Instance.ExtensionDirectoryMappings[extension];

            rom.Name = Path.GetFileNameWithoutExtension(file);
            rom.System = Config.Instance.RomDirectorySystemAlias[parentDirectory];
            rom.Core = Config.Instance.CoreMappings[extension];
            rom.Extension = extension;
            rom.ParentDirectory = parentDirectory;
            rom.FullPath = Path.GetDirectoryName(file);
            ////rom.SystemAlias = 
            rom.CommandString = rom.GenerateCommandString();

            Config.Instance.RomLibrary.Add(rom);
        }

        public static void CleanRomLibrary()
        {
            string fileName;
            var localRomList = Directory.EnumerateFiles(Config.Instance.RomDirectory, "*.*", SearchOption.AllDirectories);
            List<string> localList = new List<string>();
            List<string> configList = new List<string>();

            foreach (var item in localRomList)
            {
                fileName = Path.GetFileNameWithoutExtension(item);
                localList.Add(fileName);
            }            

            foreach (var rom in Config.Instance.RomLibrary) { configList.Add(rom.Name); }

            List<string> removeList = configList.Except(localList).ToList();

            foreach (var item in removeList)
            {
                var rom = Config.Instance.RomLibrary.SingleOrDefault(x => x.Name == item);
                Config.Instance.RomLibrary.Remove(rom);
            }

            ConfigManager.WriteConfigToFile();
        }
    }
}
