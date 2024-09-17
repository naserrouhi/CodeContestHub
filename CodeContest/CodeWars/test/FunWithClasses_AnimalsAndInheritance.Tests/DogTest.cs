namespace FunWithClasses_AnimalsAndInheritance.Tests;

public class DogTest
{
    [Fact]
    public void ConstructorTest()
    {
        var doug = new Dog("Doug", 12, "Serving his master", "Eliza");

        Assert.Equal("Doug", doug.Name);
        Assert.Equal(12, doug.Age);
        Assert.Equal(4, doug.Legs);
        Assert.Equal("dog", doug.Species);
        Assert.Equal("Serving his master", doug.Status);
        Assert.Equal("Hello Eliza", doug.GreetMaster());
    }
}