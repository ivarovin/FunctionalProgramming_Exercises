using static IMoreno.FunctionalExercises.Optional.OptionType;
using IMoreno.FunctionalExercises.Optional;
using System.Collections.Immutable;

namespace IMoreno.FunctionalExercises.BindAndReturn
{
    public static class MonadOperation
    {
        public static Option<R> Bind<T, R>(this Option<T> option, Func<T, Option<R>> op)
        {
            return option.Match
                (
                    none: () => None,
                    some: value => op(value)
                );
        }

        public static IEnumerable<R> Bind<T, R>(this IEnumerable<T> or, Func<T, IEnumerable<R>> op)
        {
            foreach (var item in or)
                foreach (var result in op(item))
                    yield return result;
        }

        public static Option<T> Optionalize<T>(T value) => (Option<T>)value;
        public static IEnumerable<T> List<T>(params T[] elements) => elements.ToImmutableList();
    }
}
