using FluentAssertions;

namespace IMoreno.FunctionalExercises.BMI.Tests
{
    public class BMITests
    {
        [Fact]
        public void Calculate_BMI()
        {
            new BMI(weight: 80, height: 1.8f).Value.Should().BeApproximately(24.7f, 1);
            new BMI(weight: 80, height: 1.5f).Value.Should().BeApproximately(35.6f, 1);
        }

        [Fact]
        public void Round_BMI()
        {
            new BMI(weight: 50, height: 1).Value.Should().Be(50);
            new BMI(weight: 81, height: 1.8f).Value.Should().Be(25);
        }
    }
}