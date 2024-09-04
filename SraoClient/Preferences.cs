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
        private readonly string cachePath;
        private string Server { get; set; }

        public Preferences()
        {
            try
            {
                cachePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.sraoclient";
            }
            catch { return; }
        }

        public void Load()
        {
            try
            {
                using (StreamReader sr = new StreamReader(cachePath))
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
                using (TextWriter tw = new StreamWriter(cachePath))
                {
                    tw.WriteLine(Server);
                }
            }
            catch { return; }
        }
    }
}
