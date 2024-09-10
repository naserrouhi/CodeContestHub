namespace Pong.Tests;

public class PongTests
{
    [Fact]
    public void Play()
    {
        var game = new Pong(2);

        Assert.Equal("Player 1 has hit the ball!", game.Play(50, 53));
        Assert.Equal("Player 2 has hit the ball!", game.Play(100, 97));
        Assert.Equal("Player 1 has missed the ball!", game.Play(0, 4));
        Assert.Equal("Player 2 has hit the ball!", game.Play(25, 25));
        Assert.Equal("Player 2 has won the game!", game.Play(75, 25));
        Assert.Equal("Game Over!", game.Play(50, 50));
    }
}