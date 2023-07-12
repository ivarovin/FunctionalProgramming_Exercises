using FluentAssertions;
using IMoreno.FunctionalExercises.BindAndReturn;
using IMoreno.FunctionalExercises.Optional;
using static IMoreno.FunctionalExercises.Optional.Option<int>;

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

    [Fact]
    public void Chain_options_with_either_in_same_workflow()
    {
        Either<string, int> GetPaid(int savings) => savings + 600;
        Option<int> PayFood(int savings) => savings - 100;
        Option<int> PayRent(int savings) => savings - 1000;

        Some(1000)
            .Bind(GetPaid)
            .Bind(PayFood)
            .Bind(PayRent)
            .Match
            (
                none: () => 0,
                some: value => value
            )
            .Should().Be(500);
    }
}