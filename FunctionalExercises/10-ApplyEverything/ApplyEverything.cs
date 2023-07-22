using IMoreno.FunctionalExercises.ToOption;

namespace IMoreno.FunctionalExercises.ApplyEverything;

public static class ApplyEverything
{
    public static Func<T2, Either<L, R>> Apply<T1,T2, L, R>(this Func<T1,T2, Either<L, R>> f, T1 t1)
        => t2 => f(t1, t2);
}