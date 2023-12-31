namespace IMoreno.FunctionalExercises.PartialApplication;

public static class PartialApplication
{
    public static Func<T2, R> Apply<T1, T2, R>(this Func<T1, T2, R> f, T1 t1)
        => t2 => f(t1, t2);

    public static Func<T2, T3, R> Apply<T1, T2, T3, R>(this Func<T1, T2, T3, R> f, T1 t1)
        => (t2, t3) => f(t1, t2, t3);

    public static Func<T1, R> ApplyR<T1, T2, R>(this Func<T1, T2, R> f, T2 t2)
        => t1 => f(t1, t2);

    public static Func<T1, T2, R> ApplyR<T1, T2, T3, R>(this Func<T1, T2, T3, R> f, T3 t3)
        => (t1, t2) => f(t1, t2, t3);
}