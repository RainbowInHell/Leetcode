namespace LanguageMasteryChallenges.LeetCode
{
    public class _1200MinimumAbsoluteDifference
    {
        public static IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            var result = new List<IList<int>>();

            var minAbsDiff = int.MaxValue;

            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                minAbsDiff = Math.Min(minAbsDiff, Math.Abs(arr[i] - arr[i + 1]));
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (minAbsDiff == Math.Abs(arr[i] - arr[i + 1]))
                {
                    result.Add(new List<int>() { arr[i], arr[i + 1] });
                }
            }

            return result;
        }
    }
}