using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0;
        HashSet<int> unique = ExtractUniqueMultiples(multiples, max);

        foreach (int i in unique)
            sum += i;

        return sum;
    }

    private static HashSet<int> ExtractUniqueMultiples(IEnumerable<int> multiples, int max)
    {
        HashSet<int> unique = new HashSet<int>();
        foreach (int i in multiples)
        {
            if (i != 0)
            {
                for (int j = i; j < max; j++)
                {
                    if (j % i == 0)
                        unique.Add(j);
                }
            }
        }

        return unique;
    }
}