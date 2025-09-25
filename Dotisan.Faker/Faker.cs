using Dotisan.Faker.Core;
using Dotisan.Faker.Generators;

namespace Dotisan.Faker;

/// <summary>
/// Main Faker class providing easy access to all generators with optional seeding support
/// </summary>
public static class Faker
{
    /// <summary>
    /// Name generator for generating fake names
    /// </summary>
    public static class Name
    {
        /// <summary>
        /// Generates a random first name
        /// </summary>
        /// <returns>A random first name</returns>
        public static string First() => NameGenerator.FirstName();

        /// <summary>
        /// Generates a random last name
        /// </summary>
        /// <returns>A random last name</returns>
        public static string Last() => NameGenerator.LastName();

        /// <summary>
        /// Generates a random full name
        /// </summary>
        /// <returns>A random full name</returns>
        public static string FullName() => NameGenerator.FullName();

        /// <summary>
        /// Generates a random full name with middle initial
        /// </summary>
        /// <returns>A random full name with middle initial</returns>
        public static string FullNameWithMiddleInitial() => NameGenerator.FullNameWithMiddleInitial();

        /// <summary>
        /// Generates a random name prefix
        /// </summary>
        /// <returns>A random name prefix</returns>
        public static string Prefix() => NameGenerator.Prefix();

        /// <summary>
        /// Generates a random name suffix
        /// </summary>
        /// <returns>A random name suffix</returns>
        public static string Suffix() => NameGenerator.Suffix();
    }

    /// <summary>
    /// Address generator for generating fake addresses
    /// </summary>
    public static class Address
    {
        /// <summary>
        /// Generates a random street address
        /// </summary>
        /// <returns>A random street address</returns>
        public static string StreetAddress() => AddressGenerator.StreetAddress();

        /// <summary>
        /// Generates a random apartment number
        /// </summary>
        /// <returns>A random apartment number</returns>
        public static string ApartmentNumber() => AddressGenerator.ApartmentNumber();

        /// <summary>
        /// Generates a random city name
        /// </summary>
        /// <returns>A random city name</returns>
        public static string City() => AddressGenerator.City();

        /// <summary>
        /// Generates a random province name
        /// </summary>
        /// <returns>A random province name</returns>
        public static string Province() => AddressGenerator.Province();

        /// <summary>
        /// Generates a random province abbreviation
        /// </summary>
        /// <returns>A random province abbreviation</returns>
        public static string ProvinceAbbreviation() => AddressGenerator.ProvinceAbbreviation();

        /// <summary>
        /// Generates a random postal code
        /// </summary>
        /// <returns>A random postal code</returns>
        public static string PostalCode() => AddressGenerator.PostalCode();

        /// <summary>
        /// Generates a complete random address
        /// </summary>
        /// <returns>A complete random address</returns>
        public static string FullAddress() => AddressGenerator.FullAddress();

        /// <summary>
        /// Generates a complete random address with apartment
        /// </summary>
        /// <returns>A complete random address with apartment</returns>
        public static string FullAddressWithApartment() => AddressGenerator.FullAddressWithApartment();
    }

    /// <summary>
    /// Phone generator for generating fake phone numbers
    /// </summary>
    public static class Phone
    {
        /// <summary>
        /// Generates a random phone number
        /// </summary>
        /// <returns>A random phone number</returns>
        public static string Number() => PhoneGenerator.Number();

        /// <summary>
        /// Generates a random phone number with dashes
        /// </summary>
        /// <returns>A random phone number with dashes</returns>
        public static string NumberWithDashes() => PhoneGenerator.NumberWithDashes();

        /// <summary>
        /// Generates a random phone number with no formatting
        /// </summary>
        /// <returns>A random phone number with no formatting</returns>
        public static string NumberDigitsOnly() => PhoneGenerator.NumberDigitsOnly();

        /// <summary>
        /// Generates a random area code
        /// </summary>
        /// <returns>A random area code</returns>
        public static string AreaCode() => PhoneGenerator.AreaCode();

