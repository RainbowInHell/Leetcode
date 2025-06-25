namespace LanguageMasteryChallenges.LeetCode;

public class _13RomanToInteger
{
    private static readonly IReadOnlyDictionary<char, int> RomanToIntDictionary = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    public static int RomanToInt(string s)
    {
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var currentAsInt = RomanToIntDictionary[s[i]];

            if (i < s.Length - 1 && currentAsInt < RomanToIntDictionary[s[i + 1]])
            {
                result -= currentAsInt;
            }
            else
            {
                result += currentAsInt;
            }
        }

        return result;
    }
}
