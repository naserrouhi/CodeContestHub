namespace Staircase.Tests;

public class StairCaseTests
{
    [Theory]
    [InlineData(1, "#\n")]
    [InlineData(2, " #\n##\n")]
    [InlineData(3, "  #\n ##\n###\n")]
    [InlineData(4, "   #\n  ##\n ###\n####\n")]
    [InlineData(5, "    #\n   ##\n  ###\n ####\n#####\n")]
    public void PrintStaircase_GeneratesExpectedOutput(int staircaseSize, string expectedOutput)
    {
        var writer = new StringWriter();
        Console.SetOut(writer);

        Staircase.Print(staircaseSize);

        var output = writer.ToString().Replace("\r\n", "\n");
        Assert.Equal(expectedOutput, output);
    }
}