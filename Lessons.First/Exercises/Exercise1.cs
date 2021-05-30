using Lessons.First.ExecutionWays;
using Lessons.First.Models;

namespace Lessons.First.Exercises
{
    public static class Exercise1
    {
        public static void Start()
        {
            ThreadWay.ExecuteJob(() => Job.ConsoleJob());
            TaskWay.ExecuteJob(() => Job.ConsoleJob());
            TaskFactoryWay.ExecuteJob(() => Job.ConsoleJob());
            ThreadPoolWay.ExecuteJob(new Job());
            TaskSchedulerWay.ExecuteJob(() => Job.ConsoleJob());
            SynchronizationContextWay.ExecuteJob(() => Job.ConsoleJob());
        }
    }
}