namespace FunWithClasses_People;

public class Person
{
    public Person(string firstName = "John",
                  string lastName = "Doe",
                  int age = 0,
                  string gender = "Male")
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Gender = gender;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }
    public string Gender { get; private set; }

    public string SayFullName() => $"{FirstName} {LastName}";
    public static string GreetExtraTerrestrials(string raceName) => $"Welcome to Planet Earth {raceName}";
}