using Dotisan.Faker.Core;

namespace Dotisan.Faker.Generators;

/// <summary>
/// Generator for fake email addresses
/// </summary>
public static class EmailGenerator
{
    private static readonly string[] Domains =
    [
        "gmail.com", "yahoo.com", "outlook.com", "hotmail.com", "icloud.com", "protonmail.com",
        "live.com", "msn.com", "aol.com", "mail.com", "ymail.com", "gmx.com",
        "fastmail.com", "zoho.com", "tutanota.com", "hey.com", "superhuman.com"
    ];

    private static readonly string[] SouthAfricanDomains =
    [
        "co.za", "org.za", "gov.za", "edu.za", "net.za", "webmail.co.za",
        "gmail.com", "yahoo.co.za", "outlook.co.za", "hotmail.co.za", "mweb.co.za",
        "telkomsa.net", "vodamail.co.za", "iafrica.com", "saol.com"
    ];

    /// <summary>
    /// Generates a random email address
    /// </summary>
    /// <returns>A random email address</returns>
    public static string Address()
    {
        var username = GenerateUsername();
        var domain = RandomProvider.NextElement(Domains);
        return $"{username}@{domain}";
    }

    /// <summary>
    /// Generates a random South African email address
    /// </summary>
    /// <returns>A random South African email address</returns>
    public static string SouthAfricanAddress()
    {
        var username = GenerateUsername();
        var domain = RandomProvider.NextElement(SouthAfricanDomains);
        return $"{username}@{domain}";
    }

    /// <summary>
    /// Generates a random email address using a specific domain
    /// </summary>
    /// <param name="domain">The domain to use for the email</param>
    /// <returns>A random email address with the specified domain</returns>
    public static string AddressWithDomain(string domain)
    {
        var username = GenerateUsername();
        return $"{username}@{domain}";
    }

    /// <summary>
    /// Generates a random business/corporate email address
    /// </summary>
    /// <returns>A random corporate email address</returns>
    public static string CorporateAddress()
    {
        var username = GenerateUsername();
        var company = CompanyName().ToLowerInvariant().Replace(" ", "");
        return $"{username}@{company}.co.za";
    }

    /// <summary>
    /// Generates a random disposable/temporary email address
    /// </summary>
    /// <returns>A random disposable email address</returns>
    public static string DisposableAddress()
    {
        var disposableDomains = new[]
        {
            "10minutemail.com", "tempmail.org", "guerrillamail.com", "mailinator.com",
            "temp-mail.org", "throwaway.email", "maildrop.cc", "sharklasers.com"
        };

        var username = GenerateUsername();
        var domain = RandomProvider.NextElement(disposableDomains);
        return $"{username}@{domain}";
    }

    private static string GenerateUsername()
    {
        var patterns = new[]
        {
            () => NameGenerator.FirstName().ToLowerInvariant(),
            () => $"{NameGenerator.FirstName().ToLowerInvariant()}.{NameGenerator.LastName().ToLowerInvariant()}",
            () => $"{NameGenerator.FirstName().ToLowerInvariant()}{NameGenerator.LastName().ToLowerInvariant()}",
            () => $"{NameGenerator.FirstName().ToLowerInvariant()}{RandomProvider.Next(1, 999)}",
            () => $"{NameGenerator.FirstName().ToLowerInvariant()}.{NameGenerator.LastName().ToLowerInvariant()}{RandomProvider.Next(1, 99)}",
            () => $"{NameGenerator.FirstName()[..1].ToLowerInvariant()}.{NameGenerator.LastName().ToLowerInvariant()}",
            () => $"{NameGenerator.FirstName().ToLowerInvariant()}_{NameGenerator.LastName().ToLowerInvariant()}"
        };

        var pattern = RandomProvider.NextElement(patterns);
        return pattern();
    }

    private static string CompanyName()
    {
        var companies = new[]
        {
            "Absa Bank", "Standard Bank", "FNB", "Nedbank", "Capitec", "Discovery", "Old Mutual", "Sanlam",
            "MTN", "Vodacom", "Cell C", "Telkom", "Shoprite", "Pick n Pay", "Woolworths", "Clicks",
            "Tiger Brands", "Naspers", "Sasol", "Anglo American", "BHP Billiton", "Gold Fields", "Impala Platinum",
            "Mr Price", "Truworths", "Foschini", "Edcon", "Massmart", "Steinhoff", "Bidvest"
        };

        return RandomProvider.NextElement(companies);
    }
}
