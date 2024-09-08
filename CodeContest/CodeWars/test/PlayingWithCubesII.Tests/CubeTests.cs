namespace PlayingWithCubesII.Tests;

public class CubeTests
{
    [Fact]
    public static void TestConstructor()
    {
        var cube = new Cube(10);

        Assert.Equal(10, cube.GetSide());
    }
}