using System;
using System.Threading;

namespace Lessons.First.ExecutionWays
{
    public static class ThreadWay
    {
        internal static void ExecuteJob(Action job)
        {
            Console.WriteLine(nameof(ThreadWay));
            var thread = new Thread(() => job());
            thread.Start();
            thread.Join();
        }
    }
}