using System.Linq;
using System;
using System.Linq;
using System.Collections.Generic;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string rain = "";

        rain += number.HasFactor(3, "Pling");
        rain += number.HasFactor(5, "Plang");
        rain += number.HasFactor(7, "Plong");

        if (string.IsNullOrEmpty(rain))
            return number.ToString();

        return rain;
    }

    private static string HasFactor(this int number, int factor, string drop) => 
        (number % factor == 0) ? drop : null;
}