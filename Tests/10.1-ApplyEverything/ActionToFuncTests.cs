using FluentAssertions;

namespace IMoreno.FunctionalExercises.ApplyEverything.Tests;

public class ActionToFuncTests
{
    [Fact]
    public void Convert_action_to_unit_func()
    {
        var result = 0;
        Action action = () => result++;

        action.ToFunc()().Should().BeOfType<Unit>();
        result.Should().Be(1);
    }
}