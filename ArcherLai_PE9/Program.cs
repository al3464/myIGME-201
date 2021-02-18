using System;
using System.Timers;

namespace TimerAppConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var timer = new Timer();

            timer.Elapsed += TimerEventProcessor;
            timer.Interval = 5000;
            timer.Start();

            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q')
            {
            }
        }

        private static void TimerEventProcessor(object myObject, EventArgs myEventArgs)
        {
            Console.WriteLine("Time Elapsed...");
        }
    }
}