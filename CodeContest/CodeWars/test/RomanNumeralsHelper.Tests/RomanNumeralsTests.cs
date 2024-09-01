namespace RomanNumeralsHelper.Tests;

public class RomanNumeralsTests
{
    [Fact]
    public void TestToRoman_001()
    {
        var input = 1;
        var expected = "I";

        string actual = RomanNumerals.ToRoman(input);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestToRoman_002()
    {
        var input = 2;
        var expected = "II";

        var actual = RomanNumerals.ToRoman(input);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestFromRoman_001()
    {
        var input = "I";
        var expected = 1;

        var actual = RomanNumerals.FromRoman(input);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestFromRoman_002()
    {
        var input = "II";
        var expected = 2;

        var actual = RomanNumerals.FromRoman(input);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestFromRoman_006()
    {
        var input = "VI";
        var expected = 6;

        var actual = RomanNumerals.FromRoman(input);

        Assert.Equal(expected, actual);
    }
}