using FluentAssertions;

namespace IMoreno.FunctionalExercises.BMI.Tests
{
    public class BMICalculatorTests
    {
        [Fact]
        public void Display_underweight_if_BMI_is_under_minimum()
        {
            var sut = new BodyMassIndex();

            sut.Of(weight: 100, height: 2)
               .Should()
               .Be("Underweight");
        }
    }
}