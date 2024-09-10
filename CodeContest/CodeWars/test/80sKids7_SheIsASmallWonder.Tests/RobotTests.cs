namespace _80sKids7_SheIsASmallWonder.Tests;

public class RobotTests
{
    [Fact]
    public void SampleTests()
    {
        var vicky = new Robot();

        Assertion(vicky, "hello", "Thank you for teaching me hello");
        Assertion(vicky, "world", "Thank you for teaching me world");
        Assertion(vicky, "goodbye", "Thank you for teaching me goodbye");

        Assertion(vicky, "world", "I already know the word world");
        Assertion(vicky, "World", "I already know the word World");

        Assertion(vicky, "C#", "I do not understand the input");

        Assertion(vicky, "thank", "I already know the word thank");
    }

    private static void Assertion(Robot robot, string input, string expected) => 
        Assert.Equal(expected, robot.LearnWord(input));
}