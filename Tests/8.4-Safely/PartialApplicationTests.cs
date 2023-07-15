using FluentAssertions;
using FunctionalExercises._9._1_PartialApplication;

namespace IMoreno.FunctionalExercises.PartialApplication.Tests;

public class PartialApplicationTests
{
    Func<int, int, int> RemainderOf => (divisor, dividend) => dividend % divisor;

    [Fact]
    public void Calculate_remainder_of_division()
    {
        RemainderOf(2, 10).Should().Be(0);
        RemainderOf(2, 11).Should().Be(1);
        RemainderOf(3, 8).Should().Be(2);
    }

    [Fact]
    public void Apply_division()
    {
        var remainderOf5 = RemainderOf.Apply(5);

        remainderOf5(3).Should().Be(3);
        remainderOf5(7).Should().Be(2);
        remainderOf5(15).Should().Be(0);
    }
}