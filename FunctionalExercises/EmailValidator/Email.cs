using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.EmailValidator
{
    public readonly struct Email
    {
        readonly string value;
        Email(string value) => this.value = value;

        public static implicit operator string(Email email) => email.value;
        public static Option<Email> Create(string value) =>
            IsValid(value) ? new Email(value) : new None<Email>();

        static bool IsValid(string value) => value.Contains('@');
    }
}