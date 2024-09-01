namespace CodewarsStyleRankingSystem;

public class User
{
    private static int[] _acceptableRanks = [-8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8];

    private int _totalProgress;

    public int Progress => _totalProgress % 100;
    public int Rank => _acceptableRanks[Math.Min(_totalProgress / 100, _acceptableRanks.Length - 1)];

    public void IncreaseProgress(int actRank)
    {
        if (actRank > 8 || actRank == 0 || actRank < -8)
            throw new ArgumentException("actRank is not valid.");

        var rankIndex = Array.IndexOf(_acceptableRanks, Rank);
        var actRankIndex = Array.IndexOf(_acceptableRanks, actRank);

        var rankDifference = actRankIndex - rankIndex;

        if (rankDifference > 0)
            _totalProgress += (10 * rankDifference * rankDifference);
        else if (rankDifference == 0)
            _totalProgress += 3;
        else if (rankDifference == -1)
            _totalProgress += 1;

        var maxProgress = (_acceptableRanks.Length - 1) * 100;

        if (_totalProgress > maxProgress)
            _totalProgress = maxProgress;
    }
}