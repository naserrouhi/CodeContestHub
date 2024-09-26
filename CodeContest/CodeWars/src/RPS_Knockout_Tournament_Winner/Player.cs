namespace RPS_Knockout_Tournament_Winner;

public class Player : IRockPaperScissorsPlayer
{
    private readonly Random _random;
    private string? _opponentName;

    public Player()
    {
        _random = new Random((int)DateTime.UtcNow.Ticks);
    }

    public string Name => "Naser";

    public void SetNewMatch(string opponentName)
    {
        _opponentName = opponentName;
    }

    public string GetShape()
    {
        return _random.Next(1, 4) switch
        {
            1 => "P",
            2 => "R",
            _ => "S",
        };
    }

    public void SetOpponentShape(string shape)
    {
    }
}