using FluentAssertions;
using IMoreno.FunctionalExercises.ToOption;

namespace IMoreno.FunctionalExercises.QueryPattern.Tests;

public class QueryPatternTests
{
    [Fact]
    public void Implement_select_for_either()
    {
        Either<string, int> doc = 1;
        
        var result = from x in doc select x * 2;
        
        result.Match
        (
            _ => Assert.True(false),
            i => i.Should().Be(2)
        );
    }
}