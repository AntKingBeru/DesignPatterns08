namespace Patterns.Structural.Adapter
{
    public interface ILogger
    {
        void Log(string message, LoggerType type);
    }
}