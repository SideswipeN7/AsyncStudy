namespace Lessons.Runner.Models
{
    public sealed record Range(int Start, int End)
    {
        public static Range CreateFromLength(int length) => new(1, length);
    }
}