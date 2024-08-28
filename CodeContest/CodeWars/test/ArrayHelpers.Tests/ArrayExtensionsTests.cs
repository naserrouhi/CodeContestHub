namespace ArrayHelpers.Tests;

public class ArrayExtensionsTests
{
    int[] array = [1, 2, 3, 4, 5];

    [Fact]
    public void ShouldSquareCorrectly()
    {
        Assert.Equal([1, 4, 9, 16, 25], array.Square());
        Assert.Equal([1, 2, 3, 4, 5], array);
        Assert.True(array.Square() is int[]);
    }

    [Fact]
    public void ShouldCubeCorrectly()
    {
        Assert.Equal([1, 8, 27, 64, 125], array.Cube());
        Assert.Equal([1, 2, 3, 4, 5], array);
        Assert.True(array.Cube() is int[]);
    }

    [Fact]
    public void ShouldSumCorrectly()
    {
        Assert.Equal(15, array.Sum());
        Assert.Equal([1, 2, 3, 4, 5], array);
    }

    [Fact]
    public void ShouldAverageCorrectly()
    {
        Assert.Equal(3, array.Average());
        Assert.Equal([1, 2, 3, 4, 5], array);
    }

    [Fact]
    public void ShouldEvenAndOddCorrectly()
    {
        Assert.Equal([2, 4], array.Even());
        Assert.Equal([1, 2, 3, 4, 5], array);
        Assert.True(array.Even() is int[]);

        Assert.Equal([1, 3, 5], array.Odd());
        Assert.Equal([1, 2, 3, 4, 5], array);
        Assert.True(array.Odd() is int[]);
    }
}