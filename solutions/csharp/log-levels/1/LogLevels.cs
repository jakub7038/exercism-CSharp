static class LogLine
{
    public static string Message(string logLine)
    {
        string[] parts = logLine.Split(':');

        logLine = "";
        parts[0] = "";

        foreach (var part in parts)
        {
            logLine += part;
        }

        return logLine.Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] parts = logLine.Split(':');

        string loglevel = parts[0];

        return loglevel.Trim('[', ']').ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
