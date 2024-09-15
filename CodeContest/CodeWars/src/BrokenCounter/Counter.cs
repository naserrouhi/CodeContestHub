namespace BrokenCounter;

public class Counter
{
    private int _value;

    public int Value
    {
        get => _value;
        private set => _value = value;
    }

    public void Increase() => ++Value;

    public void Reset() => Value = 0;
}