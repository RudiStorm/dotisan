using System;

namespace Dotisan.Assert.Assertions;

public static class StringAssertions
{
    public static void ShouldBe(this string? actual, string expected, string? because = null)
    {
        if (!string.Equals(actual, expected, StringComparison.Ordinal))
            throw new AssertException($"Expected '{expected}', got '{actual}'. {because}");
    }
}

public sealed class AssertException : Exception
{
    public AssertException(string message) : base(message)
    {
    }
}