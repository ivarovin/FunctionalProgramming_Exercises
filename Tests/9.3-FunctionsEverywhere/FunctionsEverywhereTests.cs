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

    [Fact]
    public void Log_warning()
    {
        var result = "";

        new Log(m => result = m).Warning("test");

        result.Should().Be("[WARNING] test");
    }

    [Fact]
    public void Log_error()
    {
        var result = "";

        new Log(m => result = m).Error("test");

        result.Should().Be("[ERROR] test");
    }
}