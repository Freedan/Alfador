using Alfador.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfador
{
    public class ConfigManager
    {

        public static void BuildConfiguration()
        {

            Config.Instance.InstallDirectory = Path.GetDirectoryName(Application.ExecutablePath);

            JsonConfig jConfig = new JsonConfig();

            string path = Config.Instance.InstallDirectory + @"\config.json";

            if (!File.Exists(path))
            {
                File.WriteAllBytes(path, Resources.config);
                LogManager.UpdateLogFile("[ConfigManager]: Could not locate config.json, restoring from default.");
            }

            using (StreamReader file = File.OpenText(Config.Instance.InstallDirectory + "\\config.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                jConfig = (JsonConfig)serializer.Deserialize(file, typeof(JsonConfig));
            }






            Config.Instance.RomDirectory = Config.Instance.InstallDirectory + @"\roms";
            Config.Instance.RetroArchIntegrated = jConfig.RetroArchIntegrated;


            foreach (var item in jConfig.CoreList)
            {
                Config.Instance.CoreList.Add(item);
            }

            foreach (var item in jConfig.IgnoreExtensions)
            {
                Config.Instance.IgnoreExtensions.Add(item);
            }

            foreach (var item in jConfig.ValidExtensions)
            {
                Config.Instance.ValidExtensions.Add(item);
            }

            foreach (KeyValuePair<string, string> entry in jConfig.CoreMappings)
            {
                Config.Instance.CoreMappings.Add(entry.Key, entry.Value);
            }

            foreach (KeyValuePair<string, string> entry in jConfig.ExtensionDirectoryMappings)
            {
                Config.Instance.ExtensionDirectoryMappings.Add(entry.Key, entry.Value);
            }

            foreach (KeyValuePair<string, string> entry in jConfig.RomDirectorySystemAlias)
            {
                Config.Instance.RomDirectorySystemAlias.Add(entry.Key, entry.Value);
            }
            foreach (var rom in jConfig.RomLibrary)
            {
                Config.Instance.RomLibrary.Add(rom);
            }
        }

        public static void UpdateConfiguration()
        {
            //TODO
        }



        public static void WriteConfigToFile()
        {
            //File.WriteAllText(@"C:\Users\brent\Source\Workspaces\Econ2015\Econ2015\Econ2015\resources\config.json", JsonConvert.SerializeObject(Config.Instance));
            File.WriteAllText(Config.Instance.InstallDirectory + "\\config.json", JsonConvert.SerializeObject(Config.Instance, Formatting.Indented));
        }
    }

    class JsonConfig
    {
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



