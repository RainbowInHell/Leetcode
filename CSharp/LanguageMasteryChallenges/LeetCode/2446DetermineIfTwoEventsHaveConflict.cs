namespace LanguageMasteryChallenges.LeetCode
{
    public class _2446DetermineIfTwoEventsHaveConflict
    {
        public static bool HaveConflict(string[] event1, string[] event2)
        {
            var start1 = DateTime.Parse(event1[0]);
            var end1 = DateTime.Parse(event1[1]);

            var start2 = DateTime.Parse(event2[0]);
            var end2 = DateTime.Parse(event2[1]);

            return (start1 <= end2) && (end1 >= start2);

            // 1 line solution ;(
            //return (event1[0].CompareTo(event2[1]) <= 0) && (event2[0].CompareTo(event1[1]) <= 0);
        }
    }
}