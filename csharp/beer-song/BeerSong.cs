using System;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        string song = "";

        while (--takeDown >= 0)
        {
            song += startBottles switch
            {
                2 => ManyBottles(startBottles) + TakeLastButOne(--startBottles),

                1 => OneBottle(startBottles--),

                0 => NoBottles(),

                _ => ManyBottles(startBottles) + TakeOne(--startBottles)
            };

            if (takeDown == 0)
                continue;
            song += "\n\n";
        }
        return song;
    }

    private static string ManyBottles(int number) => 
        $"{number} bottles of beer on the wall, {number} bottles of beer.\n";

    private static string OneBottle(int number) => 
        $"{number} bottle of beer on the wall, {number} bottle of beer.\n" +
        "Take it down and pass it around, no more bottles of beer on the wall.";

    private static string TakeOne(int number) =>
        $"Take one down and pass it around, {number} bottles of beer on the wall.";

    private static string TakeLastButOne(int number) =>
        $"Take one down and pass it around, {number} bottle of beer on the wall.";

    private static string NoBottles() =>
        "No more bottles of beer on the wall, no more bottles of beer.\n" +
        "Go to the store and buy some more, 99 bottles of beer on the wall.";
}