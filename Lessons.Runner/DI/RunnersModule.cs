using Autofac;
using Lessons.Common.Models;
using Lessons.Runner.Interfaces;

namespace Lessons.Runner.DI
{
    public class RunnersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<ExerciseRunner>().As<IRunner<ExerciseConfiguration>>();
            builder.RegisterType<LessonRunner>().As<IRunner<LessonConfiguration>>();
        }
    }
}