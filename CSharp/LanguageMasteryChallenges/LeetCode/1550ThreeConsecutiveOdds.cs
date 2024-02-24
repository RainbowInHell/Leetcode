namespace LanguageMasteryChallenges.LeetCode
{
    public class _1550ThreeConsecutiveOdds
    {
        public static bool ThreeConsecutiveOdds(int[] arr)
        {
            var oddsCounter = 0;
            var isPrevOdd = false;

            foreach (var elem in arr)
            {
                if (elem % 2 != 0)
                {
                    oddsCounter++;

                    if (isPrevOdd)
                    {
                        if (oddsCounter == 3)
                        {
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    isPrevOdd = true;
                }
                else
                {
                    isPrevOdd = false;

                    oddsCounter = 0;
                }
            }

            return false;
            //return arr.Where((num, i) => i >= 2 && (num % 2 == 1) && (arr[i - 1] % 2 == 1) && (arr[i - 2] % 2 == 1)).Any();
        }
    }
}