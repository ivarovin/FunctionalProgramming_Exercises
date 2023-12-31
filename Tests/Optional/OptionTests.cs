﻿using FluentAssertions;

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

        [Fact]
        public void Returns_none_value_if_null()
        {
            new None<string>()
                .Match
                (
                    none: () => "None",
                    some: value => value
                )
                .Should().Be("None");
        }

        [Fact]
        public void Convert_to_type_returns_some_value()
        {
            ((Option<string>)"Test").Should().BeOfType<Some<string>>();
        }

        [Fact]
        public void Convert_to_null_returns_none_value()
        {
            string value = null;
            ((Option<string>)value).Should().BeOfType<None<string>>();
        }
    }
}