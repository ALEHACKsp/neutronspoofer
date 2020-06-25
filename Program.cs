using System;
using System.Threading;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using DebuggerCheck;

namespace Neutron_Loader
{
    class Nigger
    {
        static void Main()
        {


            Kill.Damn();
            Tester();
            //DebugCheck.Debug();


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");

            Console.Write("           ███▄    █ ▓█████  █    ██ ▄▄▄█████▓ ██▀███   ▒█████   ███▄    █ \n");
            Console.Write("           ██ ▀█   █ ▓█   ▀  ██  ▓██▒▓  ██▒ ▓▒▓██ ▒ ██▒▒██▒  ██▒ ██ ▀█   █ \n");
            Console.Write("          ▓██  ▀█ ██▒▒███   ▓██  ▒██░▒ ▓██░ ▒░▓██ ░▄█ ▒▒██░  ██▒▓██  ▀█ ██▒\n");
            Console.Write("          ▓██▒  ▐▌██▒▒▓█  ▄ ▓▓█  ░██░░ ▓██▓ ░ ▒██▀▀█▄  ▒██   ██░▓██▒  ▐▌██▒\n");
            Console.Write("          ▒██░   ▓██░░▒████▒▒▒█████▓   ▒██▒ ░ ░██▓ ▒██▒░ ████▓▒░▒██░   ▓██░\n");
            Console.Write("          ░ ▒░   ▒ ▒ ░░ ▒░ ░░▒▓▒ ▒ ▒   ▒ ░░   ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░ ▒░   ▒ ▒ \n");
            Console.Write("          ░ ░░   ░ ▒░ ░ ░  ░░░▒░ ░ ░     ░      ░▒ ░ ▒░  ░ ▒ ▒░ ░ ░░   ░ ▒░\n");
            Console.Write("           ░   ░ ░    ░    ░░░ ░ ░   ░        ░░   ░ ░ ░ ░ ▒     ░   ░ ░ \n");
            Console.Write("                 ░    ░  ░   ░                 ░         ░ ░           ░ \n");
            Console.Write("               \n");
            Console.Write("               \n");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("WELCOME TO NEUTRON'S FREE SPOOFER!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Loading Spoofer.");
            Thread.Sleep(1000);
            Kill.Clean();
            Kill.Test();
            Console.Clear();
            Console.Write("Loading Spoofer..");
            Thread.Sleep(1000);
            Kill.Traces();
            Console.Clear();
            Console.Write("Loading Spoofer...");
            Thread.Sleep(1000);
            Kill.Reg();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Spoofer Loaded Successfully!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Have Fun!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Made by N.. + Charge.");


        }
        public static void Tester()
        {
            int size = 80;
            char[] chars = new char[62];
            string a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            chars = a.ToCharArray();

            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();

            byte[] data = new byte[size];
            crypto.GetNonZeroBytes(data);

            StringBuilder result = new StringBuilder(size);

            foreach (byte b in data)
                result.Append(chars[b % (chars.Length - 1)]);
            Console.Title = "" + result;
            Thread thread = new Thread(new ThreadStart(Tester));
            Thread.Sleep(1500);
            thread.Start();


        }
    }
}

