using System;
using System.Text.RegularExpressions;


static class LogLine
{
    public static string Message(string logLine)
    {

        GroupCollection groups = Regex.Match(logLine, @"\[(?<LEVEL>\w*)\]: (?<MESSAGE>.*)").Groups;

        string message = groups["MESSAGE"].Value.Trim();

        return message;
        // alternative:
        // if (!logLine.Contains(':'))
        //     return null;
        // int index = logLine.Trim().IndexOf(':');
        // return logLine[(index + 2)..].Trim();
    }


    public static string LogLevel(string logLine)

    {
        GroupCollection groups = Regex.Match(logLine, @"\[(?<LEVEL>\w*)\]: (?<MESSAGE>.*)").Groups;

        string level = groups["LEVEL"].Value.ToLower();

        return level;
        // alternative:
        // int index1 = logLine.IndexOf('[');
        // int index2 = logLine.IndexOf(']');
        // return logLine.ToLower().Substring(index1 + 1, index2 - index1 - 1);
    }

    public static string Reformat(string logLine)
    {
        GroupCollection groups = Regex.Match(logLine, @"\[(?<LEVEL>\w*)\]: (?<MESSAGE>.*)").Groups;

        string message = groups["MESSAGE"].Value.Trim();

        string level = groups["LEVEL"].Value.ToLower();

        return $"{message} ({level})";
        // alternative:
        // string logLevel = LogLevel(logLine).ToLower();
        // string message = Message(logLine);
        // return $"{message} ({logLevel})";
    }
}