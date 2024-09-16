using System.Reflection;

namespace SimpleClassTerminology.Tests;

public class DemoClassTests
{
    [Fact]
    public void CheckConstructorExists()
    {
        var demoClass = new DemoClass(15);
    }

    [Fact]
    public void CheckConstructorAssignsToPrivateField()
    {
        for (var i = 0; i < 30; i += 5)
        {
            var demoClass = new DemoClass(i);
            var privateField = typeof(DemoClass).GetField("_privateField", BindingFlags.NonPublic | BindingFlags.Instance);

            Assert.NotNull(privateField);
            Assert.Equal(i, privateField.GetValue(demoClass));
        }
    }

    [Fact]
    public void CheckThatPublicFieldExists()
    {
        for (var i = 0; i < 30; i += 5)
        {
            var demoClass = new DemoClass(0);
            var publicField = typeof(DemoClass).GetField("PublicField", BindingFlags.Public | BindingFlags.Instance);

            Assert.NotNull(publicField);
            Assert.Equal("None", publicField.GetValue(demoClass));
            Assert.Equal("None", demoClass.PublicField);
            Assert.True(ReferenceEquals(publicField.GetValue(demoClass), demoClass.PublicField));
        }
    }

    [Fact]
    public void CheckThatLimitedPropertyExists()
    {
        var type = typeof(DemoClass);
        var constructorInfo = type.GetConstructor([typeof(int)]);
        var classObject = constructorInfo!.Invoke([24]);
        var propertyInfo = type.GetProperty("LimitedProperty", BindingFlags.Instance | BindingFlags.Public);

        Assert.NotNull(propertyInfo);

        if (propertyInfo.GetGetMethod(nonPublic: false) is null)
            Assert.Fail("Public getter not found.");

        if (propertyInfo.GetSetMethod(nonPublic: true) is null)
            Assert.Fail("Private setter not found.");

        var methodInfo = propertyInfo.GetSetMethod(true);

        for (var i = 0; i < 30; i += 5)
        {
            methodInfo!.Invoke(classObject, [i]);

            Assert.Equal(i, ((DemoClass)classObject).LimitedProperty);
        }
    }
}