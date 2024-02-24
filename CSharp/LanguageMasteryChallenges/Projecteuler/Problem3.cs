namespace LanguageMasteryChallenges.Problems
{
    /*
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143 ?
    */

    public class Problem3
    {
        private static long FindLargestPrimeFactor()
        {
            long n = 600851475143;
            long largestFactor = 1;
            long sqrt = (long)Math.Sqrt(n);

            for (long i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                {
                    largestFactor = i;
                    n = n / i;
                    while (n % i == 0)
                    {
                        n = n / i;
                    }
                    sqrt = (long)Math.Sqrt(n);
                }
            }

            if (n > largestFactor)
            {
                largestFactor = n;
            }

            return largestFactor;
        }

        public static long Solution()
        {
            return FindLargestPrimeFactor();
        }
    }
}