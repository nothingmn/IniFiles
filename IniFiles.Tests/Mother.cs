using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IniFiles.Tests
{
    public class Mother
    {
        static string sampleIni = "[Configuration]\r\na=b\nb=c\r\n\r\n[Test]\r\nshowsomething=true";

        public static string EmptyIniFile()
        {
            return System.IO.Path.GetTempFileName();
        }
        public static string PopulatedIniFile()
        {
            string filename = EmptyIniFile();
            System.IO.File.WriteAllText(filename, sampleIni);
            return filename;
        }
    }
}
