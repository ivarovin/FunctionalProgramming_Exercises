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
}