namespace Staircase.Tests;

public class ResultTests
{
    [Theory]
    [InlineData(1, "#\n")]
    [InlineData(2, " #\n##\n")]
    [InlineData(3, "  #\n ##\n###\n")]
    [InlineData(4, "   #\n  ##\n ###\n####\n")]
    [InlineData(5, "    #\n   ##\n  ###\n ####\n#####\n")]
    public void PrintStaircase_GeneratesExpectedOutput(int size, string expectedOutput)
    {
        var writer = new StringWriter();
        Console.SetOut(writer);

        Result.PrintStaircase(size);

        var output = writer.ToString().Replace("\r\n", "\n");
        Assert.Equal(expectedOutput, output);
    }
}