﻿namespace LanguageMasteryChallenges.Problems
{
    /*
     * The following iterative sequence is defined for the set of positive integers:
     * n → n/2 (n is even)
     * n → 3n + 1 (n is odd)
     * 
     * Using the rule above and starting with 13, we generate the following sequence:
     * 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
     * It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
     * Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
     * Which starting number, under one million, produces the longest chain?
     * 
     * NOTE: Once the chain starts the terms are allowed to go above one million.
    */

    public class Problem14
    {
        private static int Collatz()
        {
            int maxLength = 0;
            int maxNum = 0;

            for (int i = 1; i < 1000000; i++)
            {
                int curr = i;
                int length = 1;
                while (curr != 1)
                {
                    if (curr % 2 == 0)
                    {
                        curr /= 2;
                    }
                    else
                    {
                        curr = 3 * curr + 1;
                    }
                    length++;
                }
                if (length > maxLength)
                {
                    maxLength = length;
                    maxNum = i;
                }
            }

            return maxNum;
        }

        public static int Solution() => Collatz();
    }
}