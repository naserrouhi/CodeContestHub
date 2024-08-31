namespace BasicSubclasses_AdamAndEve;

public class God
{
    public static Human[] Create() => [new Man(), new Woman()];
}

public class Human
{
}

public class Man : Human
{
}

public class Woman : Human
{
}