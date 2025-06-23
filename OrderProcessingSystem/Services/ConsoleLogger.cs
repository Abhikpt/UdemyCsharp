using  OrderProcessingSystem.Interfaces;
public class ConsoleLogger : ILogger
{
    public void LogInfo(string message)
    {
        Console.WriteLine($"INFO: {message}");
    }

    public void LogWarning(string message)
    {
        Console.WriteLine($"WARNING: {message}");
    }

    public void LogError(string message)
    {
        Console.WriteLine($"ERROR: {message}");
    }

    public void LogDebug(string message)
    {
        Console.WriteLine($"DEBUG: {message}");
    }

    public void LogException(Exception exception)
    {
        Console.WriteLine($"EXCEPTION: {exception.Message}");
    }

    public void LogCritical(string message)
    {
        Console.WriteLine($"CRITICAL: {message}");
    }

    public IEnumerable<string> GetLogs()
    {
        // For simplicity, this method returns an empty list.
        // In a real implementation, it would return stored logs.
        return new List<string>();
    }
}