using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var transformed = new Dictionary<string, int>();
        foreach (var (score, letter) in from score in old
                                        from string letter in score.Value
                                        select (score.Key, letter.ToLower()))
                                        {
                                            transformed.Add(letter, score);
                                        }
        return transformed;
    }
}