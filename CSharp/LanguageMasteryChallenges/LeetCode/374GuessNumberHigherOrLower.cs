namespace LanguageMasteryChallenges.LeetCode
{
    public class _374GuessNumberHigherOrLower
    {
        public static int Guess(int number)
        {
            var endVal = 1702766719;

            if (number > endVal)
            {
                return -1;
            }

            if (number < endVal)
            {
                return 1;
            }

            return 0;
        }

        public static int BinarySearch(int[] array, long first, long last)
        {
            if (first > last)
            {
                return -1;
            }

            var middle = (first + last) / 2;
            var middleValue = array[middle];

            var searchedValue = Guess(middleValue);

            if (searchedValue == 0)
            {
                return middleValue;
            }

            if (searchedValue == 1)
            {
                return BinarySearch(array, middle + 1, last);
            }

            return BinarySearch(array, first, middle - 1);
        }

        public static int GuessNumber(int n)
        {
            long left = 0;
            long right = n - 1;

            while (left <= right)
            {
                long middle = (left + right) / 2;
                var middleValue = (int)middle + 1;

                var searchedValue = Guess(middleValue);

                if (searchedValue == 0)
                {
                    return middleValue;
                }

                if (searchedValue == 1)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }
    }
}