using System;
using System.CodeDom.Compiler;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        foreach (char c in identifier)
        {
            if (c == ' ')
            {
                identifier = identifier.Replace(c, '_');
            }
        }

        bool containsCTRL = identifier.Contains('\0');

        while (containsCTRL)
        {
            if (identifier.Contains('\0'))
            {
                int startIndex = identifier.IndexOf("\0");
                identifier = string.Concat(identifier.AsSpan(0, startIndex), "CTRL", identifier.AsSpan(startIndex + 2, identifier.Length - 1));
                containsCTRL = true;
            }
            else
            {
                containsCTRL = false;
            }
        }
        bool kebabCase = identifier.Contains('-');
        while (kebabCase)
        {
            if (kebabCase)
            {
                int minusIndex = identifier.IndexOf("-");
                identifier = identifier.Replace(identifier.concat(minusIndex + 1, 1),'B');
            }
        }

        return identifier;
    } 
}
