using System;
using System.Threading;

namespace HelloWorldMultiThreaded
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Start counting...");
			StartCounting();
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
			Console.WriteLine("Exiting...");
		}

		private static void StartCounting()
		{
			var thread = new Thread(() =>
			                        	{
											for(var x= 0 ; x < 10 ; x++)
											{
												Console.Write("{0}... ", x);
												Thread.Sleep(1000);
											}
			                        	});
			thread.IsBackground = true;
			thread.Start();
		}
	}
}
