namespace LanguageMasteryChallenges.LeetCode
{
    public class _463IslandPerimeter
    {
        private static bool IsInside(int[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length) return false;
            if (j < 0 || j >= grid[0].Length) return false;

            return true;
        }

        public static int IslandPerimeter(int[][] grid)
        {
            int retVal = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 0)
                        continue;

                    if (!IsInside(grid, i - 1, j) || grid[i - 1][j] == 0)
                        retVal++;

                    if (!IsInside(grid, i, j + 1) || grid[i][j + 1] == 0)
                        retVal++;

                    if (!IsInside(grid, i + 1, j) || grid[i + 1][j] == 0)
                        retVal++;

                    if (!IsInside(grid, i, j - 1) || grid[i][j - 1] == 0)
                        retVal++;
                }
            }

            return retVal;
        }
    }
}