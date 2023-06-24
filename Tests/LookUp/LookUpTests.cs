﻿using FluentAssertions;
using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.LookUp.Tests
{
    public class LookUpTests
    {
        [Fact]
        public void Return_none_if_no_value_matches_predicate()
        {
            new List<int>().LookUp(i => i == 0)
                .Should()
                .BeOfType<None<int>>();
        }
    }
}