namespace LanguageMasteryChallenges.LeetCode
{
    public class _290WordPattern
    {
        public static bool WordPattern(string pattern, string s)
        {
            var dictionary = new Dictionary<char, string>();

            var words = s.Split(' ');

            if (pattern.Length != words.Length)
            {
                return false;
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (dictionary.ContainsKey(pattern[i]))
                {
                    if (dictionary[pattern[i]] != words[i])
                    {
                        return false;
                    }
                }
                else if (!dictionary.ContainsValue(words[i]))
                {
                    dictionary[pattern[i]] = words[i];
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}