using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IniFiles
{
    public class Interop
    {
        [DllImport("KERNEL32.DLL", EntryPoint = "GetPrivateProfileStringW",
    SetLastError = true,
    CharSet = CharSet.Unicode, ExactSpelling = true,
    CallingConvention = CallingConvention.StdCall)]
        internal static extern int GetPrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            string lpReturnString,
            int nSize,
            string lpFilename);

        [DllImport("KERNEL32.DLL", EntryPoint = "WritePrivateProfileStringW",
            SetLastError = true,
            CharSet = CharSet.Unicode, ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall)]
        internal static extern int WritePrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpString,
            string lpFilename);
    }
}
