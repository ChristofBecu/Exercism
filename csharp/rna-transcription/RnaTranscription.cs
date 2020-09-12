using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
// G -> C
// C -> G
// T -> A
// A -> U

// ACGTGGTCTTAA
// UGCACCAGAAUU
        var n = nucleotide.ToCharArray();
        for(int i = 0; i < n.Length; i++) {
            switch (n[i])
            {
                case 'C':
                    n[i] = 'G';
                    break;
                case 'G':
                    n[i] = 'C';
                    break;
                case 'T':
                    n[i] = 'A';
                    break;
                case 'A':
                    n[i] = 'U';
                    break;
                default:
                    n[i] = ' ';
                    break;
            }          
        }

        return string.Join("", n);
    }
}