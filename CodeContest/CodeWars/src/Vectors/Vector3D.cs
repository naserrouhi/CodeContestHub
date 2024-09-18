namespace Vectors;

public class Vector3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public double Length => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
}