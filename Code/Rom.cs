using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfador
{
    public class Rom
    {
        public string Name { get; set; }        
        public string System { get; set; }
        public string Core { get; set; }
        public string Extension { get; set; }
        public string ParentDirectory { get; set; }
        public string SystemAlias { get; set; }
        public string CommandString { get; set; }
        public string FullPath { get; set; }


        public string GenerateCommandString()
        {
            string execute;

            switch (ParentDirectory)
            {
                case "ps2":
                    execute = "\"" + "\"" + Config.Instance.InstallDirectory + "\\pcsx2\\pcsx2-r5875.exe\" --nogui --fullscreen --fullboot " + "\"" + FullPath + "\"" + "\"";
                    break;

                default:
                    //If the file isn't in an image format, create launch string based on core.
                    Core = Config.Instance.CoreMappings[Extension];
                    execute = "\"" + "\"" + Config.Instance.InstallDirectory + "\\retroarch\\retroarch.exe\" -f -L " + "\"" + Config.Instance.InstallDirectory + @"\retroarch\cores\" + Core + "\" " + "\"" + FullPath + "\"" + "\" >> retro.log 2>&1";


                    break;
            }
            return execute;
        }



    }
}
