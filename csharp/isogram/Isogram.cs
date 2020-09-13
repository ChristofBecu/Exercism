using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Isogram
{
    public static bool IsIsogram(string word) 
    {
        word = word.RemoveNonAlpha();

        return word switch
        {
            "" => true,
            _ => word == word.RemoveDuplicates()
        };
    }

    public static string RemoveDuplicates(this string word) =>
        string.Concat(word.Distinct().Select(s => s.ToString()));

    public static string RemoveNonAlpha(this string word) =>
        string.Concat(word
                .ToLower()
                .Where(c => char.IsLetter(c))
                .Select(s => s.ToString()));
}
