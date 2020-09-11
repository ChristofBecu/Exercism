using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> highscores;
    public HighScores(List<int> list) => highscores = list;

    public List<int> Scores() => highscores;

    public int Latest() => highscores.Last();

    public int PersonalBest() => highscores.Max();

    public List<int> PersonalTopThree() => 
        highscores.OrderByDescending(score => score).Take(3).ToList();
}