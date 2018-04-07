using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfador
{
    public class Config
    {

        public static readonly Config Instance = new Config();
        private Config() {

            ValidExtensions = new List<string>();
            IgnoreExtensions = new List<string>();
            CoreList = new List<string>();
            FavoriteGameList = new List<string>();
            RecentGameList = new List<string>();

            CoreMappings = new Dictionary<string, string>();
            ExtensionDirectoryMappings = new Dictionary<string, string>();
            RomDirectorySystemAlias = new Dictionary<string, string>();
            RomLibrary = new List<Rom>();

        }

        public string InstallDirectory { get; set; }
        public string RomDirectory { get; set; }
        public string ConfigDirectory { get; set; }
        public bool RetroArchIntegrated { get; set; }

        public List<string> ValidExtensions { get; set; }
        public List<string> IgnoreExtensions { get; set; }
        public List<string> CoreList { get; set; }
        public List<string> FavoriteGameList { get; set; }
        public List<string> RecentGameList { get; set; }

        public Dictionary<string, string> CoreMappings { get; set; }
        public Dictionary<string, string> ExtensionDirectoryMappings { get; set; }
        public Dictionary<string, string> RomDirectorySystemAlias { get; set; }
        public List<Rom> RomLibrary { get; set; }





    }
}
