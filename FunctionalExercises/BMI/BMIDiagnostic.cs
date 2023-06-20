namespace IMoreno.FunctionalExercises.BMI
{
    public record BMIDiagnostic(BMI bmi)
    {
        const float underweight = 18.5f;
        const float overweight = 25f;

        public string Value => bmi.Value switch
        {
            < underweight => "underweight",
            >= overweight => "overweight",
            _ => "healty"
        };
    }
}