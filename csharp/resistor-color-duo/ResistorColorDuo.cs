using System;



public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        int[] vals = new int[colors.Length];
        for (int i = 0; i < colors.Length; i++)
        {
            vals[i] = ColorCode(colors[i]);
        }
        return vals[0] * 10 + vals[1];
    }
    public static int ColorCode(string color)
    {
        return Array.IndexOf(Colors(), color);
    }

    public static string[] Colors()
    {
        return new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    }
}
