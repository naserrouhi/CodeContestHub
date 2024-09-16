using System.ComponentModel;
using System.Numerics;

namespace ProgramCalculator_3DVectors.Tests;

public class VectorTests
{
    private static readonly double epsilon = 1e-6;

    [Test, Description("should have a working class constructor (Example Tests)")]
    public void ConstructorTest()
    {
        Vector v = new Vector(1, 2, 3);
        Assert.AreEqual(1, v.I, "Value of first argument passed into class constructor should be assigned to property \"I\"");
        Assert.AreEqual(2, v.J, "Value of second argument passed into class constructor should be assigned to property \"J\"");
        Assert.AreEqual(3, v.K, "Value of third argument passed into class constructor should be assigned to property \"K\"");
        v = new Vector(-4 / 3d, 40 / 27d, 68 / 69d);
        Assert.That(v.I, Is.EqualTo(-4 / 3d).Within(epsilon), "Property \"I\" of Vector should equal -4 / 3");
        Assert.That(v.J, Is.EqualTo(40 / 27d).Within(epsilon), "Property \"J\" of Vector should equal 40 / 27");
        Assert.That(v.K, Is.EqualTo(68 / 69d).Within(epsilon), "Property \"K\" of Vector should equal 68 / 69");
    }

    [Test, Description("should have a working \"GetMagnitude\" method (Example Test)")]
    public void GetMagnitudeTest()
    {
        Vector v = new Vector(6, 10, -3);
        Assert.That(v.GetMagnitude(), Is.EqualTo(Math.Sqrt(145)).Within(epsilon));
    }

    [Test, Description("should have working class methods \"GetI\", \"GetJ\" and \"GetK\"")]
    public void ClassMethodsTest()
    {
        Vector i = Vector.GetI();
        Vector j = Vector.GetJ();
        Vector k = Vector.GetK();
        Assert.AreEqual(1, i.I);
        Assert.AreEqual(0, i.J);
        Assert.AreEqual(0, i.K);
        Assert.AreEqual(0, j.I);
        Assert.AreEqual(1, j.J);
        Assert.AreEqual(0, j.K);
        Assert.AreEqual(0, k.I);
        Assert.AreEqual(0, k.J);
        Assert.AreEqual(1, k.K);
    }

    [Test, Description("should have a working \"Add\" method (Example Test)")]
    public void AddTest()
    {
        Vector v = new Vector(3, 7 / 2d, -3 / 2d);
        Vector s = v.Add(new Vector(-27, 3, 4));
        Assert.That(s is Vector, "The sum of two vectors is a vector");
        Assert.That(s.I, Is.EqualTo(-24d).Within(epsilon));
        Assert.That(s.J, Is.EqualTo(13 / 2d).Within(epsilon));
        Assert.That(s.K, Is.EqualTo(5 / 2d).Within(epsilon));
    }

    [Test, Description("should have a working \"MultiplyByScalar\" method (Example Test)")]
    public void MultiplyTest()
    {
        Vector v = new Vector(1 / 3d, 177 / 27d, -99);
        Vector e = v.MultiplyByScalar(-3 / 7d);
        Assert.That(e.I, Is.EqualTo(-1 / 7d).Within(epsilon));
        Assert.That(e.J, Is.EqualTo(-59 / 21d).Within(epsilon));
        Assert.That(e.K, Is.EqualTo(297 / 7d).Within(epsilon));
    }

    [Test, Description("should have a working \"Dot\" method (Example Test)")]
    public void DotTest()
    {
        Vector v = new Vector(-99 / 71d, 22 / 23d, 45);
        Assert.That(v.Dot(new Vector(-5, 4, 7)), Is.EqualTo(325.7979179).Within(epsilon));
    }

    [Test, Description("should have a working \"Cross\" method (Example Test)")]
    public void CrossTest()
    {
        Vector a = new Vector(2, 1, 3);
        Vector b = new Vector(4, 6, 5);
        Vector aCrossB = a.Cross(b);
        Vector bCrossA = b.Cross(a);
        Assert.That(aCrossB.I, Is.EqualTo(-13).Within(epsilon));
        Assert.That(aCrossB.J, Is.EqualTo(2).Within(epsilon));
        Assert.That(aCrossB.K, Is.EqualTo(8).Within(epsilon));
        Assert.That(bCrossA.I, Is.EqualTo(13).Within(epsilon));
        Assert.That(bCrossA.J, Is.EqualTo(-2).Within(epsilon));
        Assert.That(bCrossA.K, Is.EqualTo(-8).Within(epsilon));
    }

    [Test, Description("should have a working \"IsParallelTo\" method (Example Tests)")]
    public void ParallelTest()
    {
        Vector a = new Vector(1045 / 23d, -666 / 37d, 15);
        Vector b = new Vector(161.3385037, -59124 / 925d, 9854 / 185d);
        Assert.That(a.IsParallelTo(b));
        Assert.That(b.IsParallelTo(a));
        Vector c = new Vector(-3, 0, 5);
        Vector d = new Vector(-12, 1, 20);
        Assert.That(!c.IsParallelTo(d));
        Assert.That(!d.IsParallelTo(c));
    }

    [Test, Description("should have a working \"IsPerpendicularTo\" method (Example Tests)")]
    public void PerpendicularTest()
    {
        Vector a = new Vector(3, 4, 7);
        Vector b = new Vector(1 / 3d, 2, -9 / 7d);
        Assert.That(a.IsPerpendicularTo(b));
        Assert.That(b.IsPerpendicularTo(a));
        Vector c = new Vector(1, 3, 5);
        Vector d = new Vector(-2, -7, 4.4);
        Assert.That(!c.IsPerpendicularTo(d));
        Assert.That(!d.IsPerpendicularTo(c));
    }

    [Test, Description("should have a working \"Normalize\" method (Example Test)")]
    public void NormalizeTest()
    {
        Vector v = new Vector(-1, -1, 1);
        Vector u = v.Normalize();
        Assert.That(u.GetMagnitude(), Is.EqualTo(1).Within(epsilon));
        Assert.That(u.I, Is.EqualTo(-1 / Math.Sqrt(3)).Within(epsilon));
        Assert.That(u.J, Is.EqualTo(-1 / Math.Sqrt(3)).Within(epsilon));
        Assert.That(u.K, Is.EqualTo(1 / Math.Sqrt(3)).Within(epsilon));
    }

    [Test, Description("should have a working \"IsNormalized\" method (Example Tests)")]
    public void IsNormalized()
    {
        Vector a = new Vector(-1 / Math.Sqrt(2), 0, 1 / Math.Sqrt(2));
        Vector b = new Vector(1, 1, 1);
        Assert.That(a.IsNormalized());
        Assert.That(!b.IsNormalized());
    }
}