using System;
using System.Collections.Generic;

public class Robot
{
    private static HashSet<string> storedNames = new HashSet<string>();
    private static Random _random = new Random();
    public string Name { get; private set; }
    public Robot() => Name = GenerateUniqueName();
    
    public void Reset()
    {
        storedNames.Remove(Name);
        Name = GenerateUniqueName();
    }

    private string GenerateUniqueName()
    {
        string uniqueName;
            do 
                uniqueName = GetRandomName();
            while (!storedNames.Add(uniqueName));
        return uniqueName;
    }

    private static string GetRandomName() => 
        GetRandomLetter() + GetRandomLetter() +
        GetRandomDigit() + GetRandomDigit() + GetRandomDigit();

    private static string GetRandomLetter() => 
        (((char)('A' + _random.Next(0, 26))).ToString());

    private static string GetRandomDigit() => 
        _random.Next(0, 10).ToString();
}