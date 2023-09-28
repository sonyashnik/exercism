using System;
using System.Collections.Generic;
using System.Linq;

static class LogLine
{


    public static string Message(string logLine)
    {
        List<string> logTypes = new List<string> { "INFO", "WARNING", "ERROR" };
        var message = new String("");
        string[] stringParts = logLine.Split(new char[] { ':' });
        foreach (string stringPart in stringParts)
        {
            if (!logTypes.Any(stringPart.Contains))
                message = stringPart.Trim();
        }
        return message;

    }

    public static string LogLevel(string logLine)
    {
        var indexStart = logLine.IndexOf("[");
        var indexEnd = logLine.IndexOf("]");
        return logLine.Substring(indexStart + 1, indexEnd - indexStart-1).Trim().ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