        /// <summary>
        /// Generates a random mobile phone number
        /// </summary>
        /// <returns>A random mobile phone number</returns>
        public static string MobileNumber() => PhoneGenerator.MobileNumber();

        /// <summary>
        /// Generates a random landline phone number
        /// </summary>
        /// <returns>A random landline phone number</returns>
        public static string LandlineNumber() => PhoneGenerator.LandlineNumber();

        /// <summary>
        /// Generates a random toll-free number
        /// </summary>
        /// <returns>A random toll-free number</returns>
        public static string TollFreeNumber() => PhoneGenerator.TollFreeNumber();

        /// <summary>
        /// Generates a random international phone number
        /// </summary>
        /// <returns>A random international phone number</returns>
        public static string InternationalNumber() => PhoneGenerator.InternationalNumber();
    }

    /// <summary>
    /// Email generator for generating fake email addresses
    /// </summary>
    public static class Email
    {
        /// <summary>
        /// Generates a random email address
        /// </summary>
        /// <returns>A random email address</returns>
        public static string Address() => EmailGenerator.Address();

        /// <summary>
        /// Generates a random South African email address
        /// </summary>
        /// <returns>A random South African email address</returns>
        public static string SouthAfricanAddress() => EmailGenerator.SouthAfricanAddress();

        /// <summary>
        /// Generates a random email address with a specific domain
        /// </summary>
        /// <param name="domain">The domain to use</param>
        /// <returns>A random email address with the specified domain</returns>
        public static string AddressWithDomain(string domain) => EmailGenerator.AddressWithDomain(domain);

        /// <summary>
        /// Generates a random corporate email address
        /// </summary>
        /// <returns>A random corporate email address</returns>
        public static string CorporateAddress() => EmailGenerator.CorporateAddress();

        /// <summary>
        /// Generates a random disposable email address
        /// </summary>
        /// <returns>A random disposable email address</returns>
        public static string DisposableAddress() => EmailGenerator.DisposableAddress();
    }

    /// <summary>
    /// Lorem generator for generating fake Lorem Ipsum text
    /// </summary>
    public static class Lorem
    {
        /// <summary>
        /// Generates a single Lorem Ipsum word
        /// </summary>
        /// <returns>A random Lorem word</returns>
        public static string Word() => LoremGenerator.Word();

        /// <summary>
        /// Generates multiple Lorem Ipsum words
        /// </summary>
        /// <param name="count">Number of words to generate</param>
        /// <returns>Random Lorem words</returns>
        public static string Words(int count = 3) => LoremGenerator.Words(count);

        /// <summary>
        /// Generates a Lorem Ipsum sentence
        /// </summary>
        /// <param name="wordCount">Number of words in the sentence</param>
        /// <returns>A random Lorem sentence</returns>
        public static string Sentence(int? wordCount = null) => LoremGenerator.Sentence(wordCount);

        /// <summary>
        /// Generates multiple Lorem Ipsum sentences
        /// </summary>
        /// <param name="count">Number of sentences to generate</param>
        /// <returns>Random Lorem sentences</returns>
        public static string Sentences(int count = 3) => LoremGenerator.Sentences(count);

        /// <summary>
        /// Generates a Lorem Ipsum paragraph
        /// </summary>
        /// <param name="sentenceCount">Number of sentences in the paragraph</param>
        /// <returns>A random Lorem paragraph</returns>
        public static string Paragraph(int? sentenceCount = null) => LoremGenerator.Paragraph(sentenceCount);

        /// <summary>
        /// Generates multiple Lorem Ipsum paragraphs
        /// </summary>
        /// <param name="count">Number of paragraphs to generate</param>
        /// <returns>Random Lorem paragraphs</returns>
        public static string Paragraphs(int count = 3) => LoremGenerator.Paragraphs(count);

