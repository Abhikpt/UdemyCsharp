namespace OrderProcessingSystem.Interfaces;
public interface ILogger
{
    void LogInfo(string message);
    void LogWarning(string message);
    void LogError(string message);
    void LogDebug(string message);
    void LogException(Exception exception);
    void LogCritical(string message);
    IEnumerable<string> GetLogs();
}