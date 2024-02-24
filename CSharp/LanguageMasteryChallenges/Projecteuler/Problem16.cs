using System.Numerics;

namespace LanguageMasteryChallenges.Problems
{
    /*
     * 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
     * What is the sum of the digits of the number 2^1000?
    */

    public class Problem16
    {
        private static BigInteger SumOfDigits(BigInteger n)
        {
            BigInteger retVal = 0;

            while (n > 0)
            {
                retVal += n % 10;
                n /= 10;
            }

            return retVal;
        }

        public static BigInteger Solution() => SumOfDigits((BigInteger)Math.Pow(2, 1000));
    }
}