        /// <summary>
        /// Generates Lorem Ipsum text of approximately the specified character length
        /// </summary>
        /// <param name="characterCount">Approximate number of characters</param>
        /// <returns>Lorem text</returns>
        public static string Text(int characterCount = 200) => LoremGenerator.Text(characterCount);

        /// <summary>
        /// Generates a Lorem Ipsum slug
        /// </summary>
        /// <param name="wordCount">Number of words in the slug</param>
        /// <returns>A Lorem slug</returns>
        public static string Slug(int wordCount = 3) => LoremGenerator.Slug(wordCount);
    }

    /// <summary>
    /// Number generator for generating fake numeric data
    /// </summary>
    public static class Number
    {
        /// <summary>
        /// Generates a random integer
        /// </summary>
        /// <param name="max">Maximum value (exclusive)</param>
        /// <returns>A random integer</returns>
        public static int Integer(int max = 100) => NumberGenerator.Integer(max);

        /// <summary>
        /// Generates a random integer within a range
        /// </summary>
        /// <param name="min">Minimum value (inclusive)</param>
        /// <param name="max">Maximum value (exclusive)</param>
        /// <returns>A random integer</returns>
        public static int Integer(int min, int max) => NumberGenerator.Integer(min, max);

        /// <summary>
        /// Generates a random double
        /// </summary>
        /// <returns>A random double value</returns>
        public static double Double() => NumberGenerator.Double();

        /// <summary>
        /// Generates a random double within a range
        /// </summary>
        /// <param name="min">Minimum value</param>
        /// <param name="max">Maximum value</param>
        /// <returns>A random double</returns>
        public static double Double(double min, double max) => NumberGenerator.Double(min, max);

        /// <summary>
        /// Generates a random decimal
        /// </summary>
        /// <param name="max">Maximum value</param>
        /// <returns>A random decimal</returns>
        public static decimal Decimal(decimal max = 100m) => NumberGenerator.Decimal(max);

        /// <summary>
        /// Generates a random decimal within a range
        /// </summary>
        /// <param name="min">Minimum value</param>
        /// <param name="max">Maximum value</param>
        /// <returns>A random decimal</returns>
        public static decimal Decimal(decimal min, decimal max) => NumberGenerator.Decimal(min, max);

        /// <summary>
        /// Generates a random boolean
        /// </summary>
        /// <returns>A random boolean</returns>
        public static bool Boolean() => NumberGenerator.Boolean();

        /// <summary>
        /// Generates a random byte
        /// </summary>
        /// <returns>A random byte</returns>
        public static byte Byte() => NumberGenerator.Byte();

        /// <summary>
        /// Generates a random percentage
        /// </summary>
        /// <returns>A random percentage</returns>
        public static int Percentage() => NumberGenerator.Percentage();

        /// <summary>
        /// Generates a random currency amount
        /// </summary>
        /// <param name="min">Minimum amount</param>
        /// <param name="max">Maximum amount</param>
        /// <returns>A random currency amount</returns>
        public static decimal Currency(decimal min = 0m, decimal max = 10000m) => NumberGenerator.Currency(min, max);

        /// <summary>
        /// Generates a formatted currency string
        /// </summary>
        /// <param name="min">Minimum amount</param>
        /// <param name="max">Maximum amount</param>
        /// <returns>A formatted currency string</returns>
        public static string CurrencyString(decimal min = 0m, decimal max = 10000m) => NumberGenerator.CurrencyString(min, max);

        /// <summary>
        /// Generates a random digit character
        /// </summary>
        /// <returns>A random digit character</returns>
        public static char Digit() => NumberGenerator.Digit();

        /// <summary>
        /// Generates a string of random digits
        /// </summary>
        /// <param name="length">Length of the digit string</param>
        /// <returns>A string of random digits</returns>
        public static string Digits(int length) => NumberGenerator.Digits(length);
    }

    /// <summary>
    /// Date generator for generating fake date and time data
    /// </summary>
    public static class Date
    {
        /// <summary>
        /// Generates a random date between two dates
        /// </summary>
        /// <param name="from">Start date</param>
        /// <param name="to">End date</param>
        /// <returns>A random date</returns>
        public static System.DateTime Between(System.DateTime from, System.DateTime to) => DateGenerator.Between(from, to);

