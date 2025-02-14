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
		/// ��ȡ�������еĽ���ʵ������ֹ�����ظ���
		/// </summary>
		/// <returns>�������Ѿ������У��򷵻ضԸý��̵����ã����򷵻�null</returns>
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
		/// �������ѱ��򿪣�������չʾ����ǰ��
		/// </summary>
		/// <param name="instance">��ǰ����ʵ��</param>
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