using System;
using System.Linq;
using System.Text;

public static class RotationalCipher
{
    private static readonly char[] _plain = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    public static string Rotate(string text, int shiftKey)
    {
        var sb = new StringBuilder();
        foreach (var c in text)
        {
            if (char.IsLetter(c))
            {
                var isUpper = char.IsUpper(c);
                var x = char.ToLower(c);
                var charInd = Array.IndexOf(_plain, x);
                x = _plain[(charInd + shiftKey) % _plain.Length];
                sb.Append(isUpper ? char.ToUpper(x) : x);
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}