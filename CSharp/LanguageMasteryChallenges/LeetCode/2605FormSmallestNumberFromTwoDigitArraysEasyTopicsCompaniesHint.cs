namespace LanguageMasteryChallenges.LeetCode;

public static class _2605FormSmallestNumberFromTwoDigitArraysEasyTopicsCompaniesHint
{
    public static int MinNumber(int[] nums1, int[] nums2) 
    {
        var minForFirstArray = int.MaxValue;
        var minForSecondArray = int.MaxValue;
        var borderVal = Math.Max(nums1.Length, nums2.Length);
        var dict = new Dictionary<int, int>();
        
        for (var i = 0; i < borderVal; i++)
        {
            if (i < nums1.Length)
            {
                if (!dict.TryAdd(nums1[i], 1))
                {
                    dict[nums1[i]]++;
                }

                if (nums1[i] < minForFirstArray)
                    minForFirstArray = nums1[i];
            }

            if (i < nums2.Length)
            {
                if (!dict.TryAdd(nums2[i], 1))
                {
                    dict[nums2[i]]++;
                }

                if (nums2[i] < minForSecondArray)
                    minForSecondArray = nums2[i];
            }
        }

        return dict.Any(x => x.Value == 2)
            ? dict.Where(x => x.Value == 2).Min(x => x.Key)
            : Convert.ToInt32($"{Math.Min(minForFirstArray, minForSecondArray)}{Math.Max(minForFirstArray, minForSecondArray)}");
    }
}