namespace FunWithClasses_AnimalsAndInheritance;

public class Dog : Animal
{
    private readonly string _master;

    public Dog(string name, int age, string status, string master) : base(name, age, 4, "dog", status)
    {
        _master = master;
    }

    public string GreetMaster() => $"Hello {_master}";
}