using Dotisan.Faker.Core;

namespace Dotisan.Faker.Generators;

/// <summary>
/// Generator for fake name data
/// </summary>
public static class NameGenerator
{
    private static readonly string[] FirstNames =
    [
        // English/Afrikaans names
        "Pieter", "Johan", "Andries", "Francois", "Dirk", "Hennie", "Kobus", "Nico", "Stefan", "Andre",
        "Willem", "Christo", "Riaan", "Jannie", "Danie", "Hannes", "Gerrit", "Marius", "Adriaan", "Casper",
        "Susan", "Annemarie", "Marinda", "Charlene", "Elmarie", "Ilse", "Leanne", "Marelize", "Chantel", "Ronel",
        "Annalize", "Maretha", "Lizelle", "Charmaine", "Juanita", "Sunette", "Melinda", "Rozanne", "Chrisna", "Elsa",

        // African names
        "Thabo", "Sipho", "Mandla", "Bongani", "Sello", "Lucky", "Gift", "Blessing", "Wisdom", "Justice",
        "Thabiso", "Tshepo", "Lebohang", "Kgothatso", "Kagiso", "Phenyo", "Tumelo", "Tebogo", "Rethabile", "Lerato",
        "Nomsa", "Zanele", "Thandiwe", "Nomthandazo", "Nokuthula", "Nomfundo", "Zinhle", "Precious", "Princess", "Queen",
        "Naledi", "Palesa", "Refilwe", "Kgomotso", "Boitumelo", "Dimakatso", "Mmabatho", "Mpho", "Tshegofatso", "Amogelang",

        // Indian/Coloured names
        "Anil", "Sunil", "Ravi", "Raj", "Deepak", "Vikram", "Ashwin", "Deven", "Nitin", "Rohan",
        "Priya", "Sunita", "Kavitha", "Meera", "Shanti", "Asha", "Kamala", "Geeta", "Radha", "Usha"
    ];

    private static readonly string[] LastNames =
    [
        // Afrikaans surnames
        "Van der Merwe", "Botha", "Pretorius", "Van Zyl", "Potgieter", "Du Toit", "Van der Walt", "Nel", "Fourie", "Kruger",
        "Bezuidenhout", "Steyn", "Viljoen", "Oosthuizen", "Liebenberg", "Swanepoel", "Du Preez", "De Wet", "Coetzee", "Smit",

        // English surnames
        "Smith", "Brown", "Jones", "Williams", "Johnson", "Wilson", "Miller", "Davis", "Anderson", "Thompson",
        "White", "Harris", "Clark", "Lewis", "Robinson", "Walker", "Hall", "Allen", "Young", "King",

        // African surnames
        "Mthembu", "Nkomo", "Sithole", "Moyo", "Ncube", "Dlamini", "Khumalo", "Mhlanga", "Sibanda", "Ndlovu",
        "Mahlangu", "Mokone", "Molefe", "Motsoeneng", "Seabi", "Tau", "Mofokeng", "Tladi", "Sello", "Phiri",
        "Ntuli", "Zulu", "Cele", "Ngcobo", "Gumede", "Hadebe", "Masuku", "Khoza", "Shabalala", "Buthelezi",

        // Indian surnames
        "Patel", "Reddy", "Naidoo", "Singh", "Pillay", "Maharaj", "Padayachee", "Moodley", "Chetty", "Naicker",
        "Devi", "Sharma", "Kumar", "Das", "Rao", "Murugan", "Krishnan", "Raman", "Sinha", "Gupta"
    ];

    /// <summary>
    /// Generates a random first name
    /// </summary>
    /// <returns>A random first name</returns>
    public static string FirstName() => RandomProvider.NextElement(FirstNames);

    /// <summary>
    /// Generates a random last name
    /// </summary>
    /// <returns>A random last name</returns>
    public static string LastName() => RandomProvider.NextElement(LastNames);

    /// <summary>
    /// Generates a random full name (first and last)
    /// </summary>
    /// <returns>A random full name</returns>
    public static string FullName() => $"{FirstName()} {LastName()}";

    /// <summary>
    /// Generates a random full name with middle initial
    /// </summary>
    /// <returns>A random full name with middle initial</returns>
    public static string FullNameWithMiddleInitial()
    {
        var middleInitial = (char)RandomProvider.Next('A', 'Z' + 1);
        return $"{FirstName()} {middleInitial}. {LastName()}";
    }

    /// <summary>
    /// Generates a random name prefix (Mr., Mrs., Ms., Dr., etc.)
    /// </summary>
    /// <returns>A random name prefix</returns>
    public static string Prefix()
    {
        string[] prefixes = ["Mr.", "Mrs.", "Ms.", "Miss", "Dr.", "Prof.", "Adv.", "Rev.", "Mnr.", "Mev.", "Mejuffrou"];
        return RandomProvider.NextElement(prefixes);
    }

    /// <summary>
    /// Generates a random name suffix (Jr., Sr., III, etc.)
    /// </summary>
    /// <returns>A random name suffix</returns>
    public static string Suffix()
    {
        string[] suffixes = ["Jr.", "Sr.", "II", "III", "IV", "Snr.", "Jnr."];
        return RandomProvider.NextElement(suffixes);
    }
}
