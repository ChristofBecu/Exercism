using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        if (multiples.Any())
        {
            int min = multiples.Min();
            int count = max - min;

            if (count <= 0) return 0;

            return Enumerable.Range(min, count)
                .Where(dividend => multiples
                    .Any(divisor => divisor != 0 && dividend % divisor == 0))
                .Sum();
        }
        return 0;
    }
}