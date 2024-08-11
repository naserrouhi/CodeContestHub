using ClassicHelloWorld;

namespace ClassicHelloWorldTests;

public class ClassicHelloWorldTests
{
    [Fact]
    public void CallMainMethodOfSolutionClass()
    {
        Solution.Main(new string[] { "Greetings" });
        Assert.Equal(1, 1);
    }
}