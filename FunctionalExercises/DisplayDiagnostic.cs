namespace IMoreno.FunctionalExercises.BMI
{
    public class DisplayDiagnostic
    {
        readonly Screen screen;
        readonly Keyboard keyboard;

        public DisplayDiagnostic(Screen screen, Keyboard keyboard)
        {
            this.screen = screen;
            this.keyboard = keyboard;
        }

        public void Execute()
        {
            var result = new BMI(float.Parse(keyboard.Weight), 
                                 float.Parse(keyboard.Height));

            screen.Display(result.Diagnostic);
        }
    }
}