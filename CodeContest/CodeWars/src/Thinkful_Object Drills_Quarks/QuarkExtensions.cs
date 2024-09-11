namespace Thinkful_ObjectDrills_Quarks;

public static class QuarkExtensions
{
    public static void Interact(this Quark firstQuark, Quark secondQuark)
    {
        var firstQuarkColor = firstQuark.Color;

        firstQuark.ChangeColor(secondQuark.Color);
        secondQuark.ChangeColor(firstQuarkColor);
    }
}