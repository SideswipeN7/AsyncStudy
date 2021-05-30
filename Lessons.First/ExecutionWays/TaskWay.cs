using System;
using System.Threading.Tasks;

namespace Lessons.First.ExecutionWays
{
    public static class TaskWay
    {
        internal static void ExecuteJob(Action action)
        {
            Console.WriteLine(nameof(TaskWay));
            var task = new Task(action);
            task.Start();
            //or
            //Task.Run(action);
        }
    }
}