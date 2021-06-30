using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    class StopwatchProgram
    {
        /// <summary>
        /// Stop watch program to find the time elapsed.
        /// </summary>
        public static void TimeElapsed()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(10000);
            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds,timeSpan.Milliseconds / 10); 
            Console.WriteLine("The Elapsed time is: "+elapsedTime);

           

        }
    }
}
