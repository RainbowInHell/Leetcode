namespace LanguageMasteryChallenges.LeetCode;

public class _1217MinimumCostToMoveChipsToTheSamePosition
{
    public static int MinCostToMoveChips(int[] position) 
    {
        var chipsCountOnEvenPositions = 0;
        var chipsCountOnOddPositions = 0;

        foreach (var pos in position)
        {
            if (pos % 2 == 0)
                chipsCountOnEvenPositions++;
            else
                chipsCountOnOddPositions++;
        }

        return Math.Min(chipsCountOnOddPositions, chipsCountOnEvenPositions);
    }
}