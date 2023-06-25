using IMoreno.FunctionalExercises.Optional;

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
    }
}
