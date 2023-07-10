namespace IMoreno.FunctionalExercises.ToOption;

public class Either<L, R>
{
    readonly L left;

    public Either(L left) => this.left = left;

    public T Match<T>(Func<L, T> left, Func<R, T> right)
        => left(this.left);

    public static implicit operator Either<L, R>(L left) => new(left);
}