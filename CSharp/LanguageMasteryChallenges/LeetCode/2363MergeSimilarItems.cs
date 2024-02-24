namespace LanguageMasteryChallenges.LeetCode
{
    class _2363MergeSimilarItems
    {
        public static IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        {
            Dictionary<int, int> valueWeights = new Dictionary<int, int>();

            foreach (int[] item in items1.Concat(items2))
            {
                int value = item[0];
                int weight = item[1];
                if (valueWeights.ContainsKey(value))
                {
                    valueWeights[value] += weight;
                }
                else
                {
                    valueWeights[value] = weight;
                }
            }

            return valueWeights.OrderBy(x => x.Key)
                               .Select(x => new List<int>() { x.Key, x.Value })
                               .ToList<IList<int>>();
        }
    }
}