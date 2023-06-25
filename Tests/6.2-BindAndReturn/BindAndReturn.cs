using FluentAssertions;
using static IMoreno.FunctionalExercises.BindAndReturn.MonadOperation;
using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.BindAndReturn.Tests
{
    public class BindAndReturnTests
    {
        [Fact]
        public void Bind_options()
        {
            Option<int> Duplicate(int value) => new Some<int>(value * 2);

            new Some<int>(1)
                .Bind(Duplicate)
                .Bind(Duplicate)
                .Should()
                .Be(new Some<int>(4));
        }

        [Fact]
        public void Elevate_value_to_option()
        {
            Optionalize(1).Should().Be(new Some<int>(1));
            Optionalize((string)null).Should().BeOfType<None<string>>();
        }
    }
}