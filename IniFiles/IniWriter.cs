using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IniFiles
{
    public class IniWriter
    {
        /// <summary>
        /// Write keys.
        /// </summary>
        /// <param name="iniFile">The ini file.</param>
        /// <param name="category">The category.</param>
        public static void WriteKey(string iniFile, string category, string key, string value)
        {
            string returnString = new string(' ', 32768);
            Interop.WritePrivateProfileString(category, key, value, iniFile);
        }
    }
}
