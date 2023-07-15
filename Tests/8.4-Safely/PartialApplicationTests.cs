using FluentAssertions;

namespace IMoreno.FunctionalExercises.PartialApplication.Tests;

public class PartialApplicationTests
{
    Func<int, int, int> RemainderOf => (dividend, divisor) => dividend % divisor;

    [Fact]
    public void Calculate_remainder_of_division()
    {
        RemainderOf(10, 2).Should().Be(0);
        RemainderOf(11, 2).Should().Be(1);
        RemainderOf(8, 3).Should().Be(2);
    }
}