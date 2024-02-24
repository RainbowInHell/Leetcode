namespace LanguageMasteryChallenges.LeetCode
{
    public class _2485FindThePivotInteger
    {
        public static int PivotInteger(int n)
        {
            var list = Enumerable.Range(1, n);
            
            var sum = 0;

            var listSum = list.Sum();

            foreach (var val in list) 
            {
                sum += val;
                
                if (sum == listSum)
                {
                    return val;
                }

                listSum -= val;
            }

            return -1;
        }
    }
}