using FluentAssertions;

namespace IMoreno.FunctionalExercises.BMI.Tests
{
    public class BMICalculatorTests
    {
        [Fact]
        public void Display_underweight_if_BMI_is_under_minimum()
        {
            var sut = new BodyMassIndex(weight: 100, height: 2);

            sut.Diagnostic.Should().Be("Underweight");
        }
    }
}