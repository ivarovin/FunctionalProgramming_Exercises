using FluentAssertions;
using IMoreno.FunctionalExercises.ToOption;

namespace IMoreno.FunctionalExercises.ApplyEverything.Tests;

public class ApplyEverythingTests
{
    [Fact]
    public void Apply_either_function()
    {
        Func<int, int, Either<string, int>> sum = (int x, int y) => x + y;

        var fromAdult = sum.Apply(18);

        fromAdult(20).Match
        (
            error => 0,
            result => result
        ).Should().Be(38);
    }
}