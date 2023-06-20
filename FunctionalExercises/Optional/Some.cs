﻿namespace IMoreno.FunctionalExercises.Optional
{
    public record Some<T>
    {
        readonly T value;

        public Some(T value) => this.value = value;

        public void Deconstruct(out T value) => value = this.value;
    }
}