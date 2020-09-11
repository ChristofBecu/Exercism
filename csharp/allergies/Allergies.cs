using System;
using System.Collections.Generic;
using System.Linq;

[Flags]
public enum Allergen
{
    Eggs = 1,       
    Peanuts = 2,    
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private Allergen possitiveAllergens;
    public Allergies(int mask) => possitiveAllergens = (Allergen)mask;
    public bool IsAllergicTo(Allergen allergen) => 
        (possitiveAllergens & allergen) == allergen;

    public Allergen[] List() => 
        Enum.GetValues(typeof(Allergen))
            .Cast<Allergen>()
            .Where(predicate: IsAllergicTo)
            .ToArray<Allergen>();
}
