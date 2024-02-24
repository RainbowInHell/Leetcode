namespace LanguageMasteryChallenges.LeetCode
{
    public class _2529MaximumCountOfPositiveIntegerAndNegativeInteger
    {
        public static int MaximumCount(int[] nums)
        {
            var negativeCount = 0;

            var positiveCount = 0;

            foreach (var num in nums)
            {
                if (num < 0)
                {
                    negativeCount++;
                }
                else if (num > 0)
                {
                    positiveCount++;
                }
            }

            return negativeCount > positiveCount ? negativeCount : positiveCount;
        }
    }
}