using static IMoreno.FunctionalExercises.Optional.OptionType;
using FluentAssertions;

namespace IMoreno.FunctionalExercises.Optional.Tests
{
    public class GreetingTests
    {
        [Fact]
        public void Greet_Someone_when_provide_name()
        {
            new Greeting().For("Test").Should().Be("Hello, Test");
        }

        [Fact]
        public void Ask_for_someone_when_provide_no_name()
        {
            new Greeting().For(None).Should().Be("Hello?");
        }
    }
}