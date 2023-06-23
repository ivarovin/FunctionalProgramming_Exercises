namespace IMoreno.FunctionalExercises.Optional
{
    public record Some<T> : Option<T>
    {
        readonly T value;

        public Some(T value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value), $"Some value of type {typeof(T)} cannot be null");

            this.value = value;
        }

        public void Deconstruct(out T value) => value = this.value;
    }
}