namespace LanguageMasteryChallenges.LeetCode
{
    class _169MajorityElement
    {
        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            int retVal = 0;

            foreach (int num in nums)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            int highestFrequency = frequency.Values.Max();
            foreach (int num in frequency.Keys)
            {
                if (frequency[num] == highestFrequency)
                {
                    retVal = num;
                    break;
                }
            }

            return retVal;
        }
    }
}