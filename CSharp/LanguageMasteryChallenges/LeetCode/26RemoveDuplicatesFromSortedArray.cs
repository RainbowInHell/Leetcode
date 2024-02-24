namespace LanguageMasteryChallenges.LeetCode
{
    public class _26RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int currIndex = 1;
            int prevIndex = currIndex - 1;

            for (; currIndex < nums.Length; currIndex++, prevIndex++) 
            {
                if(nums[currIndex] == nums[prevIndex])
                {
                    nums[prevIndex] = int.MaxValue;
                }
            }
            Array.Sort(nums);

            return nums.Count(x => x != int.MaxValue);
        }
    }
}