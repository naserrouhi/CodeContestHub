namespace BuildingSpheres.Tests;

public class SphereTests
{
    [Fact]
    public static void ExampleTest()
    {
        var ball = new Sphere(2, 50);

        Assert.Equal(2, ball.GetRadius());
        Assert.Equal(50, ball.GetMass());
        Assert.Equal(33.51032, ball.GetVolume());
        Assert.Equal(50.26548, ball.GetSurfaceArea());
        Assert.Equal(1.49208, ball.GetDensity());
    }
}