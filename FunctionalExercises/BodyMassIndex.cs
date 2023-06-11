namespace IMoreno.FunctionalExercises.BMI
{
    public record BodyMassIndex(int weight, int height)
    {
        public string Diagnostic => "Underweight";
    }
}