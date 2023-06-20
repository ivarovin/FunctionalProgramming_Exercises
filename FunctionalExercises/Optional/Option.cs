namespace IMoreno.FunctionalExercises.Optional
{
    public abstract record Option<T> { }

    public static class OptionExtensions
    {
        public static R Match<T, R>(this Option<T> option, Func<R> none, Func<T, R> some)
            => option switch
            {
                Some<T>(var value) => some(value)
            };
    }
}