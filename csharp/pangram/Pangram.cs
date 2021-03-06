﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var alphabet = new HashSet<char>("abcdefghijklmnopqrstuvwxyz");
        var cleanInput = new HashSet<char>(input.ToLower());
        bool IsNotLetter(char c) => !char.IsLetter(c);
        cleanInput.RemoveWhere(character => IsNotLetter(character));
        return cleanInput.SetEquals(alphabet);
    }
}
