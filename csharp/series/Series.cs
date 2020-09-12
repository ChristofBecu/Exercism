using System;
using System.Collections.Generic;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength > 0 && sliceLength <= numbers.Length)
            return Enumerable.Range(0, numbers.Length - sliceLength + 1)
                .Select(x => numbers.Substring(x, sliceLength)).ToArray();
        throw new ArgumentException();
    }
}