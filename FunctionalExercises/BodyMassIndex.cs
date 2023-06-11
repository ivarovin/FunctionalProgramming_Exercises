namespace IMoreno.FunctionalExercises.BMI
{
    public record BodyMassIndex(int weight, int height)
    {
        public string Diagnostic => Value < 18.5f ? "Underweight" : "Overweight";
        public float Value => weight / (height * height);
    }
}