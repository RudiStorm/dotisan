using Dotisan.Faker.Core;

namespace Dotisan.Faker.Generators;

/// <summary>
/// Generator for fake phone number data
/// </summary>
public static class PhoneGenerator
{
    private static readonly string[] AreaCodes =
    [
        "011", "012", "013", "014", "015", "016", "017", "018", // Gauteng and surrounding areas
        "021", "022", "023", "027", "028", // Western Cape
        "031", "032", "033", "034", "035", "036", "039", // KwaZulu-Natal
        "041", "042", "043", "044", "045", "046", "047", "049", // Eastern Cape
        "051", "053", "054", "056", "057", "058", // Free State and Northern Cape
        "071", "072", "073", "074", "076", "078", "079", "081", "082", "083", "084" // Mobile numbers
    ];

    /// <summary>
    /// Generates a random South African phone number in 011 123 4567 format
    /// </summary>
    /// <returns>A random phone number</returns>
    public static string Number()
    {
        var areaCode = RandomProvider.NextElement(AreaCodes);
        var number = RandomProvider.Next(1000000, 9999999); // 7 digit number
        return $"{areaCode} {number:D7}";
    }

    /// <summary>
    /// Generates a random phone number in 011-123-4567 format
    /// </summary>
    /// <returns>A random phone number with dashes</returns>
    public static string NumberWithDashes()
    {
        var areaCode = RandomProvider.NextElement(AreaCodes);
        var first = RandomProvider.Next(100, 999);
        var second = RandomProvider.Next(1000, 9999);
        return $"{areaCode}-{first}-{second}";
    }

    /// <summary>
    /// Generates a random phone number with no formatting (10 digits)
    /// </summary>
    /// <returns>A random 10-digit phone number</returns>
    public static string NumberDigitsOnly()
    {
        var areaCode = RandomProvider.NextElement(AreaCodes);
        var number = RandomProvider.Next(1000000, 9999999);
        return $"{areaCode}{number}";
    }

    /// <summary>
    /// Generates a random area code
    /// </summary>
    /// <returns>A random area code</returns>
    public static string AreaCode() => RandomProvider.NextElement(AreaCodes);

    /// <summary>
    /// Generates a random mobile phone number
    /// </summary>
    /// <returns>A random mobile phone number</returns>
    public static string MobileNumber()
    {
        var mobileCodes = new[] { "071", "072", "073", "074", "076", "078", "079", "081", "082", "083", "084" };
        var areaCode = RandomProvider.NextElement(mobileCodes);
        var number = RandomProvider.Next(1000000, 9999999);
        return $"{areaCode} {number:D7}";
    }

    /// <summary>
    /// Generates a random landline phone number
    /// </summary>
    /// <returns>A random landline phone number</returns>
    public static string LandlineNumber()
    {
        var landlineCodes = new[] { "011", "012", "013", "014", "015", "016", "017", "018",
                                   "021", "022", "023", "027", "028",
                                   "031", "032", "033", "034", "035", "036", "039",
                                   "041", "042", "043", "044", "045", "046", "047", "049",
                                   "051", "053", "054", "056", "057", "058" };
        var areaCode = RandomProvider.NextElement(landlineCodes);
        var number = RandomProvider.Next(1000000, 9999999);
        return $"{areaCode} {number:D7}";
    }

    /// <summary>
    /// Generates a random toll-free number (0800 format)
    /// </summary>
    /// <returns>A random toll-free number</returns>
    public static string TollFreeNumber()
    {
        var number = RandomProvider.Next(100000, 999999);
        return $"0800 {number:D6}";
    }

    /// <summary>
    /// Generates a random South African international phone number (+27 format)
    /// </summary>
    /// <returns>A random international phone number</returns>
    public static string InternationalNumber()
    {
        var areaCode = RandomProvider.NextElement(AreaCodes);
        var number = RandomProvider.Next(1000000, 9999999);
        // Remove leading 0 for international format
        var internationalAreaCode = areaCode.StartsWith("0") ? areaCode[1..] : areaCode;
        return $"+27 {internationalAreaCode} {number:D7}";
    }
}
