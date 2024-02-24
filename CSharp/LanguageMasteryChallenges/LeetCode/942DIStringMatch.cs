namespace LanguageMasteryChallenges.LeetCode
{
    public class _942DIStringMatch
    {
        public static int[] DiStringMatch(string s)
        {
            List<int> result = new List<int>();

            int iCnt = 0;
            int dCnt = s.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'D')
                {
                    result.Add(dCnt);
                    dCnt--;
                }
                if (s[i] == 'I')
                {
                    result.Add(iCnt);
                    iCnt++;
                }
                if(i == s.Length - 1)
                {
                    result.Add(dCnt);
                }
            }

            return result.ToArray();
        }
    }
}