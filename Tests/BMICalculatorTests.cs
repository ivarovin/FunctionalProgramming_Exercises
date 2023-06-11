using FluentAssertions;

namespace IMoreno.FunctionalExercises.BMI.Tests
{
    public class BMICalculatorTests
    {
        [Fact]
        public void Diagnose_underweight_if_BMI_is_under_minimum()
        {
            var sut = new BodyMassIndex(weight: 50, height: 2);

            sut.Diagnostic.Should().Be("Underweight");
        }

        [Fact]
        public void Diagnose_overweight_if_BMI_is_over_maximum()
        {
            var sut = new BodyMassIndex(weight: 200, height: 1);

            sut.Diagnostic.Should().Be("Overweight");
        }

        [Fact]
        public void Diagnose_healty_if_BMI_is_between_bounds()
        {
            var sut = new BodyMassIndex(weight: 80, height: 1.8f);

            sut.Diagnostic.Should().Be("Healty");
        }
    }
}