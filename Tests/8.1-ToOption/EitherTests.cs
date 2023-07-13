using FluentAssertions;
using IMoreno.FunctionalExercises.Optional;

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

    [Fact]
    public void Convert_either_to_option()
    {
        ((Either<string, int>)"error").ToOption().Should().BeOfType<None<int>>();
        ((Either<string, int>)5).ToOption().Should().BeOfType<Some<int>>();
    }

    [Fact]
    public void Convert_option_to_either()
    {
        new Some<int>(1).ToEither<string, int>(() => "error")
            .Match
            (
                left: value => false,
                right: value => true
            )
            .Should().BeTrue();
    }

    [Fact]
    public void Convert_none_to_either()
    {
        new None<int>().ToEither<string, int>(() => "error")
            .Match
            (
                left: value => true,
                right: value => false
            )
            .Should().BeTrue();
    }
}