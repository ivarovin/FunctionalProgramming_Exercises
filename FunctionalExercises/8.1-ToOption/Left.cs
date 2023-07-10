namespace IMoreno.FunctionalExercises.ToOption;

public class Left<T>
{
    readonly T value;

    Left(T value)
    {
        this.value = value;
    }
    
    public static implicit operator T (Left<T> left) => left.value;
    public static implicit operator Left<T> (T value) => new(value);
    public static implicit operator Either<T, object>(Left<T> left) => new(left.value);
}