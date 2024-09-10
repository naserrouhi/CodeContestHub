namespace Pong;

public class Pong
{
    private readonly int _maxScore;

    private readonly int _paddleHeight = 7;
    private readonly int _ballHeight = 1;

    private int _playerTurn;
    private int _player1Score;
    private int _player2Score;

    public Pong(int maxScore)
    {
        _maxScore = maxScore;

        _playerTurn = 1;
    }

    public string Play(int ballPosition, int playerPosition)
    {
        var response = string.Empty;

        if (playerPosition - ballPosition <= 3.5)
        {
            if (_playerTurn == 1)
                _player1Score++;
            else
                _player2Score++;

            response = $"Player {_playerTurn} has hit the ball!";
        }
        else
            response = $"Player {_playerTurn} has missed the ball!";

        _playerTurn = _playerTurn == 1 ? 2 : 1;

        return response;
    }
}