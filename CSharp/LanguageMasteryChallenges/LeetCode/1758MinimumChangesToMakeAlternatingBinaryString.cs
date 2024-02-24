using System.Text;

namespace LanguageMasteryChallenges.LeetCode
{
    public class _1758MinimumChangesToMakeAlternatingBinaryString
    {
        public static int MinOperations(string s)
        {
            char tempChar1 = ' ';
            char tempChar2 = ' ';

            int tmp1 = 0;
            int tmp2 = 0;

            for (int i = 0; i < s.Length; i++)
            {
                tempChar1 = (i % 2 == 0) ? '0' : '1';

                tempChar2 = (i % 2 == 0) ? '1' : '0';

                if (s[i] != tempChar1)
                    tmp1++;
                if (s[i] != tempChar2)
                    tmp2++;
            }

            return Math.Min(tmp1, tmp2);
        }
    }
}