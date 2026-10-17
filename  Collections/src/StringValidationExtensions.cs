using System;
using System.Text.RegularExpressions;

public static class StringValidationExtensions
{
    public static bool IsValidEgyptianPhone(this string phone)
    {
        return !string.IsNullOrWhiteSpace(phone) && System.Text.RegularExpressions.Regex.IsMatch(phone, @"^(\+20|0)?1[0125][0-9]{8}$") && ( phone.Length == 11 || phone.Length == 13 ) ;
    }

    public static bool IsValidEgyptianNationalId(this string nationalId)
    {
        return !string.IsNullOrWhiteSpace(nationalId) && Regex.IsMatch(nationalId, @"^[23]\d{13}$");   
    }   
}
