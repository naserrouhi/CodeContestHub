namespace BasicSubclasses_AdamAndEve.Tests;

public class GodTests
{
    [Fact]
    public void SampleTest()
    {
        Human[] humans = God.Create();

        Assert.True(humans[0] is Man, "The first object in the array should be a Man");
    }
}