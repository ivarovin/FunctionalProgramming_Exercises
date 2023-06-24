using FluentAssertions;
using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.ParseDayOfWeek.Tests
{
    public class ParseDayOfWeekTests
    {
        [Fact]
        public void Parse_valid_DayOfWeek()
        {
            Enum.Parse<DayOfWeek>("Friday")
                .Should()
                .Be(new Some<DayOfWeek>(DayOfWeek.Friday));
        }

        [Fact]
        public void Parse_invalid_DayOfWeek_returns_none()
        {
            Enum.Parse<DayOfWeek>("FreeDay")
                .Should()
                .Be(new None<DayOfWeek>());
        }
    }
}