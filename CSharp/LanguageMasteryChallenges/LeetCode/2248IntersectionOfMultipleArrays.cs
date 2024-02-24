namespace LanguageMasteryChallenges.LeetCode
{
    public class _2248IntersectionOfMultipleArrays
    {
        public static IList<int> Intersection(int[][] nums)
        {
            var dictionary = new Dictionary<int, int>();

            var maxValue = 0;
            var minValue = 1;

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums[i].GetLength(0); j++)
                {
                    int temp = nums[i][j];

                    if (dictionary.ContainsKey(temp))
                    {
                        dictionary[temp]++;
                    }
                    else
                    {
                        dictionary[temp] = 1;
                    }

                    maxValue = Math.Max(maxValue, dictionary[temp]);
                    minValue = Math.Min(minValue, dictionary[temp]);
                }
            }

            if (minValue == maxValue && nums.Length != 1)
            {
                return new List<int>();
            }

            var res = dictionary.Where(x => x.Value == maxValue).Select(x => x.Key).ToList();

            res.Sort();

            return res;
        }
    }
}