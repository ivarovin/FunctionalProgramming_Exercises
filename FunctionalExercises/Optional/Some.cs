namespace IMoreno.FunctionalExercises.Optional
{
    public record Some<T> : Option<T>
    {
        readonly T value;

        public Some(T value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value), "It is necessary to pass some value");

            this.value = value;
        }

        public void Deconstruct(out T value) => value = this.value;
    }
}