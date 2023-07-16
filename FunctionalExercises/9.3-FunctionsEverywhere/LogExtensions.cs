namespace IMoreno.FunctionalExercises.FunctionsEverywhere;

public static class LogExtensions
{
    public static void Info(this Log log, string message)
    {
        log.Show($"[INFO] {message}");
    }
}