namespace IMoreno.FunctionalExercises.BMI
{
    public struct BMI
    {
        readonly float weight;
        readonly float height;

        public double Value => Round(weight / (height * height));

        public BMI(float weight, float height)
        {
            this.weight = weight;
            this.height = height;
        }

        static double Round(double value) => Math.Round(value, 1);

        public static implicit operator BMI((float weight, float height) value)
        {
            return new(value.weight, value.height);
        }
    }
}