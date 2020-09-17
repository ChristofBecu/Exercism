using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        phoneNumber = Regex.Replace(phoneNumber, "[^0-9]", "");
        
        if (phoneNumber.Length < 10 ||  phoneNumber.Length > 11 )
            throw new ArgumentException();
        
        // Country code
        if ( phoneNumber.Length == 11 ) {
            if ( !phoneNumber.StartsWith('1') )
                throw new ArgumentException();
            phoneNumber = phoneNumber.Substring(1);
        }
        // Area code
        if ( phoneNumber.StartsWith('0') || phoneNumber.StartsWith('1') )
            throw new ArgumentException();
        
        // Exchange code
        if ( phoneNumber[3] == '0' || phoneNumber[3] == '1' )
            throw new ArgumentException();

        return phoneNumber; 
    }
}