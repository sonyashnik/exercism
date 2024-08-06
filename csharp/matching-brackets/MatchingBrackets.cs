using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit.Sdk;
public static class MatchingBrackets
{
    static readonly string opened = "{[(";
    static readonly string closed = "}])";

    public static bool IsPaired(string input)
    {
        var stack = new Stack<char>();

        foreach (char c in input)
        {
            if (IsOpened(c))
            {
                stack.Push(c);
            }
            else if (IsClosed(c))
            {
                if (stack.Count == 0 || GetPair(c) != stack.Pop())
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    static bool IsClosed(char c) => closed.Contains(c);
    static bool IsOpened(char c) => opened.Contains(c);
    static char GetPair(char c)
    {
        return c switch
        {
            '}' => '{',
            ']' => '[',
            ')' => '(',
            _ => c,
        };
    }
}
