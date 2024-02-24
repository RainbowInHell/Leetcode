namespace LanguageMasteryChallenges.LeetCode
{
    class _2269FindTheKBeautyOfANumber
    {
        public static int DivisorSubstrings(int num, int k)
        {
            string numAsString = num.ToString();
            
            int counter = 0;

            for (int i = 0; i < numAsString.Length; i++)
            {
                int current = int.Parse(numAsString.Substring(i, k));

                if (current != 0 && num % current == 0)
                {
                    counter++;
                }

                if (i + k == numAsString.Length) { break; }
            }

            return counter;
        }
    }
}