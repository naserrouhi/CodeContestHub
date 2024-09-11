namespace Thinkful_ObjectDrills_Quarks;

public class Quark
{
    private string[] _validColors = ["red", "blue", "green"];
    private string[] _validFlavors = ["up", "down", "strange", "charm", "top", "bottom"];

    public string Color { get; private set; }
    public string Flavor { get; private set; }
    public double BaryonNumber => 1d / 3;

    public Quark(string color, string flavor)
    {
        if (!_validColors.Contains(color))
            throw new ArgumentException("Color is not valid!");

        if (!_validFlavors.Contains(flavor))
            throw new ArgumentException("Flavor is not valid!");

        Color = color;
        Flavor = flavor;
    }

    public void ChangeColor(string color)
    {
        if (!_validColors.Contains(color))
            throw new ArgumentException("Color is not valid!");

        Color = color;
    }
}