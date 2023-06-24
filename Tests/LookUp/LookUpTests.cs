using FluentAssertions;
using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.LookUp.Tests
{
    public class LookUpTests
    {
        [Fact]
        public void Return_none_if_collection_is_empty()
        {
            new List<int>().LookUp(i => i == 0)
                .Should()
                .BeOfType<None<int>>();
        }

        [Fact]
        public void Return_none_if_no_value_matches_predicate()
        {
            new List<int>() { 1 }.LookUp(i => i == 0)
                .Should()
                .BeOfType<None<int>>();
        }

        [Fact]
        public void Return_value_if_matches_predicate()
        {
            new List<int>() { 0 }.LookUp(i => i == 0)
                .Should()
                .BeOfType<Some<int>>();
        }

        [Fact]
        public void Return_first_value_that_matches_predicate()
        {
            bool IsOdd(int i) => i % 2 == 0;

            new List<int>() { 2, 4, 6 }.LookUp(IsOdd)
                .Should()
                .Be(new Some<int>(2));
        }
    }
}