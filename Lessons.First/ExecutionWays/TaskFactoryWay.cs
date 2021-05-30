using System;
using System.Threading.Tasks;

namespace Lessons.First.ExecutionWays
{
    internal static class TaskFactoryWay
    {
        internal static void ExecuteJob(Action action)
        {
            Console.WriteLine(nameof(TaskFactoryWay));
            var task = Task.Factory.StartNew(action);
            //or
            //var taskFactory = new TaskFactory();
            //taskFactory.StartNew(action);
        }
    }
}