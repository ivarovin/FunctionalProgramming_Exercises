using FluentAssertions;

namespace IMoreno.FunctionalExercises.FunctionsEverywhere.Tests;

public class FunctionsEverywhereTests
{
    [Fact]
    public void Log_info()
    {
        var result = "";

        new Log(m => result = m).Info("test");

        result.Should().Be("[INFO] test");
    }
}