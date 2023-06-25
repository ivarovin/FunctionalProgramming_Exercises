using FluentAssertions;

namespace IMoreno.FunctionalExercises.Map.Tests
{
    public class MapTests
    {
        int Duplicate(int x) => x * 2;

        [Fact]
        public void Map_returns_collection_with_applied_function()
        {
            new HashSet<int>() { 1 }.Map(Duplicate)
                .Should()
                .HaveCount(1).And
                .Contain(2);
        }

        [Fact]
        public void Map_applies_function_to_every_item_of_set()
        {
            new HashSet<int>() { 1, 2, 3 }.Map(Duplicate)
                .Should()
                .BeEquivalentTo(new HashSet<int> { 2, 4, 6 });
        }
    }
}