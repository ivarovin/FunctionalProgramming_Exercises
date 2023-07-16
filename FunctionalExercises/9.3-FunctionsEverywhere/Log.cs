namespace IMoreno.FunctionalExercises.FunctionsEverywhere;

public record Log()
{
    readonly Action<string> logger;
    public Log(Action<string> logger) : this() => this.logger = logger;
    
    public void Show(string message) => logger(message);
}