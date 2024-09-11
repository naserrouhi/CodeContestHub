namespace ClassyExtensions;

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override string Speak() => $"{_name} meows.";
}

public class Animal
{
    protected readonly string _name;

    public Animal(string name) => _name = name;

    public virtual string Speak() => _name;
}