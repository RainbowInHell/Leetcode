namespace LanguageMasteryChallenges.Problems
{
    /*
     * If we list all the natural numbers below 10 that are multiples of 3 or 5, 
     * we get 3, 5, 6 and 9. The sum of these multiples is 23.
     * Find the sum of all the multiples of 3 or 5 below 1000.
    */

    public class Problem1
    {
        private static bool IsMultipleOfThreeAndFive(int val)
        {
            return val % 3 == 0 || val % 5 == 0;
        }

        public static int Solution()
        {
            int retVal = Enumerable.Range(0, 1000)
                                   .Select(x => x)
                                   .Where(x => IsMultipleOfThreeAndFive(x))
                                   .Sum();

            return retVal;
        }
    }
}