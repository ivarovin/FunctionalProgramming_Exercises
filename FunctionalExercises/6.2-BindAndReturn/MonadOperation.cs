﻿using static IMoreno.FunctionalExercises.Optional.OptionType;
using IMoreno.FunctionalExercises.Optional;

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

        public static Option<T> Optionalize<T>(T value) => (Option<T>)value;
    }
}
