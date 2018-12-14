using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Gestion_de_Stock_.ClassLayer
{
    class INIFile
    {

        private string filePath;

        public string FilePath
        {
            get { return this.filePath; }

            set { this.filePath = value; }
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
        string key,
        string val,
        string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
        string key,
        string def,
        StringBuilder retVal,
        int size,
        string filePath);

        public INIFile(string filePath)
        {
            this.filePath = filePath;
        }

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value.ToLower(), this.filePath);
        }

        public string Read(string section, string key)
        {
            StringBuilder SB = new StringBuilder(255);
            if (!File.Exists(this.filePath))
            {
                return null;
            }
            int i = GetPrivateProfileString(section, key, "", SB, 255, this.filePath);
            return SB.ToString();
        }

      
    }














    ////    Write INI:
    ////INIFile ini = new INIFile(pathsave);
    ////    ini.Write(Title, title_settings, your_settings);













    ////Read INI File:
    ////INIFile ini = new INIFile(pathfile);
    ////    ini.Read(Title, title_settings);
}
