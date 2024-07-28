using System.Buffers;

namespace LanguageMasteryChallenges.LeetCode;

public class _2000ReversePrefixOfWord
{
    public static string ReversePrefixUsingSpan(string word, char ch)
    {
        var indexOfChar = word.AsSpan().IndexOf(ch);
        if (indexOfChar == -1)
        {
            return word;
        }

        Span<char> partToReverse = stackalloc char[indexOfChar + 1];

        word.AsSpan(0, indexOfChar + 1).CopyTo(partToReverse);

        partToReverse.Reverse();

        return string.Concat(partToReverse, word.AsSpan(indexOfChar + 1));
    }

    public static string ReversePrefixUsingArrayReverse(string word, char ch)
    {
        var indexOfChar = word.IndexOf(ch);
        if (indexOfChar == -1)
        {
            return word;
        }

        var charArray = word.ToCharArray();
        Array.Reverse(charArray, 0, indexOfChar + 1);

        return new string(charArray);
    }
}