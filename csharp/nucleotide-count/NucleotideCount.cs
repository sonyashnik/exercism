using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        char[] nucleotides = { 'A', 'C', 'G', 'T' };
        if (!sequence.All(nucleotides.Contains)) throw new ArgumentException("");
        //if (!sequence.All(x => nucleotides.Contains(x))) throw new ArgumentException("");
        //if (sequence.Except(nucleotides).Any())  throw new ArgumentException("");
        return new Dictionary<char, int>(){
            {nucleotides[0], sequence.Count(a => a == nucleotides[0]) },
            {nucleotides[1], sequence.Count(c => c == nucleotides[1]) },
            {nucleotides[2], sequence.Count(g => g == nucleotides[2]) },
            {nucleotides[3], sequence.Count(t => t == nucleotides[3]) }
        };
    }
}