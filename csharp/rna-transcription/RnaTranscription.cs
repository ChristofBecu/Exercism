using System;

public static class RnaTranscription
{
    public static string ToRna(string DNA_strand)
    {
        int strandLength = DNA_strand.Length;
        char[] RNA_strand = new char[strandLength];
        for(int i = 0; i < strandLength; i++) {
            RNA_strand[i] = DNA_strand[i] switch
            {
                'C' => 'G',
                'G' => 'C',
                'T' => 'A',
                'A' => 'U'
            };
        }
        return string.Join("", RNA_strand);
    }
}