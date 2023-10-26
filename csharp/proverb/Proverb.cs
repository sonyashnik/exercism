using System;
public static class Proverb
{

    public static string[] Recite(string[] subjects)
    {
        string[] result = new String[subjects.Length];
        for (int i = 0; i <= subjects.Length - 1; i++)
        {
            if (i == subjects.Length - 1)
            {
                result[subjects.Length - 1] = "And all for the want of a " + subjects[0] + ".";
            }
            else
            {
                result[i] = "For want of a " + subjects[i] + " the " + subjects[i + 1] + " was lost.";
            }

        }
        return result;

    }
}