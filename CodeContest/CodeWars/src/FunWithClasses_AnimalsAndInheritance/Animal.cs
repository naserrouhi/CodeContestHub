namespace FunWithClasses_AnimalsAndInheritance;

public class Animal
{
    public Animal(string name, int age, int legs, string species, string status)
    {
        Name = name;
        Age = age;
        Legs = legs;
        Species = species;
        Status = status;
    }

    public int Age { get; private set; }
    public int Legs { get; private set; }
    public string Name { get; private set; }
    public string Species { get; private set; }
    public string Status { get; private set; }

    public virtual string Introduce() => $"Hello, my name is {Name} and I am {Age} years old.";
}