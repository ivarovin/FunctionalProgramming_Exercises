namespace IMoreno.FunctionalExercises.BMI
{
    public record BMI(float weight, float height)
    {
        public string Diagnostic => Value switch
        {
            < 18.5f => "underweight",
            >= 25f => "overweight",
            _ => "healty"
        };

        public double Value => Round(weight / (height * height));
        static double Round(double value) => Math.Round(value, 1);
    }
}