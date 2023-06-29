namespace IMoreno.FunctionalExercises.Compose
{
    public static class Composition
    {
        public static Func<T, T> Of<T>(Func<T, T> f, Func<T, T> t)
        {
            return value => f(t(value));
        }
    }
}