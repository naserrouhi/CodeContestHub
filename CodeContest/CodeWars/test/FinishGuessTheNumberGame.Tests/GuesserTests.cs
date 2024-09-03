namespace FinishGuessTheNumberGame.Tests;

public class GuesserTests
{
    [Fact]
    public void _0_Correct_Guess_Should_Return_True()
    {
        var guesser = new Guesser(10, 2);

        guesser.Guess(10);
        guesser.Guess(10);
        guesser.Guess(10);
        guesser.Guess(10);

        Assert.True(guesser.Guess(10));
    }
    
    [Fact]
    public void _1_Wrong_Guess_Should_Return_False()
    {
        var guesser = new Guesser(10, 2);

        guesser.Guess(1);

        Assert.False(guesser.Guess(1));
    }
    
    [Fact]
    public void _3_Lives_Ran_Out_Should_Throw()
    {
        var guesser = new Guesser(10, 2);
        var pass = false;

        guesser.Guess(1);
        guesser.Guess(2);

        try
        {
            guesser.Guess(10);
        }
        catch
        {
            pass = true;
        }
        
        Assert.True(pass, "Expected error thrown.");
    }
}