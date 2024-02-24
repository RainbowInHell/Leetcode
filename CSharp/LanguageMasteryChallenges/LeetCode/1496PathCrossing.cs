namespace LanguageMasteryChallenges.LeetCode
{
    public class _1496PathCrossing
    {
        public static bool IsPathCrossing(string path)
        {
            HashSet<(int, int)> visited = new HashSet<(int, int)>() { (0, 0) };
            int x = 0, y = 0;

            foreach (char ch in path)
            {
                switch (ch)
                {
                    case 'N':
                        x--;
                        break;
                    case 'E':
                        y++;
                        break;
                    case 'S':
                        x++;
                        break;
                    case 'W':
                        y--;
                        break;
                }
                if (!visited.Add((x, y)))
                {
                    return true;
                }
            }

            return false;
        }
    }
}