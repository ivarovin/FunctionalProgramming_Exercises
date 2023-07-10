using FluentAssertions;

namespace IMoreno.FunctionalExercises.ToOption.Tests;

public class EitherTests
{
    [Fact]
    public void Converted_left_to_its_type()
    {
        ((Left<string>)"test").Should().BeOfType<Left<string>>();
    }
    
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
}