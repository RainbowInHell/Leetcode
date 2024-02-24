namespace LanguageMasteryChallenges.Problems
{
    /*
     * You are given the following information, but you may prefer to do some research for yourself.
     * 
     * 1 Jan 1900 was a Monday.
     * Thirty days has September,
     * April, June and November.
     * All the rest have thirty-one,
     * Saving February alone,
     * Which has twenty-eight, rain or shine.
     * And on leap years, twenty-nine.
     * A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
     * 
     * How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
    */

    public class Problem19
    {
        private static int CountingSundays()
        {
            int sundaysCounter = 0;
            int startYear = 1901;
            int startMonth = 1;
            int dayOfWeek = 2;

            while (startYear != 2001)
            {
                switch (startMonth)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        dayOfWeek += 30;
                        break;
                    case 2:
                        if (startYear % 4 == 0 && (startYear % 100 != 0 || startYear % 400 == 0))
                        {
                            dayOfWeek += 29;
                        }
                        else
                        {
                            dayOfWeek += 28;
                        }
                        break;
                    default:
                        dayOfWeek += 31;
                        break;
                }

                startMonth++;

                if (startMonth > 12)
                {
                    startMonth = 1;
                    startYear++;
                }

                if (dayOfWeek % 7 == 0)
                {
                    sundaysCounter++;
                }
            }

            return sundaysCounter;
        }

        public static int Solution() => CountingSundays();
    }
}