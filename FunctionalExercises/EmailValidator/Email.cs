using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.EmailValidator
{
    public readonly struct Email
    {
        readonly string value;
        Email(string value) => this.value = value;

        public static implicit operator string(Email email) => email.value;
        public static Option<Email> Create(string value) =>
            value.Contains('@') ? new Email(value) : new None<Email>();
    }
}