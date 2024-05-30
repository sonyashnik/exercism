using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

public class LogParser
{
	public bool IsValidLine(string text)
    {
		string pattern = @"^(\[TRC\]|\[DBG\]|\[INF\]|\[ERR\]|\[WRN\]|\[FTL\])";
        return Regex.IsMatch(text, pattern);
    }

    public string[] SplitLogLine(string text)
    {
        string pattern = @"<[-,*,=,^]+>";
        return Regex.Split(text, pattern);       
    }

    public int CountQuotedPasswords(string lines)
    {
		string pattern = @""".*password.*""";
		return Regex.Matches(lines, pattern, RegexOptions.IgnoreCase).Count();
	}

    public string RemoveEndOfLineText(string line)
    {
        string pattern = @"end-of-line\d+";
        return Regex.Replace(line, pattern, String.Empty);
    }

    public string[] ListLinesWithPasswords(string[] lines)
    {
		string pattern = @"password\w+";
		var processedLines = new List<string>();
		foreach (string line in lines)
		{
			Match passwordMatch = Regex.Match(line, pattern, RegexOptions.IgnoreCase);
			if (passwordMatch == Match.Empty)
				processedLines.Add($"--------: {line}");
			else
				processedLines.Add($"{passwordMatch.Value}: {line}");
		}
		return processedLines.ToArray();
	}
}
