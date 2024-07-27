namespace LanguageMasteryChallenges.LeetCode;

public class _1221SplitAStringInBalancedStrings 
{
    public static int BalancedStringSplit(string str)
    {
        var balanceTracker = 0;
        var result = 0;

        foreach (var ch in str)
        {
            if (ch == 'R')
                balanceTracker++;
            else
                balanceTracker--;

            if (balanceTracker == 0)
                result++;
        }

        return result;
    }    
}