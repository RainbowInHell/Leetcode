namespace LanguageMasteryChallenges.Problems
{
    /*
     * A palindromic number reads the same both ways. The largest palindrome made from the product 
     * of two 2-digit numbers is 9009 = 91 × 99.
     * Find the largest palindrome made from the product of two 3-digit numbers.
    */

    public class Problem4
    {
        private static bool IsNumberPalindrome(int number)
        {
            string numberAsString = number.ToString();
            var chars = numberAsString.ToCharArray();
            
            Array.Reverse(chars);
            return numberAsString.SequenceEqual(new string(chars));
        }

        private static int LargestPalindromeFromProductTwoThreeDigitNumbers()
        {
            int first = 999;
            int second = 999;
            int retVal = 0;

            while(first >= 100)
            {
                second = 999;
                while(second >= 100)
                {
                    int tempProduct = first * second;
                    if (IsNumberPalindrome(tempProduct))
                    {
                        if (tempProduct > retVal)
                        {
                            retVal = tempProduct;
                        }
                    }

                    second--;
                }
                first--;
            }

            return retVal;
        }

        public static long Solution()
        {
            return LargestPalindromeFromProductTwoThreeDigitNumbers();
        }
    }
}