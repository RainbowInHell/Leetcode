namespace LanguageMasteryChallenges.LeetCode
{
    public class _1518WaterBottles
    {
        //public static int NumWaterBottles(int numBottles, int numExchange)
        //{
        //    var res = 0;
        //    var tempNumBottles = numBottles;

        //    while (tempNumBottles > 0)
        //    {
        //        res += tempNumBottles;

        //        tempNumBottles /= numExchange;
        //    }

        //    return res;
        //}
        public static int NumWaterBottles(int numBottles, int numExchange)
        {
            var res = 0;
            var numEmptyBottles = 0;

            while (numBottles > 0)
            {
                res += numBottles;
                numEmptyBottles = numBottles;

                //if (numBottles + numEmptyBottles > numExchange)
                //{

                //}

                numBottles = numEmptyBottles / numExchange;
                //numEmptyBottles += ?
            }
            return res;
        }
    }
}