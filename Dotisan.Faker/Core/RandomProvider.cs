using System;

namespace Dotisan.Faker.Core;

/// <summary>
/// Provides a seeded random number generator for consistent test data generation
/// </summary>
internal static class RandomProvider
{
    private static Random _random = new();
    private static int? _seed;

    /// <summary>
    /// Sets the seed for the random number generator to ensure reproducible results
    /// </summary>
    /// <param name="seed">The seed value to use</param>
    internal static void SetSeed(int seed)
    {
        _seed = seed;
        _random = new Random(seed);
    }

    /// <summary>
    /// Gets the current seed value, if one has been set
    /// </summary>
    internal static int? CurrentSeed => _seed;

    /// <summary>
    /// Resets the random provider to use a non-seeded random generator
    /// </summary>
    internal static void Reset()
    {
        _seed = null;
        _random = new Random();
    }

    /// <summary>
    /// Returns a random integer between 0 (inclusive) and maxValue (exclusive)
    /// </summary>
    internal static int Next(int maxValue) => _random.Next(maxValue);

    /// <summary>
    /// Returns a random integer between minValue (inclusive) and maxValue (exclusive)
    /// </summary>
    internal static int Next(int minValue, int maxValue) => _random.Next(minValue, maxValue);

    /// <summary>
    /// Returns a random double between 0.0 and 1.0
    /// </summary>
    internal static double NextDouble() => _random.NextDouble();

    /// <summary>
    /// Returns a random boolean value
    /// </summary>
    internal static bool NextBoolean() => _random.Next(2) == 1;

    /// <summary>
    /// Returns a random element from the provided array
    /// </summary>
    internal static T NextElement<T>(T[] array) => array[Next(array.Length)];

    /// <summary>
    /// Returns a random element from the provided list
    /// </summary>
    internal static T NextElement<T>(System.Collections.Generic.IReadOnlyList<T> list) => list[Next(list.Count)];
}
