using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PingTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Chris' stupid App to ping stuff");

			{
				Process[] processes = Process.GetProcessesByName("cmd");
				foreach (var process in processes) {
					//process.Kill();

				}

				Console.WriteLine ("Enter an IP to Ping then press Enter");
				string hostname = " " + Console.ReadLine();
				Console.WriteLine ("Please Wait...");
				//string hostname = "google.com".PadLeft(11);
				ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + "ping" + hostname);
				Process proc = new Process();
				procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				procStartInfo.UseShellExecute = false;
				procStartInfo.RedirectStandardOutput = true;
				//procStartInfo.CreateNoWindow = true;
				proc.StartInfo = procStartInfo;
				proc.Start();
				string output2 = proc.StandardOutput.ReadToEnd();
				proc.WaitForExit();
				//Console.WriteLine (output2);

				// ... One or more digits.
				Match m = Regex.Match(output2, @"Reply");

				// ... Write value.
				if (m.Value =="Reply") Console.WriteLine("Ping was sucessful");
				else
					Console.WriteLine("Ping was not sucessful");
				//var process2 = Process.Start ("cmd.exe", @"/c ping 8.8.8.8");
				//process2.WaitForExit();
				//System.Threading.Thread.Sleep (5000);
				Console.WriteLine("Press enter to close...");
				Console.ReadLine();

			}

			{

			}
		}
	}
}


