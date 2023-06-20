using FluentAssertions;

namespace IMoreno.FunctionalExercises.Optional.Tests
{
    public class SomeTests
    {
        [Fact]
        public void Deconstruct_returns_assigned_value_if_not_null()
        {
            new Some<string>("Test").Deconstruct(out var result);

            result.Should().Be("Test");
        }
    }
}