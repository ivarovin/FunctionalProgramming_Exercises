using FluentAssertions;

namespace IMoreno.FunctionalExercises.Map.Tests
{
    public class MapTests
    {
        [Fact]
        public void Map_returns_collection_with_applied_function()
        {
            int Duplicate(int x) => x * 2;

            new HashSet<int>() { 1 }.Map(Duplicate)
                .Should()
                .HaveCount(1).And
                .Contain(2);
        }
    }
}