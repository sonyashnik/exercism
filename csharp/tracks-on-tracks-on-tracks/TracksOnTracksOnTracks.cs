using System;
using System.Collections.Generic;

public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        return new List<string>() {"C#", "Clojure", "Elm"};
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
       return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
       return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        int place = languages.IndexOf("C#");
        return (place == 0 | (place == 1 && languages.Count >=2  && languages.Count<=3));
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        languages.Sort();
        bool isUnique = true;
        for (int i = 1; i < languages.Count; i++)
        {
            if (languages[i] == languages[i-1]) 
            {
                isUnique = false;
            }
        }
        return isUnique;
    }
}
