using System;
using System.Collections.Generic;
public enum Allergen
{
    Eggs,       
    Peanuts,    
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private int _mask;
    public Allergies(int mask) => _mask = mask & TotalValuesOfAllergen();

    public bool IsAllergicTo(Allergen allergen) => 
        (_mask & ValueOfAllergen((int)allergen)) != 0;

    public Allergen[] List()
    {
        List<Allergen> possitiveAllergies = new List<Allergen>();
        foreach (Allergen allergen in IndexesOfAllergens)
        {
            if (IsAllergicTo(allergen))
                possitiveAllergies.Add(allergen);
        }
        return possitiveAllergies.ToArray();
    }

    private static Array IndexesOfAllergens => Enum.GetValues(typeof(Allergen));

    private int ValueOfAllergen(int allergenIndex) => 1 << allergenIndex;

    private int TotalValuesOfAllergen() 
    {
        int totalValues = 0;
        foreach (Allergen allergen in IndexesOfAllergens)
            totalValues += ValueOfAllergen((int)allergen);
        return totalValues;
    }
}