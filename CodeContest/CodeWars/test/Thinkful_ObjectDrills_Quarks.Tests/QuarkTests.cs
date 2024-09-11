namespace Thinkful_ObjectDrills_Quarks.Tests;

public class QuarkTests
{
    [Fact]
    public void SampleTest()
    {
        var q1 = new Quark("red", "up");
        var q2 = new Quark("blue", "strange");

        Assert.Equal("red", q1.Color);
        Assert.Equal("strange", q2.Flavor);
        Assert.Equal(1 / 3d, q2.BaryonNumber);

        q1.Interact(q2);
        Assert.Equal("blue", q1.Color);
    }
}