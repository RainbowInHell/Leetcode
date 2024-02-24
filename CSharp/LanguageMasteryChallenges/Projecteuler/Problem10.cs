namespace LanguageMasteryChallenges.Problems
{
    /*
     * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
     * What is the 10 001st prime number?
    */

    public class Problem10
    {
        private static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static long SumOfPrimes()
        {
            long sum = 0;
            for (int i = 2; i < 2_000_000; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static long Solution() => SumOfPrimes();
    }
}