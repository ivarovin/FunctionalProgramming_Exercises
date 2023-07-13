using FluentAssertions;
using IMoreno.FunctionalExercises.BindAndReturn;
using IMoreno.FunctionalExercises.Optional;
using IMoreno.FunctionalExercises.ToOption;

namespace IMoreno.FunctionalExercises.ChainOptionAndEither.Tests;

public class ChainOptionAndEitherTests
{
    [Fact]
    public void Chain_options_with_either_in_same_workflow()
    {
        Either<string, int> GetPaid(int savings) => savings + 600;
        Option<int> PayFood(int savings) => savings - 100;
        Option<int> PayRent(int savings) => savings - 1000;

        Option<int>.Some(1000)
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