using Dotisan.Faker.Core;

namespace Dotisan.Faker.Generators;

/// <summary>
/// Generator for fake address data
/// </summary>
public static class AddressGenerator
{
    private static readonly string[] StreetSuffixes =
    [
        "St", "Ave", "Rd", "Dr", "Ln", "Way", "Close", "Crescent", "Circle", "Square",
        "Court", "Place", "Park", "Heights", "Grove", "Gardens", "View", "Rise"
    ];

    private static readonly string[] StreetNames =
    [
        "Commissioner", "Long", "Adderley", "Strand", "Church", "Jan Smuts", "Kloof", "Boom", "Main", "President",
        "Dr. Pixley Ka Isaka Seme", "Nelson Mandela", "Oliver Tambo", "Walter Sisulu", "Steve Biko", "Robert Sobukwe",
        "Sandton", "Rivonia", "Rosebank", "Melville", "Observatory", "Green Point", "Sea Point", "Camps Bay",
        "Hout Bay", "Constantia", "Wynberg", "Claremont", "Newlands", "Rondebosch", "Mowbray", "Salt River",
        "Woodstock", "Observatory", "Goodwood", "Bellville", "Parow", "Durbanville", "Stellenbosch", "Paarl",
        "Somerset", "Victoria", "Elizabeth", "George", "Edward", "Albert", "Margaret", "Queen", "King", "Prince",
        "Voortrekker", "Van der Merwe", "Pretorius", "Potgieter", "De Villiers", "Van Zyl", "Botha", "Kruger",
        "Rhodes", "Jameson", "Milner", "Smuts", "Bosman", "Prinsloo", "Joubert", "Marais", "Nel", "Du Toit"
    ];

    private static readonly string[] Cities =
    [
        "Johannesburg", "Cape Town", "Durban", "Pretoria", "Port Elizabeth", "Bloemfontein", "East London", "Pietermaritzburg",
        "Nelspruit", "Kimberley", "Polokwane", "Rustenburg", "George", "Welkom", "Klerksdorp", "Potchefstroom",
        "Vanderbijlpark", "Centurion", "Roodepoort", "Boksburg", "Benoni", "Tembisa", "Soweto", "Sandton",
        "Midrand", "Randburg", "Germiston", "Springs", "Alberton", "Kempton Park", "Edenvale", "Brakpan",
        "Stellenbosch", "Paarl", "Worcester", "Oudtshoorn", "Mossel Bay", "Knysna", "Hermanus", "Swellendam",
        "Upington", "Kuruman", "Kathu", "Springbok", "Calvinia", "Colesberg", "De Aar", "Hanover",
        "Witbank", "Secunda", "Standerton", "Volksrust", "Newcastle", "Ladysmith", "Estcourt", "Kokstad"
    ];

    private static readonly string[] Provinces =
    [
        "Eastern Cape", "Free State", "Gauteng", "KwaZulu-Natal", "Limpopo",
        "Mpumalanga", "North West", "Northern Cape", "Western Cape"
    ];

    private static readonly string[] ProvinceAbbreviations =
    [
        "EC", "FS", "GP", "KZN", "LP", "MP", "NW", "NC", "WC"
    ];

    /// <summary>
    /// Generates a random street address
    /// </summary>
    /// <returns>A random street address</returns>
    public static string StreetAddress()
    {
        var number = RandomProvider.Next(1, 9999);
        var street = RandomProvider.NextElement(StreetNames);
        var suffix = RandomProvider.NextElement(StreetSuffixes);
        return $"{number} {street} {suffix}";
    }

    /// <summary>
    /// Generates a random apartment or unit number
    /// </summary>
    /// <returns>A random apartment number</returns>
    public static string ApartmentNumber()
    {
        var formats = new[] { "Apt {0}", "Unit {0}", "Suite {0}", "#{0}" };
        var format = RandomProvider.NextElement(formats);
        var number = RandomProvider.Next(1, 999);
        return string.Format(format, number);
    }

    /// <summary>
    /// Generates a random city name
    /// </summary>
    /// <returns>A random city name</returns>
    public static string City() => RandomProvider.NextElement(Cities);

    /// <summary>
    /// Generates a random province name
    /// </summary>
    /// <returns>A random province name</returns>
    public static string Province() => RandomProvider.NextElement(Provinces);

    /// <summary>
    /// Generates a random province abbreviation
    /// </summary>
    /// <returns>A random province abbreviation</returns>
    public static string ProvinceAbbreviation() => RandomProvider.NextElement(ProvinceAbbreviations);

    /// <summary>
    /// Generates a random postal code (4 digits)
    /// </summary>
    /// <returns>A random postal code</returns>
    public static string PostalCode()
    {
        return $"{RandomProvider.Next(1000, 9999)}";
    }

    /// <summary>
    /// Generates a complete random address
    /// </summary>
    /// <returns>A complete random address</returns>
    public static string FullAddress()
    {
        return $"{StreetAddress()}, {City()}, {ProvinceAbbreviation()} {PostalCode()}";
    }

    /// <summary>
    /// Generates a complete random address with apartment
    /// </summary>
    /// <returns>A complete random address with apartment</returns>
    public static string FullAddressWithApartment()
    {
        return $"{StreetAddress()} {ApartmentNumber()}, {City()}, {ProvinceAbbreviation()} {PostalCode()}";
    }
}
