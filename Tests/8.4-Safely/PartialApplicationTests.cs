using FluentAssertions;

namespace IMoreno.FunctionalExercises.PartialApplication.Tests;

public class PartialApplicationTests
{
    public int RemainderOf(int dividend, int divisor) => dividend % divisor;

    [Fact]
    public void Calculate_remainder_of_division()
    {
        RemainderOf(dividend: 10, divisor: 2).Should().Be(0);
        RemainderOf(dividend: 11, divisor: 2).Should().Be(1);
        RemainderOf(dividend: 8, divisor: 3).Should().Be(2);
    }
}