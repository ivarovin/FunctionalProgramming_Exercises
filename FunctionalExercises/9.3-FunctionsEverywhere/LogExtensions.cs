namespace IMoreno.FunctionalExercises.FunctionsEverywhere;

public static class LogExtensions
{
    public static void Info(this Log log, string message)
    {
        log.Show($"[INFO] {message}");
    }
    
    public static void Warning(this Log log, string message)
    {
        log.Show($"[WARNING] {message}");
    }
    
    public static void Error(this Log log, string message)
    {
        log.Show($"[ERROR] {message}");
    }
}