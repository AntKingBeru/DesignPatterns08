namespace Patterns.Structural.Adapter
{
    public class LoggerAdapter : ILogger
    {
        private ConsoleLogger _consoleLogger = new();
        private UILogger _uiLogger = new();
        private FileLogger _fileLogger = new();
        private WhatsappLogger _whatsappLogger = new();

        public void Log(string message, LoggerType type)
        {
            switch (type)
            {
                case LoggerType.Console:
                    _consoleLogger.WriteLine(message, 1);
                    break;
                case LoggerType.UI:
                    _uiLogger.WriteLine(message, 1);
                    break;
                case LoggerType.File:
                    _fileLogger.WriteLine(message, 1);
                    break;
                case LoggerType.Whatsapp:
                    _whatsappLogger.WriteLine(message, 1);
                    break;
                default:
                    break;
            }
        }
    }

    public enum LoggerType
    {
        Console,
        UI,
        File,
        Whatsapp
    }
}