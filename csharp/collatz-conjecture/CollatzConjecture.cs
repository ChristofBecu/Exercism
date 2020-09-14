using System;

public static class CollatzConjecture
{
    public static int Steps(int number) =>
        number < 1
            ? throw new ArgumentOutOfRangeException()
            : number == 1
                ? 0
                : number % 2 == 0
                    ? Steps(number /= 2) + 1
                    : Steps(number * 3 + 1) + 1;
}