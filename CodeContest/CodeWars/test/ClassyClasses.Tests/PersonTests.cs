namespace ClassyClasses.Tests;

public class PersonTests
{
    [Fact]
    public void CreateAPersonAndHaveGetterForTheInfoProperty()
    {
        var john = new Person("john", 34);

        Assert.Equal("johns age is 34", john.Info);
    }
}