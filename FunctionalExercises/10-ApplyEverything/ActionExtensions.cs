namespace IMoreno.FunctionalExercises.ApplyEverything;

public static class ActionExtensions
{
    public static Func<Unit> ToFunc(this Action action)
        => () =>
        {
            action();
            return default;
        };
}