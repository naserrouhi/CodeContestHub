namespace ProgramCalculator_3DVectors;

public class Vector
{
    private const double Epsilon = 1e-6;

    public Vector(double i, double j, double k)
    {
        I = i;
        J = j;
        K = k;
    }

    public double I { get; private set; }
    public double J { get; private set; }
    public double K { get; private set; }

    public static Vector GetI() => new(1, 0, 0);
    public static Vector GetJ() => new(0, 1, 0);
    public static Vector GetK() => new(0, 0, 1);

    public double GetMagnitude() => Math.Sqrt(Math.Pow(I, 2) + Math.Pow(J, 2) + Math.Pow(K, 2));

    public Vector Add(Vector vector) => new(I + vector.I, J + vector.J, K + vector.K);

    public double Dot(Vector vector) => I * vector.I + J * vector.J + K * vector.K;

    public Vector Cross(Vector vector)
    {
        var x = (J * vector.K) - (K * vector.J);
        var y = (K * vector.I) - (I * vector.K);
        var z = (I * vector.J) - (J * vector.I);

        return new(x, y, z);
    }

    public Vector MultiplyByScalar(double number)
    {
        I *= number;
        J *= number;
        K *= number;

        return this;
    }

    public bool IsParallelTo(Vector vector)
    {
        if (IsZeroVector(vector) || IsZeroVector(this))
            return false;

        var crossedVector = Cross(vector);

        return IsZeroVector(crossedVector);
    }

    public Vector Normalize()
    {
        var magnitude = GetMagnitude();

        return new(I / magnitude, J / magnitude, K / magnitude);
    }

    public bool IsNormalized() => Math.Abs(GetMagnitude() - 1) < Epsilon;

    public bool IsPerpendicularTo(Vector vector)
    {
        if (IsZeroVector(vector) || IsZeroVector(this))
            return false;

        return Math.Abs(Dot(vector)) <= Epsilon;
    }

    private bool IsZeroVector(Vector vector) => Math.Abs(vector.I) <= Epsilon &&
                                                Math.Abs(vector.J) <= Epsilon &&
                                                Math.Abs(vector.K) <= Epsilon;
}