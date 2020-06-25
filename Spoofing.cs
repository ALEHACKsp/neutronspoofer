using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Neutron_Loader
{
    class Spoofing
    {
        public static void mac()
        {


            WebClient webClient = new WebClient();
            string text2 = @"C:\Windows\IME\otay.bat";

            webClient.DownloadFile("https://neutroncheats.xyz/machanger.bat", text2);

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text2);
            Thread.Sleep(6000);
            process.Close();
            File.Delete(text2);

            Thread.Sleep(4000);

        }
        public static void Test1()
        {
            try
            {
                WebClient webClient = new WebClient();
                string text = "C:\\Windows\\IME\\mappser111.exe";
                string text2 = "C:\\Windows\\IME\\serdsiall.sys";
                webClient.DownloadFile("https://neutroncheats.xyz/test/spoofer.sys", text2);
                webClient.DownloadFile("https://neutroncheats.xyz/test/mapper_3.exe", text);
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
                Console.WriteLine("\nLoaded Driver");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nCould Not Exc Drivers Please Turn Off Your Windows Defender/AntiVirus.");
                Console.ReadLine();
            }
          
           
        }
        public static void Lunar()
        {
            try
            {
                // Dont Think Yall Are Cool Haxors That u Cracked a Free Spoofer
                Console.ForegroundColor = ConsoleColor.Green;
                //Console.Write(" [~] Cleaning Traces\n");
                WebClient webClient = new WebClient();
                string fileName = "C:\\Windows\\IME\\luner.bat";
                webClient.DownloadFile("https://neutroncheats.xyz/test/luner.bat", fileName);
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                //process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process = Process.Start(fileName);
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error Code 0x465 Could Not Download File (Please Contact Support)\n");
                Console.Write("Retrying.");
                Thread.Sleep(2000);
                Console.Write("Retrying..");
                Thread.Sleep(1000);
                Console.Write("Retrying..."); ;
                Lunar();

                //Environment.Exit(0);
            }
            
        }
        private static void retry()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error Code 0x136 Could Not Download File (Please Contact Support)\n");
            Console.Write("Retrying.");
            Thread.Sleep(2000);
            Console.Write("Retrying..");
            Thread.Sleep(1000);
            Console.Write("Retrying...");
        }
    }
}
