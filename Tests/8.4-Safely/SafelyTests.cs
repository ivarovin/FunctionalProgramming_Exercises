using FluentAssertions;
using IMoreno.FunctionalExercises.ToOption;

namespace IMoreno.FunctionalExercises.Safely.Tests;

public class SafelyTests
{
    [Fact]
    public void Return_left_value_when_throws_exception()
    {
        Either<L, R> Mut<L, R>(Func<R> operation, Func<Exception, L> reactTo)
        {
            try
            {
                return operation();
            }
            catch (Exception exception)
            {
                return reactTo(exception);
            }
        }

        Mut<string, int>(() => throw new Exception("error"), (e) => "error")
            .Match
            (
                left: _ => true,
                right: _ => false
            )
            .Should().BeTrue();
    }
}