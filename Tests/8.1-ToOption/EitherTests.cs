using FluentAssertions;

namespace IMoreno.FunctionalExercises.ToOption.Tests;

public class EitherTests
{
    [Fact]
    public void Convert_left_value_to_either_implicitly()
    {
        Either<string, int> left = "test";

        left.Match
        (
            left: value => true,
            right: value => false
        ).Should().BeTrue();
    }
    
    [Fact]
    public void Convert_right_value_to_either_implicitly()
    {
        Either<string, int> left = 10;

        left.Match
        (
            left: value => false,
            right: value => true
        ).Should().BeTrue();
    }
}