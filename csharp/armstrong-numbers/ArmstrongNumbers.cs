using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        var bases = number.ToString().ToCharArray().Select(c => (byte)c - 48);
        var exponent = bases.Count();
        double armstrong = 0.0;

        foreach (int b in bases)
            armstrong += Math.Pow(b, exponent);

        return armstrong == number;
    }
}