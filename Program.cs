using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CSharp_Projects
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Process? instance = GetRunningInstance();
			if (instance is not null)
				HandleRunningInstance(instance);
			else
			{
				ApplicationConfiguration.Initialize();
				Application.Run(new StartMenu());
			}
		}

		/// <summary>
		/// 获取正在运行的进程实例，防止程序被重复打开
		/// </summary>
		/// <returns>若程序已经在运行，则返回对该进程的引用，否则返回null</returns>
		static Process? GetRunningInstance()
		{
			Process currentProcess = Process.GetCurrentProcess();
			Process[] processes = Process.GetProcessesByName(currentProcess.ProcessName);

			foreach (Process process in processes)
				if (process.Id != currentProcess.Id)
					return process;

			return null;
		}

		/// <summary>
		/// 若程序已被打开，将窗口展示在最前端
		/// </summary>
		/// <param name="instance">当前进程实例</param>
		static void HandleRunningInstance(Process instance)
		{
			ShowWindowAsync(instance.MainWindowHandle, 1);
			SetForegroundWindow(instance.MainWindowHandle);
		}

		[DllImport("User32.dll")]
		static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);

		[DllImport("User32.dll")]
		static extern bool SetForegroundWindow(IntPtr hWnd);
	}
}