using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n <= 0 || n > 64)
            throw new ArgumentOutOfRangeException();
        return n == 1 ? 1 : 1UL << (n - 1);
    }
    public static ulong Total() => 2 * ((1UL << 63) - 1 ) + 1;
}