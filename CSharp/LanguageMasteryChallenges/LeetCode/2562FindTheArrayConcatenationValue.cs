namespace LanguageMasteryChallenges.LeetCode;

public class _2562FindTheArrayConcatenationValue 
{
    public static long FindTheArrayConcVal(ReadOnlySpan<int> nums)
    {
        long result = nums.Length % 2 == 0 
            ? 0 
            : nums[nums.Length/2];

        for (int left = 0, right = nums.Length - 1;
             left < nums.Length / 2 && right >= nums.Length / 2;
             left++, right--)
        {
            result += long.Parse($"{nums[left]}{nums[right]}");
        }

        return result;
    }
}