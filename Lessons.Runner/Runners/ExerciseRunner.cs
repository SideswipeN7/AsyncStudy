using System;
using System.Linq;
using Lessons.Common.Models;
using Lessons.Runner.Abstraction;

namespace Lessons.Runner
{
    internal sealed class ExerciseRunner : AbstractRunner<ExerciseConfiguration>
    {
        protected override void WriteSynopsis()
        {
            Console.WriteLine("Please write number of what exercise you want to execute");
        }

        protected override void WriteOption(int rangeOptionIndex)
        {
            var exerciseConfig = configurations.ElementAt(RangeOptionIndexToCollectionIndex(rangeOptionIndex));
            Console.WriteLine($"{rangeOptionIndex}) Exercise - {exerciseConfig.Name}");
        }

        private static int RangeOptionIndexToCollectionIndex(int rangeOptionIndex) => rangeOptionIndex - 1;

        protected override void ExecuteOnSelectedItem()
        {
            var exerciseAction = GetSelectedExerciseAction();
            exerciseAction.Invoke();
        }

        private Action GetSelectedExerciseAction() => configurations.ElementAt(selectedActionIndex).Exercise;

    }
}