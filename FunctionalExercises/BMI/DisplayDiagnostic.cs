namespace IMoreno.FunctionalExercises.BMI
{
    public class DisplayDiagnostic
    {
        readonly Screen screen;
        readonly Formulary formulary;

        float Weight => float.Parse(formulary.Weight);
        float Height => float.Parse(formulary.Height);

        public DisplayDiagnostic(Screen screen, Formulary formulary)
        {
            this.screen = screen;
            this.formulary = formulary;
        }

        public void Execute() => screen.Display(new BMIDiagnostic((Weight, Height)));
    }
}