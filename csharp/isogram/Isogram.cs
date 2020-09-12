using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Isogram
{
    public static bool IsIsogram(string word) 
    {
        word =  RemoveNonAlphabetics(word.ToLower());
        return word == RemoveDuplicateCharacters(word);
    }

    public static string RemoveDuplicateCharacters(string s) => string.Join("", new HashSet<char>(s).ToArray());

    public static string RemoveNonAlphabetics(string s) => Regex.Replace(s,"[^A-Za-z]",""); 

}
