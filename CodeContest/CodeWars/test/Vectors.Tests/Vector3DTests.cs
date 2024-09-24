namespace Vectors.Tests;

public class Vector3DTests
{
    [Theory]
    [InlineData(0, 2, 0, 2)]
    [InlineData(1, 2, 2, 3)]
    public void FixedTest(double x, double y, double z, double expectedLength)
    {
        var length = new Vector3D
        {
            X = x,
            Y = y,
            Z = z
        }.Length;

        Assert.Equal(expectedLength, length);
    }
}