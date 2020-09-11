using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        // 
        char[] inputArray = input.ToCharArray();
        Array.Reverse( inputArray );
        return new string( inputArray );

        // Classic reverse of string
        /*
        string reversedString = ""; 
        for ( int i = input.Length-1; i >= 0; i-- ) 
            reversedString += input[i];
        return reversedString; 
        */

        // Recusive ternary operator
        /*
        return ( input == "") ? "" : Reverse(input.Substring(1)) + input[0];
        */
        
    }
}