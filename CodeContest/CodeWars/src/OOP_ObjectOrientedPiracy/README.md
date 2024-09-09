## OOP: Object Oriented Piracy

Ahoy matey!

You are a leader of a small pirate crew. And you have a plan. With the help of OOP you wish to make a pretty efficient system to identify ships with heavy booty on board!

Unfortunately for you, people weigh a lot these days, so how do you know if a ship is full of gold and not people?

You begin with writing a generic Ship class / struct:

```csharp
public class Ship
{
  public int Draft;
  public int Crew;
  
  public Ship(int draft, int crew)
  {
    Draft = draft;
    Crew = crew;
  }
}
```

Every time your spies see a new ship enter the dock, they will create a new ship object based on their observations:

* draft - an estimate of the ship's weight based on how low it is in the water
* crew - the count of crew on board

```csharp
Ship titanic = new Ship(15, 10);
```

### Task
You have access to the ship "draft" and "crew". "Draft" is the total ship weight and "crew" is the number of humans on the ship.

Each crew member adds `1.5` units to the ship draft. If after removing the weight of the crew, the draft is still more than `20`, then the ship is worth looting. Any ship weighing that much must have a lot of booty!

Add the method

```csharp
IsWorthIt
```

to decide if the ship is worthy to loot. For example:

```csharp
titanic.IsWorthIt() => false
```

Good luck and may you find GOOOLD!