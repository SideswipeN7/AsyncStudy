using Autofac;

namespace Lessons.App.DI
{
    internal sealed class DIConfigurer
    {
        internal static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            RegisterModules(builder);

            return builder.Build();
        }

        private static void RegisterModules(ContainerBuilder builder)
        {
            builder.RegisterAssemblyModules(new[]
            {
                typeof(Logic.DI.LogicModule).Assembly,
                typeof(First.DI.LessonModule).Assembly,
                typeof(Runner.DI.RunnersModule).Assembly,
            });
        }
    }
}