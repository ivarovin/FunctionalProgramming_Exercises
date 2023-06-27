using static IMoreno.FunctionalExercises.Optional.OptionType;
using IMoreno.FunctionalExercises.Optional;
using System.Collections.Immutable;

namespace IMoreno.FunctionalExercises.BindAndReturn
{
    public static class MonadOperation
    {
        public static Option<R> Bind<T, R>(this Option<T> option, Func<T, Option<R>> op)
            => option.Match
            (
                none: () => None,
                some: value => op(value)
            );

        public static IEnumerable<R> Bind<T, R>(this IEnumerable<T> or, Func<T, IEnumerable<R>> op)
        {
            foreach (var item in or)
                foreach (var result in op(item))
                    yield return result;
        }

        public static IEnumerable<R> Map<T, R>(this IEnumerable<T> or, Func<T, R> op)
        {
            foreach (var item in or)
                yield return op(item);
        }

        public static Option<T> Where<T>(this Option<T> opt, Func<T, bool> predicate)
            => opt.Match
            (
                () => None,
                value => predicate(value) ? opt : None
            );

        public static Option<T> Some<T>(T value) => (Option<T>)value;
        public static IEnumerable<T> List<T>(params T[] elements) => elements.ToImmutableList();
    }
}
