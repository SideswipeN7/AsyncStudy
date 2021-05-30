using System;
using System.Collections.Generic;
using System.Linq;
using Lessons.Common.Models;
using Lessons.Runner.Abstraction;
using Lessons.Runner.Interfaces;

namespace Lessons.Runner
{
    internal sealed class LessonRunner : AbstractRunner<LessonConfiguration>
    {
        private readonly IRunner<ExerciseConfiguration> runner;

        public LessonRunner(IRunner<ExerciseConfiguration> runner)
        {
            this.runner = runner;
        }

        protected override void WriteSynopsis()
        {
            Console.WriteLine($"Async Lessons");
            Console.WriteLine("Please write number of what lesson you want to execute");
        }

        protected override void WriteOption(int rangeOptionIndex)
        {
            Console.WriteLine($"{rangeOptionIndex}) {getLessonName(rangeOptionIndex)}");
        }

        private string getLessonName(int rangeOptionIndex)
        {
            //TODO: EXTRACT METHOD WITH MAGIC NUMBER
            var name = configurations.ElementAt(rangeOptionIndex - 1).Name;
            if (!string.IsNullOrWhiteSpace(name))
            {
                return name;
            }

            return $"Lesson {rangeOptionIndex}";
        }

        protected override void ExecuteOnSelectedItem()
        {
            var exerciseConfigurations = GetSelectedLessonExercises();
            runner.Initialize(exerciseConfigurations);
            runner.Run();
        }

        private IReadOnlyCollection<ExerciseConfiguration> GetSelectedLessonExercises()
        {
            return configurations.ElementAt(selectedActionIndex).ExerciseConfigurations;
        }
    }
}