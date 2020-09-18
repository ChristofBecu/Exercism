using System;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number == 0)
            throw new ArgumentOutOfRangeException();
        var sumOfFactors = Enumerable.Range(1, number).Where(x => x < number && number % x == 0).Sum();

        return sumOfFactors switch
        {
            int v when sumOfFactors == number => Classification.Perfect,
            int v when sumOfFactors < number => Classification.Deficient,
            int v when sumOfFactors > number => Classification.Abundant,
            _ => throw new NotSupportedException(),
        };
    }

    
}
