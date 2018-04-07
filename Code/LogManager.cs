using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfador
{
    public static class LogManager
    {
        private static string log = Config.Instance.InstallDirectory + @"\econ.log";
        public static List<string> LogEntries = new List<string>();

        public static List<string> LoadLogFile(string file)
        {
            StreamReader stream = new StreamReader(new FileStream(log, FileMode.OpenOrCreate, FileAccess.Read));
            List<string> logList = new List<string>();
            string line;

            while (stream.Peek() != -1)
            {
                line = stream.ReadLine();
                logList.Add(line);
            }

            stream.Close();
            return logList;
        }

        public static void UpdateLogFile(string activity)
        {
            StreamWriter stream = new StreamWriter(new FileStream(log, FileMode.Append, FileAccess.Write));
            stream.WriteLine(DateTime.Now.ToString("g") + ": " + activity);

            stream.Close();            
        }

        public static void ClearLogFile()
        {
            File.Delete(log);
            StreamWriter stream = new StreamWriter(new FileStream(log, FileMode.CreateNew, FileAccess.Write));
            LogEntries.Clear();

            stream.Close();
        }
    }
}
