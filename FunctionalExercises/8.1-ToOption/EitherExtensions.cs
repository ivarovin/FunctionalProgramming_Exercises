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

    public static Either<L, R> ToEither<L, R>(this Option<R> opt, Func<L> ifNone)
        => opt.Match<R, Either<L, R>>
        (
            none: () => ifNone(),
            some: value => value
        );

    public static Either<L, RR> Select<L, R, RR>(this Either<L, R> either, Func<R, RR> f)
        => either.Match<Either<L, RR>>
        (
            left: value => value,
            right: value => f(value)
        );

    public static Either<L, R3> SelectMany<L, R1, R2, R3>(this Either<L, R1> either, Func<R1, Either<L, R2>> f,
        Func<R1, R2, R3> project)
    {
        return either.Match<Either<L, R3>>
        (
            left: value => value,
            right: t => f(t).Match<Either<L, R3>>
            (
                left: value => value,
                right: r => project(t, r)
            )
        );
    }
}