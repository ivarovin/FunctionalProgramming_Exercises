namespace IMoreno.FunctionalExercises
{
    public static class Functions
    {
        public static Func<bool> Negated(this Func<bool> predicate) => () => !predicate();
    }
}