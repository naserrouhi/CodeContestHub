namespace Mini_Max_Sum.Tests;

public class ListSummarizerTests
{
    [Theory]
    [InlineData(new long[] { 1, 2, 3, 4, 5 }, "10 14")]
    [InlineData(new long[] { 7, 7, 7, 7, 7 }, "28 28")]
    [InlineData(new long[] { 1, 3, 5, 7, 9 }, "16 24")]
    [InlineData(new long[] { 100, 200, 300, 400, 500 }, "1000 1400")]
    [InlineData(new long[] { -1, -2, -3, -4, -5 }, "-14 -10")]
    public void PrintMinAndMaxSumOf4Numbers_GeneratesExpectedOutput(long[] numbers, string expectedOutput)
    {
        var numberList = new List<long>(numbers);
        var writer = new StringWriter();
        Console.SetOut(writer);

        ListSummarizer.PrintMinAndMaxSumOf4Numbers(numberList);

        var output = writer.ToString().Trim();
        Assert.Equal(expectedOutput, output);
    }
}