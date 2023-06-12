using FluentAssertions;

namespace IMoreno.FunctionalExercises.BMI.Tests
{
    public class BMIDiagnosticTests
    {
        [Fact]
        public void Diagnose_underweight_if_BMI_is_under_minimum()
        {
            new BMIDiagnostic((weight: 50, height: 2)).Value.Should().Be("underweight");
        }

        [Fact]
        public void Diagnose_overweight_if_BMI_is_over_maximum()
        {
            new BMIDiagnostic((weight: 200, height: 1)).Value.Should().Be("overweight");
        }

        [Fact]
        public void Diagnose_overweight_if_BMI_is_equal_than_maximum()
        {
            new BMIDiagnostic((weight: 81, height: 1.8f)).Value.Should().Be("overweight");
        }

        [Fact]
        public void Diagnose_healty_if_BMI_is_between_bounds()
        {
            new BMIDiagnostic((weight: 80, height: 1.8f)).Value.Should().Be("healty");
        }
    }
}