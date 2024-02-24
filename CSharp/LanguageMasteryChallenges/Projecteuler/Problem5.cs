namespace LanguageMasteryChallenges.Problems
{
    /*
     * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
     * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    */

    public class Problem5
    {
        private static int FirstThatIsDivisibleByNumbersFromOneToTwenty()
        {
            Func<int, bool> isMultipleOfRange = number => Enumerable.Range(1, 20).All(x => number % x == 0);

            int counter = 1;
            bool flag = false;

            while (!flag)
            {
                counter++;

                if (isMultipleOfRange(counter))
                    flag = true;
            }

            return counter;
        }

        public static long Solution()
        {
            return FirstThatIsDivisibleByNumbersFromOneToTwenty();
        }
    }
}