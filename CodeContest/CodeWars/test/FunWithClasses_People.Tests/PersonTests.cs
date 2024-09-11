namespace FunWithClasses_People.Tests;

public class PersonTests
{
    [Fact]
    public void DefaultArgsTest()
    {
        var person = new Person();

        Assert.Equal("John", person.FirstName);
        Assert.Equal("Doe", person.LastName);
        Assert.Equal(0, person.Age);
        Assert.Equal("Male", person.Gender);
        Assert.Equal("John Doe", person.SayFullName());
    }

    [Fact]
    public void CustomTest()
    {
        Person person = new Person("Jane", "Doe", 25, "Female");

        Assert.Equal("Jane", person.FirstName);
        Assert.Equal("Doe", person.LastName);
        Assert.Equal(25, person.Age);
        Assert.Equal("Female", person.Gender);
        Assert.Equal("Jane Doe", person.SayFullName());
    }
}