namespace LanguageMasteryChallenges.LeetCode
{
    public class _1491AverageSalaryExcludingTheMinimumAndMaximumSalary
    {
        public static double Average(int[] salary)
        {
            int minVal = salary[0];
            int maxVal = salary[0];

            int sum = salary[0];

            for (int i = 1; i < salary.Length; i++)
            {
                sum += salary[i];

                if (minVal > salary[i])
                {
                    minVal = salary[i];
                }

                if (salary[i] > maxVal)
                {
                    maxVal = salary[i];
                }
            }

            return (sum - (minVal + maxVal)) / (salary.Length - 2d);
        }
    }
}