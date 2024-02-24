namespace LanguageMasteryChallenges.Problems
{
    /*
     * Find the difference between the sum of the squares of the first 
     * one hundred natural numbers and the square of the sum.
    */

    public class Problem6
    {
        public static int Difference()
        {
            var sumOfSquares = (int)Enumerable.Range(1, 100).Select(i => Math.Pow(i, 2)).Sum();
            var squareOfSums = (int)Math.Pow(Enumerable.Range(1, 100).Sum(), 2);

            return squareOfSums - sumOfSquares;
        }

        public static long Solution()
        {
            return Difference();
        }
    }
}