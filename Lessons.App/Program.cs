using Autofac;
using Lessons.App.DI;
using Lessons.Logic.Interfaces;

namespace Lessons.App
{
    public static class Program
    {
        public static void Main(string[] _)
        {
            var container = DIConfigurer.BuildContainer();
            var application = GetApplication(container);

            application.Run();
        }

        private static IApplication GetApplication(IContainer container) => container.Resolve<IApplication>();
    }
}