using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) => 
        (   from dividend in Enumerable.Range(1, max - 1)
            from divisor in multiples
            where divisor != 0 && dividend % divisor == 0
            select dividend
        ).Distinct().Sum();
}