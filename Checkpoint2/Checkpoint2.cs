using System;
using System.Diagnostics;
using System.Threading;

namespace Checkpoint2
{
    class Program
    {

        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Please press 1 to start the timer");
            Console.WriteLine("Please press 2 to stop the timer");
            Console.WriteLine("Please press 3 to exit the timer");
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            do
            {
                string read = Console.ReadLine();
                switch (read)
                {
                    case "1":
                        stopWatch.Start();
                        Console.WriteLine("hello!!");
                        continue;
                    case "2":
                        stopWatch.Stop();
                        Console.WriteLine("Time is stopped at " + elapsedTime);
                        Console.WriteLine("Press 3 if you want to completely stop");
                        continue;
                    default:
                        Console.WriteLine("Try again");
                        continue;
                }
            }
            while(Console.ReadLine() == "3");
            Console.WriteLine("Thanks for playing!");
        }
    }
}
