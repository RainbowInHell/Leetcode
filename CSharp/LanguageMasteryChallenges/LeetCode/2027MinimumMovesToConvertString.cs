namespace LanguageMasteryChallenges.LeetCode
{
    public class _2027MinimumMovesToConvertString
    {
        public static int MinimumMoves(string s)
        {
            int retVal = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'X')
                {
                    retVal++;

                    i += 2;
                }
            }

            return retVal;
        }
    }
}