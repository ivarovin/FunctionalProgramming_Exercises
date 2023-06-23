namespace IMoreno.FunctionalExercises.Optional
{
    public class Greeting
    {
        public string For(Option<string> name)
            => name.Match
            (
                none: () => "",
                some: n => $"Hello, {n}"
            );
    }
}