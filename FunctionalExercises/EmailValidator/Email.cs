using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.EmailValidator
{
    public struct Email
    {
        public static Option<Email> Create(string value) =>
            new None<Email>();
    }
}