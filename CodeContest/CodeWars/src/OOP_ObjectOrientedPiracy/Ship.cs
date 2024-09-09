namespace OOP_ObjectOrientedPiracy;

public class Ship
{
    private const double AverageCrewWeight = 1.5;
    private const double AverageDraftWeight = 20;

    public Ship(int draft, int crew)
    {
        Draft = draft;
        Crew = crew;
    }

    public int Draft { get; private set; }
    public int Crew { get; private set; }

    public bool IsWorthIt()
    {
        var crewWeight = Crew * AverageCrewWeight;

        return Draft - crewWeight > AverageDraftWeight;
    }
}