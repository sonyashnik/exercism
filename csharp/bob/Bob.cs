using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        switch (true) {
            case true when IsShout(statement) && IsQuestion(statement):
                return "Calm down, I know what I'm doing!";
            case true when IsShout(statement):
                return "Whoa, chill out!";
            case true when IsQuestion(statement):
                return "Sure.";
            case true when string.IsNullOrWhiteSpace(statement):
                return "Fine. Be that way!";
            default:
                return "Whatever.";
        }
    }
    public static bool IsShout(string input) => input.Any(char.IsLetter) && input.ToUpper() == input ;
    public static bool IsQuestion(string input) =>input.TrimEnd().EndsWith('?');
}