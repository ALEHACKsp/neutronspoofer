using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace DebuggerCheck
{
	// Token: 0x02000004 RID: 4
    class DebugCheck
	{
		// Token: 0x0600000A RID: 10
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

		// Token: 0x0600000B RID: 11 RVA: 0x00002850 File Offset: 0x00000A50
		public static void Debug()
		{
			bool flag = false;
			DebugCheck.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag);
			Console.Write("Debugger Detected : " + flag.ToString() + "\n");
			Thread.Sleep(2000);
			Console.Clear();
		}
	}
}
