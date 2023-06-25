namespace IMoreno.FunctionalExercises.Map
{
    public static class CollectionOperation
    {
        public static IEnumerable<R> Map<T, R>(this ISet<T> set, Func<T, R> opt)
        {
            foreach (var item in set)
            {
                yield return opt(item);
            }
        }

        public static IEnumerable<KeyValuePair<K, R>> Map<K, R, T>(this IDictionary<K, T> d, Func<T, R> opt)
        {
            foreach (var item in d)
            {
                yield return new(item.Key, opt(item.Value));
            }
        }
    }
}