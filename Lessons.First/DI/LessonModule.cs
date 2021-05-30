using Autofac;
using Lessons.Common.Models;
using Lessons.First.Exercises;

namespace Lessons.First.DI
{
    public class LessonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.Register(_ => GetConfiguration()).As<LessonConfiguration>();
        }

        public static LessonConfiguration GetConfiguration()
        {
            var exerciseConfigurations = new ExerciseConfiguration[]
           {
               new ("Threads and Tasks", Exercise1.Start),
               new ("Thread name", Exercise2.Start),
               new("Infinite console", Exercise3.Start) ,
           };

            return new LessonConfiguration("MultiThread", exerciseConfigurations);
        }
    }
}