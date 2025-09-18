using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicThreading
{
    public class MyThreadClass
    {
        public static void Thread1(string threadName)
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = threadName;

            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {

                string message = "";

                if (threadName == "Thread A")
                    message = $"Step{loopCount}: Downloading file chunk {loopCount}";
                else if (threadName == "Thread B")
                    message = $"Step{loopCount}: Processing data batch {loopCount}";

                Console.WriteLine("[" + thread.Name + "] " + message);
               

                Thread.Sleep(1500);
            }
        }
    }
}
