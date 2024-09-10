namespace ColorGhost.Tests;

public class GhostTests
{
    [Fact]
    public void GetColorShouldReturnsGhostColor()
    {
        var ghost = new Ghost();

        Assert.NotEmpty(ghost.GetColor());
    }
}