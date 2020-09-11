using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
            throw new ArgumentException();
            
        int hammingDistance = 0;

        if (firstStrand == secondStrand)
            return hammingDistance;

        for (int i = 0; i <= firstStrand.Length-1; i++) 
        {
            if (firstStrand[i] != secondStrand[i])
                hammingDistance++;
        }

        return hammingDistance;  
    }
}