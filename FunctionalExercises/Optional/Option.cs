namespace IMoreno.FunctionalExercises.Optional
{
    public abstract record Option<T>
    {
        public static implicit operator Option<T>(T value) =>
            value == null ? new None<T>() : new Some<T>(value);

        public static implicit operator Option<T>(OptionType _) => new None<T>();

        public static Option<T> Some<T>(T value)
            => value;
    }
}