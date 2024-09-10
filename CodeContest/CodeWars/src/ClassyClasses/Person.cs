namespace ClassyClasses;

public class Person
{
    private readonly string _name;
    private readonly int _age;

    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public string Info => $"{_name}s age is {_age}";
}