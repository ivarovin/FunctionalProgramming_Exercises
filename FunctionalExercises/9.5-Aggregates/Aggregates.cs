namespace IMoreno.FunctionalExercises.Aggregates;

public static class Aggregates
{
    public static IEnumerable<R> AMap<T, R>(this IEnumerable<T> collection, Func<T, R> f)
        => collection.Aggregate(new List<R>(), (acc, x) =>
        {
            acc.Add(f(x));
            return acc;
        });

    public static IEnumerable<R> ABind<T, R>(this IEnumerable<T> collection, Func<T, IEnumerable<R>> f)
        => collection.Aggregate(new List<R>(), (acc, x) =>
        {
            acc.AddRange(f(x));
            return acc;
        });

    public static IEnumerable<T> AWhere<T>(this IEnumerable<T> collection, Func<T, bool> f)
        => collection.Aggregate(new List<T>(), (acc, x) =>
        {
            if (f(x)) acc.Add(x);
            return acc;
        });
}