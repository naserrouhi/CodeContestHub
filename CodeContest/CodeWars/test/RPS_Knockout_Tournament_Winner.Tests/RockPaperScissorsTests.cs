namespace RPS_Knockout_Tournament_Winner.Tests;

public class RockPaperScissorsTests
{
    [Fact]
    public void ICanWinTheTournament()
    {
        var playground = new RockPaperScissorsPlayground();
        var player = new Player();
        var result = playground.PlayTournament(player);

        foreach (var l in playground.GetMatchResults())
            Console.WriteLine(l);

        if (!result)
            Assert.Fail($"You are eliminated from the tournament by {playground.GetLastOpponent()}!");
    }
}