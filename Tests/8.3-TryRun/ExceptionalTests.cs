namespace IMoreno.FunctionalExercises.TryRun.Tests;

public class ExceptionalTests
{
    [Fact]
    public void Contain_exception_on_left_rail()
    {
        var sut = new Exceptional<string>(new Exception("some exception"));

        sut.Match<Action>
        (
            left: _ => () => Assert.True(true),
            right: _ => () => Assert.True(false)
        );
    }

    [Fact]
    public void TryRun()
    {
        Exceptional<T> Mut<T>(Func<T> op)
        {
            try
            {
                return op();
            }
            catch (Exception exception)
            {
                return exception;
            }
        }

        Mut<string>(() => throw new Exception("something"))
            .Match<Action>
            (
                left: _ => () => Assert.True(true),
                right: _ => () => Assert.True(false)
            );
    }
}