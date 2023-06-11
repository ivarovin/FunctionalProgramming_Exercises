using FluentAssertions;

namespace IMoreno.FunctionalExercises.BMI.Tests
{
    public class BMICalculationTests
    {
        [Fact]
        public void Calculate_BMI()
        {
            new BMI(weight: 80, height: 1.8f).Value.Should().BeApproximately(24.69f, 1);
            new BMI(weight: 80, height: 1.5f).Value.Should().BeApproximately(35.56f, 1);
            new BMI(weight: 50, height: 1).Value.Should().BeApproximately(50, 1);
            new BMI(weight: 81, height: 1.8f).Value.Should().Be(25);
        }
    }
}