using Lessons.First.ExecutionWays;
using Lessons.First.Models;

namespace Lessons.First.Exercises
{
    public static class Exercise2
    {
        public static void Start()
        {
            ThreadWay.ExecuteJob(() => Job.ConsoleJob(true));
        }
    }
}
