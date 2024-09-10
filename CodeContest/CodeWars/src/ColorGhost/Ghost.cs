namespace ColorGhost;

public class Ghost
{
    private readonly string[] _colors = { "white", "yellow", "purple", "red" };

    public Ghost()
    {
        var random = new Random();
        var randomIndex = random.Next(0, _colors.Length);

        Color = _colors[randomIndex];
    }

    public string Color { get; private set; }
}