using System;
using Dotisan.Faker.Core;

namespace Dotisan.Faker.Generators;

/// <summary>
/// Generator for fake date and time data
/// </summary>
public static class DateGenerator
{
    private static readonly DateTime UnixEpoch = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    /// <summary>
    /// Generates a random date between two dates
    /// </summary>
    /// <param name="from">Start date (inclusive)</param>
    /// <param name="to">End date (exclusive)</param>
    /// <returns>A random date within the specified range</returns>
    public static DateTime Between(DateTime from, DateTime to)
    {
        if (from >= to) throw new ArgumentException("From date must be earlier than to date");

        var range = (to - from).Ticks;
        var randomTicks = (long)(RandomProvider.NextDouble() * range);
        return from.AddTicks(randomTicks);
    }

    /// <summary>
    /// Generates a random past date within the last year
    /// </summary>
    /// <param name="yearsBack">Number of years to go back from today (default 1)</param>
    /// <returns>A random past date</returns>
    public static DateTime Past(int yearsBack = 1)
    {
        var to = DateTime.Now;
        var from = to.AddYears(-yearsBack);
        return Between(from, to);
    }

    /// <summary>
    /// Generates a random future date within the next year
    /// </summary>
    /// <param name="yearsForward">Number of years to go forward from today (default 1)</param>
    /// <returns>A random future date</returns>
    public static DateTime Future(int yearsForward = 1)
    {
        var from = DateTime.Now;
        var to = from.AddYears(yearsForward);
        return Between(from, to);
    }

    /// <summary>
    /// Generates a random date within the current year
    /// </summary>
    /// <returns>A random date this year</returns>
    public static DateTime ThisYear()
    {
        var now = DateTime.Now;
        var startOfYear = new DateTime(now.Year, 1, 1);
        var endOfYear = new DateTime(now.Year, 12, 31, 23, 59, 59);
        return Between(startOfYear, endOfYear);
    }

    /// <summary>
    /// Generates a random date within the current month
    /// </summary>
    /// <returns>A random date this month</returns>
    public static DateTime ThisMonth()
    {
        var now = DateTime.Now;
        var startOfMonth = new DateTime(now.Year, now.Month, 1);
        var endOfMonth = startOfMonth.AddMonths(1).AddTicks(-1);
        return Between(startOfMonth, endOfMonth);
    }

    /// <summary>
    /// Generates a random birthdate for a person of reasonable age
    /// </summary>
    /// <param name="minAge">Minimum age (default 18)</param>
    /// <param name="maxAge">Maximum age (default 80)</param>
    /// <returns>A random birthdate</returns>
    public static DateTime Birthdate(int minAge = 18, int maxAge = 80)
    {
        var now = DateTime.Now;
        var maxDate = now.AddYears(-minAge);
        var minDate = now.AddYears(-maxAge);
        return Between(minDate, maxDate);
    }

    /// <summary>
    /// Generates a random time of day
    /// </summary>
    /// <returns>A random TimeSpan representing time of day</returns>
    public static TimeSpan TimeOfDay()
    {
        var totalSeconds = RandomProvider.Next(0, 24 * 60 * 60);
        return TimeSpan.FromSeconds(totalSeconds);
    }

    /// <summary>
    /// Generates a random DateTime with both date and time components
    /// </summary>
    /// <param name="from">Start datetime (inclusive)</param>
    /// <param name="to">End datetime (exclusive)</param>
    /// <returns>A random datetime within the specified range</returns>
    public static DateTime DateTime(DateTime from, DateTime to)
    {
        return Between(from, to);
    }

    /// <summary>
    /// Generates a random datetime in the past
    /// </summary>
    /// <param name="daysBack">Number of days to go back (default 365)</param>
    /// <returns>A random past datetime</returns>
    public static DateTime RecentPast(int daysBack = 365)
    {
        var to = System.DateTime.Now;
        var from = to.AddDays(-daysBack);
        return Between(from, to);
    }

    /// <summary>
    /// Generates a random datetime in the future
    /// </summary>
    /// <param name="daysForward">Number of days to go forward (default 365)</param>
    /// <returns>A random future datetime</returns>
    public static DateTime NearFuture(int daysForward = 365)
    {
        var from = System.DateTime.Now;
        var to = from.AddDays(daysForward);
        return Between(from, to);
    }

    /// <summary>
    /// Generates a random Unix timestamp
    /// </summary>
    /// <returns>A random Unix timestamp</returns>
    public static long UnixTimestamp()
    {
        var randomDate = Past(50); // Random date in last 50 years
        return ((DateTimeOffset)randomDate).ToUnixTimeSeconds();
    }

    /// <summary>
    /// Generates a random ISO 8601 formatted date string
    /// </summary>
    /// <returns>A random ISO 8601 date string</returns>
    public static string Iso8601()
    {
        return Past().ToString("yyyy-MM-ddTHH:mm:ssZ");
    }
}
