using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SraoClient
{
    public class Preferences
    {
        public string CachePath;
        public string Server { get; set; }

        public Preferences()
        {
            try
            {
                CachePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.sraoclient";
            }
            catch { return; }
        }

        public void Load()
        {
            try
            {
                using (StreamReader sr = new StreamReader(CachePath))
                {
                    Server = sr.ReadLine();
                }
            }
            catch { return; }
        }

        public void Save()
        {
            try
            {
                using (TextWriter tw = new StreamWriter(CachePath))
                {
                    tw.WriteLine(Server);
                }
            }
            catch { return; }
        }
    }
}
