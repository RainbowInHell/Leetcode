namespace LanguageMasteryChallenges.LeetCode
{
    public class _1281SubtractTheProductAndSumOfDigitsOfAnInteger
    {
        public static int SubtractProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                product *= digit;
                sum += digit;
                n /= 10;
            }
            return product - sum;

            //int product = n.ToString().Select(x => int.Parse(x.ToString())).Aggregate((a, b) => a * b);
            //int sum = n.ToString().Select(x => int.Parse(x.ToString())).Sum();

            //return product - sum;
        }
    }
}