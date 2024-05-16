using System;
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
        Regex regex = new Regex(pattern);
        return regex.Split(text);       
    }

    public int CountQuotedPasswords(string lines)
    {
		string pattern = @""".*password.*""";
		Regex regex = new Regex(pattern);

		return Regex.Matches(lines, pattern, RegexOptions.IgnoreCase).Count();
	}

    public string RemoveEndOfLineText(string line)
    {
        throw new NotImplementedException($"Please implement the LogParser.RemoveEndOfLineText() method");
    }

    public string[] ListLinesWithPasswords(string[] lines)
    {
        throw new NotImplementedException($"Please implement the LogParser.ListLinesWithPasswords() method");
    }
}
