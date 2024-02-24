namespace LanguageMasteryChallenges.Problems
{
    /*
     * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
     * What is the 10 001st prime number?
    */

    public class Problem7
    {
        private static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static int PrimeNumber()
        {
            int primeNumbersCounter = 0;
            int retVal = 2;
            
            while(true)
            {
                if (primeNumbersCounter == 10001)
                    break;

                if(IsPrime(retVal))
                {
                    primeNumbersCounter++;
                }

                retVal++;
            }

            return retVal;
        }

        public static int Solution() => PrimeNumber();
    }
}