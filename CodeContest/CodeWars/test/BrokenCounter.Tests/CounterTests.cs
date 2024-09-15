namespace BrokenCounter.Tests;

public class CounterTests
{
    [Fact]
    public void Test()
    {
        var counter = new Counter();

        Assert.Equal(0, counter.Value);
        counter.Increase();

        Assert.Equal(1, counter.Value);

        counter.Reset();
        Assert.Equal(0, counter.Value);
    }
}