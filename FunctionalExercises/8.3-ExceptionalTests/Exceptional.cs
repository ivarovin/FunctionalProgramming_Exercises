using IMoreno.FunctionalExercises.ToOption;

namespace IMoreno.FunctionalExercises.TryRun;

public class Exceptional<R> : Either<Exception, R>
{
    public Exceptional(Exception left) : base(left)
    {
    }

    public Exceptional(R right) : base(right)
    {
    }

    public static implicit operator Exceptional<R>(Exception exception) => new(exception);
    public static implicit operator Exceptional<R>(R value) => new(value);
}