using FluentAssertions;

namespace IMoreno.FunctionalExercises.BMI.Tests
{
    public class BMIDiagnosticTests
    {
        [Fact]
        public void Diagnose_underweight_if_BMI_is_under_minimum()
        {
            new BMI(weight: 50, height: 2).Diagnostic.Should().Be("underweight");
        }

        [Fact]
        public void Diagnose_overweight_if_BMI_is_over_maximum()
        {
            new BMI(weight: 200, height: 1).Diagnostic.Should().Be("overweight");
        }

        [Fact]
        public void Diagnose_overweight_if_BMI_is_equal_than_maximum()
        {
            new BMI(weight: 81, height: 1.8f).Diagnostic.Should().Be("overweight");
        }

        [Fact]
        public void Diagnose_healty_if_BMI_is_between_bounds()
        {
            new BMI(weight: 80, height: 1.8f).Diagnostic.Should().Be("healty");
        }
    }
}