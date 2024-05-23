using System;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System.Collections.Generic;
using System.Linq;

public static class LogAnalysis
{
	public static string SubstringAfter(this String str, String delimiter)
	{
		return str.Substring(str.IndexOf(delimiter) + delimiter.Length);
	}

	public static string SubstringBetween(this string str, string delimiter1, string delimiter2)
	{
		int offsetStart = str.IndexOf(delimiter1) + delimiter1.Length;
		int offsetEnd = str.IndexOf(delimiter2);
		return str.Substring(offsetStart, offsetEnd - offsetStart);
	}

	public static string Message(this string str)
	{
		List<string> logTypes = new List<string> { "INFO", "WARNING", "ERROR" };
		var message = String.Empty;
		string[] stringParts = str.Split(new char[] { ':' });
		foreach (string stringPart in stringParts)
		{
			if (!logTypes.Any(stringPart.Contains))
				message = stringPart.Trim();
		}
		return message;
	}

	public static string LogLevel(this string str)
	{
		List<string> logTypes = new List<string> { "INFO", "WARNING", "ERROR" };
		var logLevel = String.Empty;
		foreach (string logType in logTypes)
		{
			if (str.Contains(logType))
				logLevel = logType;
		}
		return logLevel;
	}
}