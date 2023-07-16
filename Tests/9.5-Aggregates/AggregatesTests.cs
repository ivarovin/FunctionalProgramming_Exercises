using FluentAssertions;

namespace IMoreno.FunctionalExercises.Aggregates.Tests;

public class AggregatesTests
{
    [Fact]
    public void Map_in_terms_of_aggregate()
    {
        new List<int> { 1 }.AMap(x => x * 2)
            .Should()
            .HaveCount(1)
            .And.Contain(2);
    }
}