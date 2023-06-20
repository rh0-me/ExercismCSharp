using System;
using System.Text.RegularExpressions;


static class LogLine
{
    public static string Message(string logLine)
    {
        if (!logLine.Contains(':'))
            return null;
        int index = logLine.Trim().IndexOf(':');
        return logLine[(index + 2)..].Trim();
    }


    public static string LogLevel(string logLine)

    {
        int index1 = logLine.IndexOf('[');
        int index2 = logLine.IndexOf(']');
        return logLine.ToLower().Substring(index1 + 1, index2 - index1 - 1);
    }

    public static string Reformat(string logLine)
    {
        string logLevel = LogLevel(logLine).ToLower();
        string message = Message(logLine);
        return $"{message} ({logLevel})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}