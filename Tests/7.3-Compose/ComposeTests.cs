using FluentAssertions;

namespace IMoreno.FunctionalExercises.Compose.Tests
{
    public class ComposeTests
    {
        [Fact]
        public void Compose_two_unary_functions()
        {
            int AddOne(int a) => a + 1;
            int Duplicate(int a) => a * 2;

            var operation = Composition.Of<int>(AddOne, Duplicate);

            operation(4).Should().Be(9);
        }
    }
}