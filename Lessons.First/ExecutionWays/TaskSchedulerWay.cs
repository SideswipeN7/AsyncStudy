using System;
using System.Threading.Tasks;

namespace Lessons.First.ExecutionWays
{
    public static class TaskSchedulerWay
    {
        public static void ExecuteJob(Action action)
        {
            Console.WriteLine(nameof(TaskSchedulerWay));
            Task.Factory.StartNew(action, default, default, TaskScheduler.Current);
        }
    }
}