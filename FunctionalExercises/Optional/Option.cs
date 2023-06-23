namespace IMoreno.FunctionalExercises.Optional
{
    public abstract record Option<T>
    {
        public static implicit operator Option<T>(T value) => new Some<T>(value);
    }
}