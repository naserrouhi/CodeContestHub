namespace CodewarsStyleRankingSystem;

public class UserTests
{
    [Theory]
    [InlineData(-7, -8, 10)]
    [InlineData(-6, -8, 40)]
    [InlineData(-5, -8, 90)]
    [InlineData(-4, -7, 60)]
    [InlineData(-8, -8, 3)]
    public void TestValidSingleRankProgression(int rank, int expectedRank, int expectedProgress)
    {
        var user = new User();

        user.IncreaseProgress(rank);

        AssertRankProgression(rank, user, expectedRank, expectedProgress);
    }

    [Theory]
    [InlineData(9)]
    [InlineData(-9)]
    [InlineData(0)]
    public void TestInvalidRange(int rank)
    {
        var user = new User();

        Assert.Throws<ArgumentException>(() => user.IncreaseProgress(rank));
    }

    private void AssertRankProgression(int rank, User user, int expectedRank, int expectedProgress)
    {
        Assert.True(user.Rank == expectedRank, $"Applied Rank: {rank}; Expected rank: {expectedRank}; Actual: {user.Rank};");

        Assert.True(user.Progress == expectedProgress, $"Applied Rank; {rank}; Expected progress: {expectedProgress}; Actual: {user.Progress}");
    }
}