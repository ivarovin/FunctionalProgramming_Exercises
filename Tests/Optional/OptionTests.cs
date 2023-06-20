using FluentAssertions;

namespace IMoreno.FunctionalExercises.Optional.Tests
{
    public class OptionTests
    {
        [Fact]
        public void Returns_some_value_if_not_null()
        {
            new Some<string>("Test")
                .Match
                (
                    none: () => "Fail",
                    some: value => value
                )
                .Should().Be("Test");
        }
    }
}