        /// <summary>
        /// Generates a random past date
        /// </summary>
        /// <param name="yearsBack">Number of years to go back</param>
        /// <returns>A random past date</returns>
        public static System.DateTime Past(int yearsBack = 1) => DateGenerator.Past(yearsBack);

        /// <summary>
        /// Generates a random future date
        /// </summary>
        /// <param name="yearsForward">Number of years to go forward</param>
        /// <returns>A random future date</returns>
        public static System.DateTime Future(int yearsForward = 1) => DateGenerator.Future(yearsForward);

        /// <summary>
        /// Generates a random date this year
        /// </summary>
        /// <returns>A random date this year</returns>
        public static System.DateTime ThisYear() => DateGenerator.ThisYear();

        /// <summary>
        /// Generates a random date this month
        /// </summary>
        /// <returns>A random date this month</returns>
        public static System.DateTime ThisMonth() => DateGenerator.ThisMonth();

        /// <summary>
        /// Generates a random birthdate
        /// </summary>
        /// <param name="minAge">Minimum age</param>
        /// <param name="maxAge">Maximum age</param>
        /// <returns>A random birthdate</returns>
        public static System.DateTime Birthdate(int minAge = 18, int maxAge = 80) => DateGenerator.Birthdate(minAge, maxAge);

        /// <summary>
        /// Generates a random time of day
        /// </summary>
        /// <returns>A random time of day</returns>
        public static System.TimeSpan TimeOfDay() => DateGenerator.TimeOfDay();

        /// <summary>
        /// Generates a random datetime
        /// </summary>
        /// <param name="from">Start datetime</param>
        /// <param name="to">End datetime</param>
        /// <returns>A random datetime</returns>
        public static System.DateTime DateTime(System.DateTime from, System.DateTime to) => DateGenerator.DateTime(from, to);

        /// <summary>
        /// Generates a random datetime in the recent past
        /// </summary>
        /// <param name="daysBack">Number of days to go back</param>
        /// <returns>A random past datetime</returns>
        public static System.DateTime RecentPast(int daysBack = 365) => DateGenerator.RecentPast(daysBack);

        /// <summary>
        /// Generates a random datetime in the near future
        /// </summary>
        /// <param name="daysForward">Number of days to go forward</param>
        /// <returns>A random future datetime</returns>
        public static System.DateTime NearFuture(int daysForward = 365) => DateGenerator.NearFuture(daysForward);

        /// <summary>
        /// Generates a random Unix timestamp
        /// </summary>
        /// <returns>A random Unix timestamp</returns>
        public static long UnixTimestamp() => DateGenerator.UnixTimestamp();

        /// <summary>
        /// Generates a random ISO 8601 date string
        /// </summary>
        /// <returns>A random ISO 8601 date string</returns>
        public static string Iso8601() => DateGenerator.Iso8601();
    }

    /// <summary>
    /// Sets a seed for the random number generator to ensure reproducible results
    /// </summary>
    /// <param name="seed">The seed value to use</param>
    /// <remarks>
    /// Use seeded generation to create consistent test data across test runs.
    /// We recommend using seeds in tests to make them deterministic and repeatable.
    /// </remarks>
    public static void Seed(int seed)
    {
        RandomProvider.SetSeed(seed);
    }

    /// <summary>
    /// Gets the current seed value if one has been set
    /// </summary>
    /// <returns>The current seed value, or null if no seed is set</returns>
    public static int? CurrentSeed => RandomProvider.CurrentSeed;

    /// <summary>
    /// Resets the faker to use a non-seeded random generator
    /// </summary>
    /// <remarks>
    /// Use Reset() to return to truly random data generation after using Seed().
    /// </remarks>
    public static void Reset()
    {
        RandomProvider.Reset();
    }
}
