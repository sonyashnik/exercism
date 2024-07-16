using System;
using System.Collections.Generic;
using System.Linq;

[Flags]
public enum Allergen
{
    None = 0,
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private readonly int _allergyScore = default(int);
    public Allergies(int mask)
    {
        _allergyScore = mask % 256;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return ((_allergyScore & (int)allergen) == 0) ? false : true;
    }

    public List<Allergen> List()
    {
        return Enum.GetValues(typeof(Allergen)).Cast<Allergen>().Where(IsAllergicTo).Select(_=>_).ToList();
    }
}