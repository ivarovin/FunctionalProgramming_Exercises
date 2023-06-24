using FluentAssertions;

namespace IMoreno.FunctionalExercises.ParseDayOfWeek.Tests
{
    public class ParseDayOfWeekTests
    {
        [Fact]
        public void Parse_valid_DayOfWeek()
        {
            Enum.Parse<DayOfWeek>("Friday").Should().Be(DayOfWeek.Friday);
        }
    }
}