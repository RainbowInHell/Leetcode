namespace LanguageMasteryChallenges.LeetCode
{
    using System.Numerics;
    using System.Text.RegularExpressions;

    public class _1071GreatestCommonDivisorOfStrings
    {
        public static string GcdOfStrings(string str1, string str2)
        {
            //if (str1 + str2 != str2 + str1)
            //    return "";

            //var shortestString = str1.Length <= str2.Length ? str1 : str2;
            //var longestString = str1.Length > str2.Length ? str1 : str2;

            //var i = 0;

            //while (i < shortestString.Length)
            //{
            //    var pattern = str1.Substring(0, shortestString.Length - i);

            //    var res1 = Regex.Replace(longestString, pattern, "");
            //    var res2 = Regex.Replace(shortestString, pattern, "");

            //    if (string.IsNullOrEmpty(res1) && string.IsNullOrEmpty(res2))
            //    {
            //        return pattern;
            //    }

            //    i++;
            //}

            //return "";

            if (str1 + str2 != str2 + str1)
                return "";

            int minLength = (int)BigInteger.GreatestCommonDivisor(str1.Length, str2.Length);

            if (str1.Substring(0, minLength) == str2.Substring(0, minLength))
                return str1.Substring(0, minLength);

            return "";
        }
    }
}