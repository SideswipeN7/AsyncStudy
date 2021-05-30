using System;
using System.Collections.Generic;
using Lessons.Common.Models;
using Lessons.Logic.Interfaces;
using Lessons.Runner.Interfaces;

namespace Lessons.Logic
{
    public class Application : IApplication
    {
        private readonly IRunner<LessonConfiguration> runner;
        private readonly IReadOnlyCollection<LessonConfiguration> lessonConfigurations;

        public Application(IRunner<LessonConfiguration> runner, IReadOnlyCollection<LessonConfiguration> lessonConfigurations)
        {
            this.runner = runner;
            this.lessonConfigurations = lessonConfigurations;
        }

        public void Run()
        {
            WriteTitle();
            ExecuteRunner();
        }

        private static void WriteTitle() => Console.WriteLine("App to better learn Async and Multithread");

        private void ExecuteRunner()
        {
            runner.Initialize(lessonConfigurations);
            runner.Run();
        }
    }
}