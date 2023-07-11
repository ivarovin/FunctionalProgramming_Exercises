namespace IMoreno.FunctionalExercises.ToOption;

public class Either<L, R>
{
    readonly L left;
    readonly R right;
    readonly bool onLeftRail;

    public Either(L left)
    {
        onLeftRail = true;
        this.left = left;
    }

    public Either(R right) => this.right = right;

    public T Match<T>(Func<L, T> left, Func<R, T> right)
        => onLeftRail ? left(this.left) : right(this.right);

    public static implicit operator Either<L, R>(L left) => new(left);
    public static implicit operator Either<L, R>(R right) => new(right);
}