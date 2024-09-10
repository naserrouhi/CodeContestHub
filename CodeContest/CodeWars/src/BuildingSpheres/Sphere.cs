namespace BuildingSpheres;

public class Sphere
{
    private readonly int _radius;
    private readonly int _mass;

    public Sphere(int radius, int mass)
    {
        _radius = radius;
        _mass = mass;
    }

    public int GetRadius() => _radius;
    public int GetMass() => _mass;

    public double GetVolume()
    {
        var volume = (double)4 / 3 * Math.PI * Math.Pow(_radius, 3);

        return Math.Round(volume, 5);
    }

    public double GetSurfaceArea()
    {
        var surfaceArea = 4 * Math.PI * Math.Pow(_radius, 2);

        return Math.Round(surfaceArea, 5);
    }

    public double GetDensity()
    {
        var density = _mass / GetVolume();

        return Math.Round(density, 5);
    }
}