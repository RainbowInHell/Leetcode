namespace LanguageMasteryChallenges.LeetCode;

public class _2399CheckDistancesBetweenSameLetters
{
    public static bool CheckDistancesBasic(string s, int[] distance)
    {
        var dictionary = new Dictionary<char, int>(s.Length);
    
        for (var i = 0; i < s.Length; i++)
        {
            if (dictionary.TryAdd(s[i], i))
            {
                continue;
            }
    
            var distanceBetweenEntries = CalculateDistance(dictionary[s[i]], i);
            var passedDistance = distance[GetCharPositionInAlphabet(s[i])];
    
            if (distanceBetweenEntries != passedDistance)
            {
                return false;
            }
        }
    
        return true;
    }

    public static bool CheckDistancesUsingSpan(string s, int[] distance)
    {
        var sAsSpan = s.AsSpan();

        for (var i = 0; i < s.Length; i++)
        {
            var indexOfFirst = sAsSpan.IndexOf(s[i]);
            var indexOfLast = sAsSpan.LastIndexOf(s[i]);

            if (indexOfFirst == indexOfLast)
            {
                return false;
            }

            var distanceBetweenEntries = CalculateDistance(indexOfFirst, indexOfLast);
            var passedDistance = distance[GetCharPositionInAlphabet(s[i])];

            if (distanceBetweenEntries != passedDistance)
            {
                return false;
            }
        }

        return true;
    }

    private static int CalculateDistance(int leftVal, int rightVal)
    {
        return Math.Abs(leftVal - rightVal) - 1;
    }

    private static int GetCharPositionInAlphabet(char c)
    {
        return char.ToUpper(c) - 64 - 1;
    }
}