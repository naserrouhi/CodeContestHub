namespace FunWithClasses_AnimalsAndInheritance;

public class Cat : Animal
{
    public Cat(string name, int age, string status) : base(name, age, 4, "cat", status) { }

    public override string Introduce() => $"{base.Introduce()}  Meow meow!";
}