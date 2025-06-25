namespace LanguageMasteryChallenges.LeetCode;

public static class _3190FindMinimumOperationsToMakeAllElementsDivisibleByThree
{
    public static int MinimumOperations(int[] nums)
    {
        return nums.Length - nums.Count(x => x % 3 == 0);
    }
}
