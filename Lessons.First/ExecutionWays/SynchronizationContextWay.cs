using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lessons.First.ExecutionWays
{
    public static class SynchronizationContextWay
    {
        internal static void ExecuteJob(Action action)
        {
            Console.WriteLine(nameof(SynchronizationContextWay));

            var current = SynchronizationContext.Current;
            Task.Run(() =>
            {
                current.Post((_) => action(), default);
            });
        }
    }
}