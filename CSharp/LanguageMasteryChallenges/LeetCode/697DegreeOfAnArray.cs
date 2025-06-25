using System.Runtime.InteropServices;

namespace LanguageMasteryChallenges.LeetCode;

public static class _697DegreeOfAnArray
{
    // Construct a dictionary in which the key is a number from nums and the value is a tuple of three integers:
    // 1 – the degree of that key (its frequency);
    // 2 – the index of its first occurrence;
    // 3 – the index of its last occurrence.
    // If currentDegree (the frequency of the current number) is greater than maxDegree, update both maxDegree and minimalLength;
    // otherwise, if currentDegree equals maxDegree, we have another number with the same degree
    // and must determine which one yields a shorter subarray length.
    public static int FindShortestSubArray(int[] nums)
    {
        var repeatables = new Dictionary<int, (int degree, int leftIndex, int rightIndex)>();
        var maxDegree = 0;
        var minimalLength = int.MaxValue;

        for (var i = 0; i < nums.Length; i++)
        {
            ref var dictionaryValue = ref CollectionsMarshal.GetValueRefOrAddDefault(repeatables, nums[i], out var exists);
            if (exists)
            {
                dictionaryValue.degree++;
                dictionaryValue.rightIndex = i;
            }
            else
            {
                dictionaryValue = (1, i, i);
            }

            var currentDegree = dictionaryValue.degree;
            if (currentDegree > maxDegree)
            {
                maxDegree = currentDegree;
                minimalLength = dictionaryValue.rightIndex - dictionaryValue.leftIndex + 1;
            }
            else if (currentDegree == maxDegree)
            {
                minimalLength = Math.Min(minimalLength, dictionaryValue.rightIndex - dictionaryValue.leftIndex + 1);
            }
        }

        return minimalLength;
    }
}