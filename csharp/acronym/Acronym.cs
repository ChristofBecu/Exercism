﻿using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase) =>
        new string(
            phrase.Split(new char[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => char.ToUpper(word[0]))
                .ToArray()
            );
}