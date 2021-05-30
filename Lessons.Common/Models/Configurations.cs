using System;
using System.Collections.Generic;

namespace Lessons.Common.Models
{
    public record BaseConfiguration(string Name);

    public sealed record LessonConfiguration : BaseConfiguration
    {
        public IReadOnlyCollection<ExerciseConfiguration> ExerciseConfigurations { get; init; }
        public LessonConfiguration(string name, IReadOnlyCollection<ExerciseConfiguration> exerciseConfigurations) : base(name)
        {
            ExerciseConfigurations = exerciseConfigurations;
        }
    }

    public sealed record ExerciseConfiguration : BaseConfiguration
    {
        public Action Exercise { get; init; }
        public ExerciseConfiguration(string name, Action exercise) : base(name)
        {
            Exercise = exercise;
        }
    }
}