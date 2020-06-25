using DebuggerCheck;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Net;
using System.IO;
using Spoof;
using Microsoft.Win32;

namespace Neutron_Loader
{
	
	internal class menu
	{
		
		// Woah, big haxor found the LOADER. IM VERY IMPRESSED LMAOO.
		public static void Main()
		{
			string text3 = @"C:\Windows\IME\xD.bat";
			if (text3 == "C:\\Windows\\IME\\xD.bat")
			{
				File.Delete(text3);
			}
			else
			{

			}
			string update = $"{AppDomain.CurrentDomain.BaseDirectory}\\NeutronFreeLoader.exe";
			if (update == $"{AppDomain.CurrentDomain.BaseDirectory}\\NeutronFreeLoader.exe")
			{
				File.Delete(update);
			}
			else
			{

			}
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("Loading, Please wait.");
			Thread.Sleep(2000);
			Console.Clear();
			Console.Write("Loading...");
			Thread.Sleep(3000);
			Console.Clear();
			Thread.Sleep(3000);
			Console.Write("Loading..");
			Console.Clear();
			Thread.Sleep(3000);
			Console.Write("Loading.");
			Thread.Sleep(5000);


			Console.Write("[1] Load Spoofer\n");
			Console.Write("[2] Load Cleaner\n");
			Console.Write("[3] Load FiveM Spoofer\n");
			Console.Write("[4] Support \n");
			//Console.Write("[5] Selfbot\n");
			Console.Write("Choose a option! :  ");
			string str2 = Console.ReadLine();
			if (str2 == "1")
			{
				Spoofing.Lunar();
				Spoofing.Test1();
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("[~] Spoofing Hardware \n");
				Spoofing.mac();
				Helpers.SpoofInstallTime();
				Helpers.SpoofInstallDate();;
				Helpers.SpoofPCName();
				menu.Jesus();
				Thread.Sleep(1000);
				Console.Write("[~] Spoofing Mac \n");
				Thread.Sleep(3000);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("[+] HardWare And Mac Spoofed \n");
				Console.ReadLine();

			}
			
			if (str2 == "2")
			{
				Console.ForegroundColor = ConsoleColor.DarkBlue;
				Console.Write("[~] Cleaning System");
				Kill.Reg();
				Kill.Clean();
				Kill.Traces();
				Thread.Sleep(10000);
				Console.ForegroundColor = ConsoleColor.Green;
				//Console.Write("[~] System Cleaned");
				Console.ReadLine();
			}

			if (str2 == "4")
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write("[-] Oh, You are having trouble :( \n");
				Thread.Sleep(1000);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("[+] We've got you covered\n");
				Thread.Sleep(1000);
				Console.Write("[+] https://discord.gg/guM4TTD \n");
				Console.ReadLine();



			}
			if (str2 == "3")
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Fivem.fivem1();
				Fivem.fivem2();
				Thread.Sleep(3000);
				Console.Write("[+] Spoofed Fivem");
				Console.ReadLine();
			}

			//if (str2 == "5")
			//{

				//Console.Clear();
				//Console.ForegroundColor = ConsoleColor.Yellow;
				//Console.Write("[+] Downloading Selfbot\n");
				//Kill.Selfbot();
				//Thread.Sleep(1000);
				//Console.ForegroundColor = ConsoleColor.Green;
				//Console.Write("[+] Selfbot Downloaded Check C:\\Selfbot.rar\n");
				//Console.ReadLine();


			//}


				//	Thread.Sleep(1000);
				///Kill.Lunar();
				//Thread.Sleep(2000);
				//Console.Clear();
				//Console.ForegroundColor = ConsoleColor.Yellow;
				//Console.Write("Loading Spoofer.");
				//Thread.Sleep(1000);
				//Kill.Clean();
				//Spoofing.Test1();
				//Spoofing.mac();
				//Console.Clear();//if (str2 == "5")
			//{

				//Console.Clear();
				//Console.ForegroundColor = ConsoleColor.Yellow;
				//Console.Write("[+] Downloading Selfbot\n");
				//Kill.Selfbot();
				//Thread.Sleep(1000);
				//Console.ForegroundColor = ConsoleColor.Green;
				//Console.Write("[+] Selfbot Downloaded Check C:\\Selfbot.rar\n");
				//Console.ReadLine();


			//}
				//Console.Write("Loading Spoofer..");
				//Thread.Sleep(1000);
				//Kill.Traces();
				//Console.Clear();
				//Console.Write("Loading Spoofer...");

				//Thread.Sleep(1000);
				//Kill.Reg();
				//Console.Clear();
				//Console.ForegroundColor = ConsoleColor.Green;
				//Console.Write("Spoofer Loaded Successfully!");
				//Thread.Sleep(2000);
				//Console.Clear();
				//Console.ForegroundColor = ConsoleColor.DarkRed;
				//Console.Write("Have Fun!");
				//Thread.Sleep(2000);
				//Console.Clear();
				//Console.ForegroundColor = ConsoleColor.Yellow;

				//Console.Write("Made By Neutrons Dev Team!!!");

			}



		public static void Jesus()
		{
			String newHWID = Guid.NewGuid().ToString(); RegistryKey HWIDkey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001"); { HWIDkey.SetValue("HwProfileGUID", newHWID, RegistryValueKind.String); HWIDkey.Close(); }


		}
			
			public static void Tester()
		{
			int num = 10;
			char[] array = new char[62];
			array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
			RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
			byte[] array2 = new byte[num];
			randomNumberGenerator.GetNonZeroBytes(array2);
			StringBuilder stringBuilder = new StringBuilder(num);
			foreach (byte b in array2)
			{
				stringBuilder.Append(array[(int)b % (array.Length - 1)]);
			}
			StringBuilder stringBuilder2 = stringBuilder;
			Console.Title = (((stringBuilder2 != null) ? stringBuilder2.ToString() : null) ?? "");
			Thread thread = new Thread(new ThreadStart(menu.Tester));
			Thread.Sleep(1500);
			thread.Start();
		}
	}
}
