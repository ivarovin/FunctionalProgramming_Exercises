namespace IMoreno.FunctionalExercises.BMI
{
    public record BodyMassIndex(float weight, float height)
    {
        public string Diagnostic
            => Value switch
            {
                < 18.5f => "Underweight",
                > 25f => "Overweight",
                _ => "Healty"
            };

        float Value => weight / (height * height);
    }
}