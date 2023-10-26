using System;
using System.CodeDom.Compiler;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        bool isAfterHyphen = false;
        foreach (char c in identifier)
        {
            switch (true)
            {
                case true when char.IsWhiteSpace(c):
                    sb.Append('_');
                    break;
                case true when (Char.IsBetween(c, '\u0370', '\u03FF') && Char.IsLower(c)):
                    break;
                case true when Char.Equals(c, '\0'):
                    sb.Append("CTRL");
                    break;
                case true when isAfterHyphen:
                    sb.Append(Char.ToUpper(c));
                    break;
                case true when (char.IsLetter(c)):
                    sb.Append(c);
                    break;
                default:
                    break;

            }
            isAfterHyphen = Equals(c, '-');
        }
        return sb.ToString();
    }
}
