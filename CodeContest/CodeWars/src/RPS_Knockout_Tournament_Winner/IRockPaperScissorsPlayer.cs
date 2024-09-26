namespace RPS_Knockout_Tournament_Winner;

public interface IRockPaperScissorsPlayer
{
    public string Name { get; }
    public void SetNewMatch(string opponentName);
    public string GetShape();
    public void SetOpponentShape(string shape);
}