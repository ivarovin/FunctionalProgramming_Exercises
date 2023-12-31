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
    
    [Fact]
    public void Bind_in_terms_of_aggregate()
    {
        new List<int> { 1 }.ABind(x => new List<int>{x * 2})
            .Should()
            .HaveCount(1)
            .And.Contain(2);
    }

    [Fact]
    public void Where_in_terms_of_aggregate()
    {
        new List<int> { 1, 2 }.AWhere(x => x % 2 == 0)
            .Should()
            .HaveCount(1)
            .And.Contain(2);
    }
}