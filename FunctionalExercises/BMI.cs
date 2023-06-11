namespace IMoreno.FunctionalExercises.BMI
{
    public record BMI(float weight, float height)
    {
        public string Diagnostic
            => Value switch
            {
                < 18.5f => "Underweight",
                >= 25f => "Overweight",
                _ => "Healty"
            };

        public double Value => Math.Round(weight / (height * height), 2);
    }
}