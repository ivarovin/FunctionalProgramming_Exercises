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
        public void Bind_collections()
        {
            List<int> Duplicate(int value) => new List<int> { value * 2 };

            new List<int> { 1, 2, 3 }
                .Bind(Duplicate)
                .Bind(Duplicate)
                .Should()
                .BeEquivalentTo(new List<int> { 4, 8, 12 });
        }

        [Fact]
        public void Elevate_values_to_collection()
        {
            List(1, 2, 3).Should().HaveCount(3);
        }

        [Fact]
        public void Elevate_value_to_option()
        {
            Some(1).Should().Be(new Some<int>(1));
            Some((string)null).Should().BeOfType<None<string>>();
        }
    }
}