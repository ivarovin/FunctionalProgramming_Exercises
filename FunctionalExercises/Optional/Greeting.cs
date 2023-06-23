namespace IMoreno.FunctionalExercises.Optional
{
    public class Greeting
    {
        public string For(Option<string> name)
            => name.Match
            (
                none: () => "Hello?",
                some: n => $"Hello, {n}"
            );
    }
}