namespace CodewarsStyleRankingSystem;

public class User
{
    private static int[] _acceptableRanks = [-8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8];

    private int _totalProgress;

    public int Progress => _totalProgress % 100;
    public int Rank => _acceptableRanks[_totalProgress / 100];

    public void IncreaseProgress(int actRank)
    {
        if (actRank > 8 || actRank == 0 || actRank < -8)
            throw new ArgumentException();

        var ranksSubtraction = actRank - Rank;

        if (ranksSubtraction < -1)
            return;

        if (ranksSubtraction > 0)
        {
            _totalProgress += (10 * ranksSubtraction * ranksSubtraction);
            return;
        }

        if (ranksSubtraction == 0)
        {
            _totalProgress += 3;
            return;
        }

        if (ranksSubtraction == -1)
        {
            _totalProgress += 1;
            return;
        }
    }
}