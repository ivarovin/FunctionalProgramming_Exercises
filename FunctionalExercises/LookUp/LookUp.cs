﻿using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.LookUp
{
    public static class CollectionSearch
    {
        public static Option<T> LookUp<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return new None<T>();
        }
    }
}