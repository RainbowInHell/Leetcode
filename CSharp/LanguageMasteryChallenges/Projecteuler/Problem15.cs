using System.Numerics;

namespace LanguageMasteryChallenges.Problems
{
    /*
     * Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, 
     * there are exactly 6 routes to the bottom right corner.
     * How many such routes are there through a 20×20 grid?
    */

    public class Problem15
    {
        private static BigInteger Factorial(int n) => n == 1 ? 1 : n * Factorial(n - 1);

        private static BigInteger NchooseK(int n)
        {
            return Factorial(2 * n) / (Factorial(n) * Factorial(n));
        }

        public static BigInteger Solution() => NchooseK(20);
    }
}