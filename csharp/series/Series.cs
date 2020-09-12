using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength <= 0 || sliceLength > numbers.Length || numbers == "")
            throw new ArgumentException();

        List<string> sliceList = new List<string>();
        for (int i = 0; i <= numbers.Length - sliceLength; i++) 
            sliceList.Add( numbers.Substring(i, sliceLength));
        
        return sliceList.ToArray(); 
    }
}