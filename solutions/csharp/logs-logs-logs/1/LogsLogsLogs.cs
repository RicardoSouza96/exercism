// TODO: define the 'LogLevel' enum
enum LogLevel
{
    Trace,
    Debug,
    Info,
    Warning,
    Error,
    Fatal,
    Unknown 
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        string result = logLine.Substring(1,3);
        switch(result)
        {
            case "TRC": return LogLevel.Trace;
            case "DBG": return LogLevel.Debug;
            case "INF": return LogLevel.Info;
            case "WRN": return LogLevel.Warning;
            case "ERR": return LogLevel.Error;
            case "FTL": return LogLevel.Fatal;
            default: return LogLevel.Unknown;
        }
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        string result = logLevel.ToString();
        switch(result)
        {
            case "Trace": return $"1:{message}";
            case "Debug": return $"2:{message}";
            case "Info": return $"4:{message}";
            case "Warning": return $"5:{message}";
            case "Error": return $"6:{message}";
            case "Fatal": return $"42:{message}";
            default: return $"0:{message}";
        }
    }
}
