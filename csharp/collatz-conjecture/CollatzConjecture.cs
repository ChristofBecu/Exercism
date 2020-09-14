using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int steps = 0;
        if ( number <= 0 )
            throw new ArgumentException();
        while ( number > 1 ) {
            steps++;
            if ( (number & 1) == 0)
                number /= 2;
            else
                number = number * 3 + 1;
        }
        return steps;
    }
}