namespace RPS_Knockout_Tournament_Winner;

public class RockPaperScissorsPlayground
{
    private Player _player;

    public bool PlayTournament(Player player)
    {
        _player = player;
        return true;
    }

    public string GetMatchResults()
    {
        return string.Empty;
    }

    public Player GetLastOpponent()
    {
        return new();
    }
}