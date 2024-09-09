namespace OOP_ObjectOrientedPiracy.Tests;

public class ShipTests
{
    [Fact]
    public void SampleTests()
    {
        Assert.False(new Ship(15, 10).IsWorthIt());
        Assert.False(new Ship(15, 20).IsWorthIt());
        Assert.True(new Ship(100, 20).IsWorthIt());
        Assert.False(new Ship(35, 20).IsWorthIt());
    }

    [Fact]
    public void MutationTest()
    {
        var titanic = new Ship(15, 10);
        titanic.IsWorthIt();

        Assert.Equal(15, titanic.Draft);
        Assert.Equal(10, titanic.Crew);
    }
}