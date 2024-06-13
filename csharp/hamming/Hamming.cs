using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length) 
        {
            throw new ArgumentException("");
        }
        return firstStrand.Zip(secondStrand).Count(_ => _.First != _.Second);
    }
}