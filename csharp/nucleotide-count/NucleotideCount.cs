using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        sequence.IsValid();

        var nucleotides = new Dictionary<char, int>()
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        foreach (char nucleotide in sequence)
            nucleotides[nucleotide]++;

        return nucleotides;
    }

    private static void IsValid(this string sequence)
    {
        if (Regex.IsMatch(sequence, "[^ACGT]"))
            throw new ArgumentException();
    }
}