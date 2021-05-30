using System.Collections.Generic;
using Lessons.Common.Models;

namespace Lessons.Runner.Interfaces
{
    public interface IRunner<T> where T : BaseConfiguration
    {
        void Initialize(IReadOnlyCollection<T> configurations);
        void Run();
    }
}