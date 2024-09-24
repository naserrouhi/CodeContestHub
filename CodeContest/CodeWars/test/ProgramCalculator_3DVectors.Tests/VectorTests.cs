namespace ProgramCalculator_3DVectors.Tests;

public class VectorTests
{
    private static readonly double epsilon = 1e-6;

    [Fact]
    public void ConstructorTest()
    {
        var vector = new Vector(1, 2, 3);

        Assert.Equal(1, vector.I);
        Assert.Equal(2, vector.J);
        Assert.Equal(3, vector.K);

        vector = new Vector(-4 / 3d, 40 / 27d, 68 / 69d);

        Assert.Equal(-4 / 3d, vector.I, epsilon);
        Assert.Equal(40 / 27d, vector.J, epsilon);
        Assert.Equal(68 / 69d, vector.K, epsilon);
    }

    [Fact]
    public void GetMagnitudeTest()
    {
        var vector = new Vector(6, 10, -3);

        Assert.Equal(Math.Sqrt(145), vector.GetMagnitude(), epsilon);
    }

    [Fact]
    public void ClassMethodsTest()
    {
        var i = Vector.GetI();
        var j = Vector.GetJ();
        var k = Vector.GetK();

        Assert.Equal(1, i.I);
        Assert.Equal(0, i.J);
        Assert.Equal(0, i.K);
        Assert.Equal(0, j.I);
        Assert.Equal(1, j.J);
        Assert.Equal(0, j.K);
        Assert.Equal(0, k.I);
        Assert.Equal(0, k.J);
        Assert.Equal(1, k.K);
    }

    [Fact]
    public void AddTest()
    {
        var v = new Vector(3, 7 / 2d, -3 / 2d);
        var s = v.Add(new Vector(-27, 3, 4));

        Assert.IsType<Vector>(s);
        Assert.Equal(-24d, s.I, epsilon);
        Assert.Equal(13 / 2d, s.J, epsilon);
        Assert.Equal(5 / 2d, s.K, epsilon);
    }

    [Fact]
    public void MultiplyTest()
    {
        var vector = new Vector(1 / 3d, 177 / 27d, -99);
        var multipliedVector = vector.MultiplyByScalar(-3 / 7d);

        Assert.Equal(-1 / 7d, multipliedVector.I, epsilon);
        Assert.Equal(-59 / 21d, multipliedVector.J, epsilon);
        Assert.Equal(297 / 7d, multipliedVector.K, epsilon);
    }

    [Fact]
    public void DotTest()
    {
        var vector = new Vector(-99 / 71d, 22 / 23d, 45);

        Assert.Equal(325.7979179, vector.Dot(new Vector(-5, 4, 7)), epsilon);
    }

    [Fact]
    public void CrossTest()
    {
        var a = new Vector(2, 1, 3);
        var b = new Vector(4, 6, 5);

        var aCrossB = a.Cross(b);
        var bCrossA = b.Cross(a);

        Assert.Equal(-13, aCrossB.I, epsilon);
        Assert.Equal(2, aCrossB.J, epsilon);
        Assert.Equal(8, aCrossB.K, epsilon);

        Assert.Equal(13, bCrossA.I, epsilon);
        Assert.Equal(-2, bCrossA.J, epsilon);
        Assert.Equal(-8, bCrossA.K, epsilon);
    }

    [Fact]
    public void ParallelTest()
    {
        var a = new Vector(1045 / 23d, -666 / 37d, 15);
        var b = new Vector(161.3385037, -59124 / 925d, 9854 / 185d);

        Assert.True(a.IsParallelTo(b));
        Assert.True(b.IsParallelTo(a));

        var c = new Vector(-3, 0, 5);
        var d = new Vector(-12, 1, 20);

        Assert.False(c.IsParallelTo(d));
        Assert.False(d.IsParallelTo(c));
    }

    [Fact]
    public void PerpendicularTest()
    {
        var a = new Vector(3, 4, 7);
        var b = new Vector(1 / 3d, 2, -9 / 7d);

        Assert.True(a.IsPerpendicularTo(b));
        Assert.True(b.IsPerpendicularTo(a));

        var c = new Vector(1, 3, 5);
        var d = new Vector(-2, -7, 4.4);

        Assert.False(c.IsPerpendicularTo(d));
        Assert.False(d.IsPerpendicularTo(c));
    }

    [Fact]
    public void NormalizeTest()
    {
        var v = new Vector(-1, -1, 1);
        var u = v.Normalize();

        Assert.Equal(1, u.GetMagnitude(), epsilon);
        Assert.Equal(-1 / Math.Sqrt(3), u.I, epsilon);
        Assert.Equal(-1 / Math.Sqrt(3), u.J, epsilon);
        Assert.Equal(1 / Math.Sqrt(3), u.K, epsilon);
    }

    [Fact]
    public void IsNormalized()
    {
        var a = new Vector(-1 / Math.Sqrt(2), 0, 1 / Math.Sqrt(2));
        var b = new Vector(1, 1, 1);

        Assert.True(a.IsNormalized());
        Assert.False(b.IsNormalized());
    }
}