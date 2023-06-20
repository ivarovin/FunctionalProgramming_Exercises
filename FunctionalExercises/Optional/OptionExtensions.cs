namespace IMoreno.FunctionalExercises.Optional
{
    public static class OptionExtensions
    {
        public static R Match<T, R>(this Option<T> option, Func<R> none, Func<T, R> some)
            => option switch
            {
                None<T> => none(),
                Some<T>(var value) => some(value)
            };
    }
}