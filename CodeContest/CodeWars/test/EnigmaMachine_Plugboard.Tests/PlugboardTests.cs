namespace EnigmaMachine_Plugboard.Tests;

public class PlugboardTests
{
    [Fact]
    public void ValidConstruction()
    {
        var pb = new Plugboard("AB");

        Assert.Equal('B', pb.Process('A'));
        Assert.Equal('A', pb.Process('B'));
        Assert.Equal('C', pb.Process('C'));
    }
}