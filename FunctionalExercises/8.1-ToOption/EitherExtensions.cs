using static IMoreno.FunctionalExercises.Optional.OptionType;
using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.ToOption;

public static class EitherExtensions
{
    public static Option<R> ToOption<L, R>(this Either<L, R> either)
        => either.Match<Option<R>>
        (
            left: value => None,
            right: value => value
        );
}