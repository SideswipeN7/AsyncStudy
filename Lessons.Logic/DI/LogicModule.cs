using System.Collections.Generic;
using System.Linq;
using Autofac;
using Lessons.Common.Models;
using Lessons.Logic.Interfaces;
using Lessons.Runner.Interfaces;

namespace Lessons.Logic.DI
{
    public class LogicModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.Register(c =>
            {
                var runner = c.Resolve<IRunner<LessonConfiguration>>();
                var configurations = c.Resolve<IEnumerable<LessonConfiguration>>();

                return new Application(runner, configurations.ToList());
            }).As<IApplication>();
        }
    }
}