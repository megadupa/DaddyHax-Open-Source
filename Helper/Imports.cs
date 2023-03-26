using Memory.Protect;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Main.Helper
{
    public class Imports
    {
        public static bool IsKeyPressed(int nVirtKey)
        {
            return Convert.ToBoolean(GetKeyState(nVirtKey) & KEY_PRESSED);
        }

        [DllImport("USER32.dll")]
        public static extern short GetKeyState(int nVirtKey);
        public const int KEY_PRESSED = 0x8000;

        public static string StringX(string text, int number) => new StringBuilder(text.Length * number).Insert(0, text, number).ToString();

        public static CustomMemory mem = new CustomMemory();

        public static WebClient wc = new WebClient();

        public static string isRank { get; set; }

        public static bool isAccess { get; set; }

        public static bool RunAdmin()
        {
            var principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
