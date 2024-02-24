namespace LanguageMasteryChallenges.LeetCode
{
    public class _832FlippingAnImage
    {
        public static int[][] FlipAndInvertImage(int[][] image)
        {
            for (int i = 0; i < image.Length; i++)
            {
                var tempCounter = 0;

                for (int j = image[i].Length - 1; j >= image[i].Length / 2; j--)
                {
                    if (j != tempCounter)
                    {
                        image[i][tempCounter] ^= 1;
                        image[i][j] ^= 1;

                        if (image[i][tempCounter] != image[i][j])
                        {
                            (image[i][j], image[i][tempCounter]) = (image[i][tempCounter], image[i][j]);
                        }
                    }
                    else
                    {
                        image[i][j] ^= 1;
                    }

                    tempCounter++;
                }
            }

            return image;
        }
    }
}