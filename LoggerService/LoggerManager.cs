using Contracts;
using NLog;

namespace LoggerService;

public class LoggerManager:ILoggerManager
{
    private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
    public void LogInfo(string message)
    {
        Logger.Debug(message);
    }

    public void LogWarn(string message)
    {
        Logger.Warn(message);
    }

    public void LogDebug(string message)
    {
        Logger.Debug(message);
    }

    public void LogError(string message)
    {
        Logger.Error(message);
    }
}