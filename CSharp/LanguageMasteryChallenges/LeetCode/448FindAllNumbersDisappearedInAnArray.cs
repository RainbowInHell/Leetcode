namespace LanguageMasteryChallenges.LeetCode
{
    public class _448FindAllNumbersDisappearedInAnArray
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            //return Enumerable.Range(1, nums.Length).Except(nums).ToList();

            return Enumerable.Range(1, nums.Length).ToHashSet().Except(nums).ToList();
        }
    }
}