using System;
using System.Linq;
using Dotisan.Faker.Core;

namespace Dotisan.Faker.Generators;

/// <summary>
/// Generator for Lorem Ipsum text
/// </summary>
public static class LoremGenerator
{
    private static readonly string[] Words =
    [
        "lorem", "ipsum", "dolor", "sit", "amet", "consectetur", "adipiscing", "elit", "sed", "do",
        "eiusmod", "tempor", "incididunt", "ut", "labore", "et", "dolore", "magna", "aliqua", "enim",
        "ad", "minim", "veniam", "quis", "nostrud", "exercitation", "ullamco", "laboris", "nisi", "aliquip",
        "ex", "ea", "commodo", "consequat", "duis", "aute", "irure", "in", "reprehenderit", "voluptate",
        "velit", "esse", "cillum", "fugiat", "nulla", "pariatur", "excepteur", "sint", "occaecat", "cupidatat",
        "non", "proident", "sunt", "culpa", "qui", "officia", "deserunt", "mollit", "anim", "id",
        "est", "laborum", "at", "vero", "eos", "accusamus", "accusantium", "doloremque", "laudantium", "totam",
        "rem", "aperiam", "eaque", "ipsa", "quae", "ab", "illo", "inventore", "veritatis", "et",
        "quasi", "architecto", "beatae", "vitae", "dicta", "sunt", "explicabo", "nemo", "ipsam", "voluptatem",
        "quia", "voluptas", "aspernatur", "aut", "odit", "fugit", "sed", "quia", "consequuntur", "magni"
    ];

    /// <summary>
    /// Generates a single Lorem Ipsum word
    /// </summary>
    /// <returns>A random Lorem word</returns>
    public static string Word() => RandomProvider.NextElement(Words);

    /// <summary>
    /// Generates multiple Lorem Ipsum words
    /// </summary>
    /// <param name="count">Number of words to generate</param>
    /// <returns>Random Lorem words separated by spaces</returns>
    public static string Words(int count = 3)
    {
        if (count <= 0) throw new ArgumentException("Count must be greater than 0", nameof(count));

        var words = new string[count];
        for (var i = 0; i < count; i++)
        {
            words[i] = Word();
        }
        return string.Join(" ", words);
    }

    /// <summary>
    /// Generates a Lorem Ipsum sentence
    /// </summary>
    /// <param name="wordCount">Number of words in the sentence (4-15 by default)</param>
    /// <returns>A random Lorem sentence</returns>
    public static string Sentence(int? wordCount = null)
    {
        var count = wordCount ?? RandomProvider.Next(4, 16);
        var words = Words(count);
        return char.ToUpper(words[0]) + words[1..] + ".";
    }

    /// <summary>
    /// Generates multiple Lorem Ipsum sentences
    /// </summary>
    /// <param name="count">Number of sentences to generate</param>
    /// <returns>Random Lorem sentences separated by spaces</returns>
    public static string Sentences(int count = 3)
    {
        if (count <= 0) throw new ArgumentException("Count must be greater than 0", nameof(count));

        var sentences = new string[count];
        for (var i = 0; i < count; i++)
        {
            sentences[i] = Sentence();
        }
        return string.Join(" ", sentences);
    }

    /// <summary>
    /// Generates a Lorem Ipsum paragraph
    /// </summary>
    /// <param name="sentenceCount">Number of sentences in the paragraph (3-7 by default)</param>
    /// <returns>A random Lorem paragraph</returns>
    public static string Paragraph(int? sentenceCount = null)
    {
        var count = sentenceCount ?? RandomProvider.Next(3, 8);
        return Sentences(count);
    }

    /// <summary>
    /// Generates multiple Lorem Ipsum paragraphs
    /// </summary>
    /// <param name="count">Number of paragraphs to generate</param>
    /// <returns>Random Lorem paragraphs separated by line breaks</returns>
    public static string Paragraphs(int count = 3)
    {
        if (count <= 0) throw new ArgumentException("Count must be greater than 0", nameof(count));

        var paragraphs = new string[count];
        for (var i = 0; i < count; i++)
        {
            paragraphs[i] = Paragraph();
        }
        return string.Join(Environment.NewLine + Environment.NewLine, paragraphs);
    }

    /// <summary>
    /// Generates Lorem Ipsum text of approximately the specified character length
    /// </summary>
    /// <param name="characterCount">Approximate number of characters to generate</param>
    /// <returns>Lorem text of approximately the specified length</returns>
    public static string Text(int characterCount = 200)
    {
        if (characterCount <= 0) throw new ArgumentException("Character count must be greater than 0", nameof(characterCount));

        var result = "";
        while (result.Length < characterCount)
        {
            var sentence = Sentence();
            result += (result.Length == 0 ? "" : " ") + sentence;
        }

        return result.Length <= characterCount ? result : result[..characterCount].TrimEnd() + ".";
    }

    /// <summary>
    /// Generates a Lorem Ipsum slug (lowercase words separated by hyphens)
    /// </summary>
    /// <param name="wordCount">Number of words in the slug</param>
    /// <returns>A Lorem slug</returns>
    public static string Slug(int wordCount = 3)
    {
        if (wordCount <= 0) throw new ArgumentException("Word count must be greater than 0", nameof(wordCount));

        var words = new string[wordCount];
        for (var i = 0; i < wordCount; i++)
        {
            words[i] = Word().ToLowerInvariant();
        }
        return string.Join("-", words);
    }
}
