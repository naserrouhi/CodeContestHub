namespace FunWithClasses_AnimalsAndInheritance.Tests;

public class CatTest
{
    [Fact]
    public void ConstructorTest()
    {
        var cathy = new Cat("Cathy", 7, "Playing with a ball of yarn");

        Assert.Equal("Cathy", cathy.Name);
        Assert.Equal(7, cathy.Age);
        Assert.Equal(4, cathy.Legs);
        Assert.Equal("cat", cathy.Species);
        Assert.Equal("Playing with a ball of yarn", cathy.Status);
        Assert.Equal("Hello, my name is Cathy and I am 7 years old.  Meow meow!", cathy.Introduce());

        var spitsy = new Cat("Spitsy", 6, "sleeping");

        Assert.Equal("Spitsy", spitsy.Name);
        Assert.Equal(6, spitsy.Age);
        Assert.Equal(4, spitsy.Legs);
        Assert.Equal("cat", spitsy.Species);
        Assert.Equal("sleeping", spitsy.Status);
        Assert.Equal("Hello, my name is Spitsy and I am 6 years old.  Meow meow!", spitsy.Introduce());
    }
}