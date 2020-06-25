using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace Neutron_Loader
{
    class Kill
    {
        public static void Test()
        {


            WebClient webClient = new WebClient();
            string text = @"C:\Windows\IME\mappser111.exe";
            string text2 = @"C:\Windows\IME\serdsiall.sys";
            //string text3 = @"C:\Windows\IME\spoooooof.exe";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/708392657587535882/708858946777120828/spoofer.sys", text2);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/708392657587535882/708858981266751558/mapper_3.exe", text);

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text, text2);

            Thread.Sleep(1000);
            process.Close();
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
            process.StandardInput.WriteLine("REG ADD \"HKLM\\SOFTWARE\\Microsoft\\Windows" + "NT\\CurrentVersion /v InstallDate /t REG_SZ /d %random% /f");
            process.StandardInput.WriteLine("REG ADD \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName\\ /v ComputerName /t REG_SZ /d %PCNAME% Neutron-%random% /f");
            process.StandardInput.WriteLine("REG ADD \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\ /v Hostname / t REG_SZ / d %PCNAME% Neutron-%random% / f");
            process.StandardInput.WriteLine("REG ADD \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\ /v NV Hostname" + "/t REG_SZ /d %PCNAME% Neutron-%random% /f");
            process.StandardInput.WriteLine("REG ADD \"HKLM\\SOFTWARE\\Microsoft\\Windows" + "NT\\CurrentVersion /v ProductId /t REG_SZ /d %random%-%random%-%random%-%random% /f");

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
            process.StandardInput.WriteLine("REG ADD \"HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\IDConfigDB\\Hardware Profiles\\0001" + "/v HwProfileGuid /t REG_SZ /d {%Hex8%-%Hex1%-%Hex0%-%Hex1%-80%Hex10%} /f");
            process.StandardInput.WriteLine("RED ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography" + "/v MachineGuid /t REG_SZ /d %Hex8%-%Hex1%-%Hex0%-%Hex1%-80%Hex10% /f");
            Console.Clear();

            Console.Write(" [~] Added Registry Files ");
        }
        public static void Clean()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [~] Cleaning Traces\n");



            WebClient webClient = new WebClient();

            string text3 = @"C:\Windows\IME\xD.bat";

            webClient.DownloadFile("https://neutroncheats.xyz/test/xD.bat", text3);


            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(text3);
        }
        public static void Damn()
        {

            Thread thread = new Thread(new ThreadStart(Damn));
            Thread.Sleep(3000);
            thread.Start();
            foreach (var process in Process.GetProcessesByName("Taskmgr"))
            {

                Process processs = new Process();
                processs.StartInfo.FileName = "cmd.exe";
                processs.StartInfo.RedirectStandardInput = true;
                processs.StartInfo.RedirectStandardError = true;
                processs.StartInfo.RedirectStandardOutput = true;
                processs.StartInfo.UseShellExecute = false;
                processs.StartInfo.CreateNoWindow = true;
                processs.Start();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n [~] DEBUGGER TASKMGR IS OPEN");
                Console.ForegroundColor = ConsoleColor.Red;
                processs.StandardInput.WriteLine("taskkill /f /im Taskmgr.exe ");
                Thread.Sleep(2000);
                Process.GetCurrentProcess().Kill();



            }


            foreach (var process in Process.GetProcessesByName("ProcessHacker"))
            {

                Process processs = new Process();
                processs.StartInfo.FileName = "cmd.exe";
                processs.StartInfo.RedirectStandardInput = true;
                processs.StartInfo.RedirectStandardError = true;
                processs.StartInfo.RedirectStandardOutput = true;
                processs.StartInfo.UseShellExecute = false;
                processs.StartInfo.CreateNoWindow = true;
                processs.Start();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n [~] DEBUGGER ProcessHacker IS OPEN");
                Console.ForegroundColor = ConsoleColor.Red;
                processs.StandardInput.WriteLine("taskkill /f /im ProcessHacker.exe ");
                Thread.Sleep(2000);
                Process.GetCurrentProcess().Kill();

            }
        }
    }
}