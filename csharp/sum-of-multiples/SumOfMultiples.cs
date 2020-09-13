using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        if (multiples.Any() && max > multiples.Min())
        {
            List<int> multiplesRange = new List<int>();
            for (int i = multiples.Min(); i < max; i++)
                multiplesRange.Add(i);

            return (from dividend in multiplesRange
                    from divisor in multiples
                    where divisor != 0 && dividend % divisor == 0
                    select dividend)
                .Distinct()
                .Sum();
        }
        return 0;
    }
}