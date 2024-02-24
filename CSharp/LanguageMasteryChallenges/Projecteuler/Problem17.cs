using System.Diagnostics.Metrics;
using System.Numerics;

namespace LanguageMasteryChallenges.Problems
{
    /*
     * If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 
     * 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
     * If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
    */

    public class Problem17
    {
        private static string[] one = { "", "One", "Two", "Three", "Four",
                            "Five", "Six", "Seven", "Eight",
                            "Nine", "Ten", "Eleven", "Twelve",
                            "Thirteen", "Fourteen", "Fifteen",
                            "Sixteen", "Seventeen", "Eighteen",
                            "Nineteen" };

        private static string[] ten = { "", "", "Twenty", "Thirty", "Forty",
                            "Fifty", "Sixty", "Seventy", "Eighty",
                            "Ninety" };

        private static string numToWords(int n, string s)
        {
            string retVal = "";

            if (n > 19)
            {
                retVal += ten[n / 10] + one[n % 10];
            }
            else
            {
                retVal += one[n];
            }

            if (n != 0)
            {
                retVal += s;
            }

            return retVal;
        }

        private static int convertToWords(int n)
        {
            if (n == 1000) { return "OneThousand".Length; }

            string hundredToAdd = "";
            string retVal = "";

            if(n % 100 == 0)
            {
                hundredToAdd = "Hundred";
            }
            else
            {
                hundredToAdd = "HundredAnd";
            }

            retVal += numToWords(((n / 100) % 10), hundredToAdd);
            retVal += numToWords((n % 100), "");

            return retVal.Length;
        }

        public static BigInteger NumberLetterCounts()
        {
            int temp = 1;
            BigInteger retVal = BigInteger.Zero;

            while (temp < 1001)
            {
                retVal += convertToWords(temp);

                temp++;
            }

            return retVal;
        }

        public static BigInteger Solution() => NumberLetterCounts();
    }
}