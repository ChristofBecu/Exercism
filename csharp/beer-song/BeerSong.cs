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
                2 => $"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\n" +
                     $"Take one down and pass it around, {--startBottles} bottle of beer on the wall.",

                1 => $"{startBottles} bottle of beer on the wall, {startBottles--} bottle of beer.\n" +
                     "Take it down and pass it around, no more bottles of beer on the wall.",

                0 => "No more bottles of beer on the wall, no more bottles of beer.\n" +
                     "Go to the store and buy some more, 99 bottles of beer on the wall.",

                _ => $"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\n" +
                     $"Take one down and pass it around, {--startBottles} bottles of beer on the wall."
            };

            if (takeDown == 0)
                continue;
            song += "\n\n";
        }
        return song;
    }
}