namespace LanguageMasteryChallenges.LeetCode
{
    public class _946ValidateStackSequences
    {
        public static bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            //for (int i = 0, j = pushed.Length - 1; i < pushed.Length && j >= 0; i++, j--)
            //{
            //    if (pushed[i] != popped[j])
            //    {
            //        if (pushed[i] != popped[j - 1] && pushed[i + 1] != popped[j])
            //        {
            //            return false;
            //        }
            //        else
            //        {
            //            i++;
            //            j--;
            //        }
            //    }
            //}
            var stack = new Stack<int>();

            for (int i = 0, j = 0; i < pushed.Length; i++)
            {
                var currPushed = pushed[i];
                var currPopped = popped[j];

                stack.Push(currPushed);

                if (currPushed == currPopped)
                {
                    stack.Pop();
                    j++;
                }

                if (i == pushed.Length - 1)
                {
                    while (true)
                    {

                    }
                }
            }

            return true;
        }
    }
}