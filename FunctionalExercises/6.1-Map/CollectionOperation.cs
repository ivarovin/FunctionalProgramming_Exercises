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

        public static IDictionary<K, R> Map<K, R, T>(this IDictionary<K, T> d, Func<T, R> opt)
        {
            var result = new Dictionary<K, R>();

            foreach (var item in d)
            {
                result.Add(item.Key, opt(item.Value));
            }

            return result;
        }
    }
}