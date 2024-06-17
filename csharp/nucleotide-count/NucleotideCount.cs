using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        char[] nucleotides = { 'A', 'C', 'G', 'T' };
        if (sequence.Except(nucleotides).Any())  throw new ArgumentException("");
        return new Dictionary<char, int>(){
            {'A', sequence.Count(a => a == 'A') },
            {'C', sequence.Count(c => c == 'C') },
            {'G', sequence.Count(g => g == 'G') },
            {'T', sequence.Count(t => t == 'T') }
        };
    }
}