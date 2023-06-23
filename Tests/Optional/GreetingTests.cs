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
    }
}