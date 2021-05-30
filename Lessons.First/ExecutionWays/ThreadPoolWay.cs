using System;
using System.Threading;

namespace Lessons.First.ExecutionWays
{
    public static class ThreadPoolWay
    {
        internal static void ExecuteJob(IThreadPoolWorkItem jobWorkItem)
        {
            Console.WriteLine(nameof(ThreadPoolWay));
            var thread = ThreadPool.UnsafeQueueUserWorkItem(jobWorkItem, true);
        }
    }
}