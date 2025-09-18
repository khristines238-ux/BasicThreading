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
                Console.WriteLine("Name of Thread: " + thread.Name + "Process =" + loopCount);

                Thread.Sleep(1500);
            }
        }
    }
}
