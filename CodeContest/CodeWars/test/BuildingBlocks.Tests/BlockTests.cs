namespace BuildingBlocks.Tests;

public class BlockTests
{
    [Fact]
    public static void ExampleTest()
    {
        var block = new Block([2, 2, 2]);

        Assert.Equal(2, block.GetWidth());
        Assert.Equal(2, block.GetLength());
        Assert.Equal(2, block.GetHeight());
        Assert.Equal(8, block.GetVolume());
        Assert.Equal(24, block.GetSurfaceArea());
    }
}