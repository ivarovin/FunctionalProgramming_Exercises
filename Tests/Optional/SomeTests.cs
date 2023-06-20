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

    public record Some<T>
    {
        readonly T value;

        public Some(T value) => this.value = value;

        public void Deconstruct(out T value) => value = this.value;
    }
}