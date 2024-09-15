using System.Reflection;

namespace SimpleClassTerminology.Tests;

public class DemoClassTests
{
    [Fact]
    public void CheckConstructorExists()
    {
        var sut = new DemoClass(15);
    }

    [Fact]
    public void CheckConstructorAssignsToPrivateField()
    {
        for (var i = 0; i < 30; i += 5)
        {
            var sut = new DemoClass(i);
            var fi = typeof(DemoClass).GetField("_privateField", BindingFlags.NonPublic | BindingFlags.Instance);

            Assert.NotNull(fi);
            Assert.Equal(i, fi.GetValue(sut));
        }
    }

    [Fact]
    public void CheckThatPublicFieldExists()
    {
        for (var i = 0; i < 30; i += 5)
        {
            var sut = new DemoClass(0);
            var fi = typeof(DemoClass).GetField("PublicField", BindingFlags.Public | BindingFlags.Instance);

            Assert.NotNull(fi);
            Assert.Equal("None", fi.GetValue(sut));
            Assert.Equal("None", sut.PublicField);
            Assert.True(ReferenceEquals(fi.GetValue(sut), sut.PublicField));
        }
    }

    [Fact]
    public void CheckThatLimitedPropertyExists()
    {
        var type = typeof(DemoClass);
        var ci = type.GetConstructor([typeof(int)]);
        var classObject = ci?.Invoke([24]);
        var pi = type.GetProperty("LimitedProperty", BindingFlags.Instance | BindingFlags.Public);

        Assert.NotNull(pi);

        if (pi.GetGetMethod(nonPublic: false) == null)
            Assert.Fail("Public getter not found");

        if (pi.GetSetMethod(nonPublic: true) == null)
            Assert.Fail("Private setter not found");

        var mi = pi.GetSetMethod(true);

        for (var i = 0; i < 30; i += 5)
        {
            mi?.Invoke(classObject, [i]);
            Assert.Equal(i, ((DemoClass?)classObject).LimitedProperty);
        }
    }
}