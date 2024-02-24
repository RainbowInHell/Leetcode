namespace LanguageMasteryChallenges.LeetCode
{
    public class _2441LargestPositiveIntegerThatExistsWithItsNegative
    {
        public static int FindMaxK(int[] nums)
        {
            var tempNums = new List<int>(nums);

            tempNums.Sort();

            var sortedHashSet = tempNums.ToHashSet();

            for (int i = sortedHashSet.Count - 1; i != 0; i--)
            {
                if (sortedHashSet.Contains(-sortedHashSet.ElementAt(i)))
                    return sortedHashSet.ElementAt(i);
            }

            return -1;
        }
    }
}