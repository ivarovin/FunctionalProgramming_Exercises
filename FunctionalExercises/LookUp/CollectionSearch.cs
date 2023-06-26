using static IMoreno.FunctionalExercises.Optional.OptionType;
using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.LookUp
{
    public static class CollectionSearch
    {
        public static Option<T> LookUp<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Any(predicate) ? collection.First(predicate) : None;
        }

        public static Option<T> LookUp<K, T>(this IDictionary<K, T> collection, K key)
        {
            return collection.TryGetValue(key, out var result) ? result : None;
        }
    }
}