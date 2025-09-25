using System;
using Dotisan.Faker.Core;

namespace Dotisan.Faker.Generators;

/// <summary>
/// Generator for fake numeric data
/// </summary>
public static class NumberGenerator
{
    /// <summary>
    /// Generates a random integer between 0 and max value (exclusive)
    /// </summary>
    /// <param name="max">Maximum value (exclusive)</param>
    /// <returns>A random integer</returns>
    public static int Integer(int max = 100) => RandomProvider.Next(max);

    /// <summary>
    /// Generates a random integer between min and max values
    /// </summary>
    /// <param name="min">Minimum value (inclusive)</param>
    /// <param name="max">Maximum value (exclusive)</param>
    /// <returns>A random integer within the specified range</returns>
    public static int Integer(int min, int max) => RandomProvider.Next(min, max);

    /// <summary>
    /// Generates a random double between 0.0 and 1.0
    /// </summary>
    /// <returns>A random double value</returns>
    public static double Double() => RandomProvider.NextDouble();

    /// <summary>
    /// Generates a random double between min and max values
    /// </summary>
    /// <param name="min">Minimum value (inclusive)</param>
    /// <param name="max">Maximum value (exclusive)</param>
    /// <returns>A random double within the specified range</returns>
    public static double Double(double min, double max) => min + (RandomProvider.NextDouble() * (max - min));

    /// <summary>
    /// Generates a random decimal between 0 and max value
    /// </summary>
    /// <param name="max">Maximum value (exclusive)</param>
    /// <returns>A random decimal value</returns>
    public static decimal Decimal(decimal max = 100m) => (decimal)RandomProvider.NextDouble() * max;

    /// <summary>
    /// Generates a random decimal between min and max values
    /// </summary>
    /// <param name="min">Minimum value (inclusive)</param>
    /// <param name="max">Maximum value (exclusive)</param>
    /// <returns>A random decimal within the specified range</returns>
    public static decimal Decimal(decimal min, decimal max) => min + ((decimal)RandomProvider.NextDouble() * (max - min));

    /// <summary>
    /// Generates a random boolean value
    /// </summary>
    /// <returns>A random boolean value</returns>
    public static bool Boolean() => RandomProvider.NextBoolean();

    /// <summary>
    /// Generates a random byte value
    /// </summary>
    /// <returns>A random byte value</returns>
    public static byte Byte() => (byte)RandomProvider.Next(256);

    /// <summary>
    /// Generates a random positive percentage (0-100)
    /// </summary>
    /// <returns>A random percentage value</returns>
    public static int Percentage() => RandomProvider.Next(0, 101);

    /// <summary>
    /// Generates a random South African Rand amount
    /// </summary>
    /// <param name="min">Minimum amount</param>
    /// <param name="max">Maximum amount</param>
    /// <returns>A random currency amount</returns>
    public static decimal Currency(decimal min = 0m, decimal max = 10000m)
    {
        var amount = Decimal(min, max);
        return Math.Round(amount, 2);
    }

    /// <summary>
    /// Generates a formatted currency string with R symbol
    /// </summary>
    /// <param name="min">Minimum amount</param>
    /// <param name="max">Maximum amount</param>
    /// <returns>A formatted currency string</returns>
    public static string CurrencyString(decimal min = 0m, decimal max = 10000m)
    {
        var amount = Currency(min, max);
        return $"R{amount:F2}";
    }

    /// <summary>
    /// Generates a random digit character
    /// </summary>
    /// <returns>A random digit character (0-9)</returns>
    public static char Digit() => (char)('0' + RandomProvider.Next(10));

    /// <summary>
    /// Generates a string of random digits
    /// </summary>
    /// <param name="length">Length of the digit string</param>
    /// <returns>A string of random digits</returns>
    public static string Digits(int length)
    {
        if (length <= 0) throw new ArgumentException("Length must be greater than 0", nameof(length));

        var digits = new char[length];
        for (var i = 0; i < length; i++)
        {
            digits[i] = Digit();
        }
        return new string(digits);
    }
}
