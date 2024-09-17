namespace FunWithClasses_AnimalsAndInheritance.Tests;

public class SharkTest
{
    [Fact]
    public void ConstructorTest()
    {
        var billy = new Shark("Billy", 3, "Alive and well");

        Assert.Equal("Billy", billy.Name);
        Assert.Equal(3, billy.Age);
        Assert.Equal(0, billy.Legs);
        Assert.Equal("shark", billy.Species);
        Assert.Equal("Alive and well", billy.Status);
        Assert.Equal("Hello, my name is Billy and I am 3 years old.", billy.Introduce());

        var charles = new Shark("Charles", 8, "Looking for a mate");

        Assert.Equal("Charles", charles.Name);
        Assert.Equal(8, charles.Age);
        Assert.Equal(0, charles.Legs);
        Assert.Equal("shark", charles.Species);
        Assert.Equal("Looking for a mate", charles.Status);
        Assert.Equal("Hello, my name is Charles and I am 8 years old.", charles.Introduce());
    }
}