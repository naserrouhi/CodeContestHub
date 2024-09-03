namespace FinishGuessTheNumberGame;

public class Guesser
{
    private readonly int _correctNumber;
    private int _remainedLives;

    public Guesser(int correctNumber, int remainedLives)
    {
        _correctNumber = correctNumber;
        _remainedLives = remainedLives;
    }

    public bool Guess(int guessedNumber)
    {
        if (_remainedLives < 1)
            throw new Exception("You have lost!");

        if (guessedNumber == _correctNumber)
            return true;

        _remainedLives--;

        return false;
    }
}