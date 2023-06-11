using NSubstitute;

namespace IMoreno.FunctionalExercises.BMI.Tests
{
    public class DisplayBMIDiagnosticTests
    {
        [Fact]
        public void Display_diagnostic_after_introducing_values()
        {
            var screen = Substitute.For<Screen>();
            var keyboard = Substitute.For<Keyboard>();
            var sut = new DisplayDiagnostic(screen, keyboard);
            keyboard.Weight.Returns("100");
            keyboard.Height.Returns("1,5");

            sut.Execute();

            screen.Received(1).Display("overweight");
        }
    }
}