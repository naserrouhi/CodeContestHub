namespace ClassyExtensions.Tests;

public class CatTests
{
    [Fact]
    public void CatCreatesAndSpeaks()
    {
        var cat = new Cat("Mr Whiskers");

        Assert.Equal("Mr Whiskers meows.", cat.Speak());
        Assert.True(cat is Animal);

        cat = new Cat("Lamp");

        Assert.Equal("Lamp meows.", cat.Speak());
        Assert.True(cat is Animal);

        cat = new Cat("$$Money Bags$$");

        Assert.Equal("$$Money Bags$$ meows.", cat.Speak());
        Assert.True(cat is Animal);
    }
}