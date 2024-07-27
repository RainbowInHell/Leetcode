namespace LanguageMasteryChallenges.LeetCode;

public class _2185CountingWordsWithAGivenPrefix 
{
    public static int PrefixCount(string[] words, string pref)
    {
        return words.Count(word => word.StartsWith(pref));
    }
}