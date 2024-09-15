namespace SimpleClassTerminology;

public class DemoClass
{
    private readonly int _privateField;

    public string PublicField = "None";

    public int LimitedProperty { get; private set; }

    public DemoClass(int privateField)
    {
        _privateField = privateField;
    }
}