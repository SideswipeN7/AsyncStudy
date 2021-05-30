using System;
using System.Threading;

namespace Lessons.First.Models
{
    internal class Job : IThreadPoolWorkItem
    {
        public void Execute()
        {
            ConsoleJob();
        }

        public static void ConsoleJob(bool shouldDisplayThread = false)
        {
            if (shouldDisplayThread)
            {
                Console.WriteLine($"Current Thread: {Thread.CurrentThread}");
            }
            Console.WriteLine("*");
        }
    }
}