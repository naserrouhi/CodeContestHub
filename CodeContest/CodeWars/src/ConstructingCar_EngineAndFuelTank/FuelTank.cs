namespace ConstructingCar_EngineAndFuelTank;

public class FuelTank : IFuelTank
{
    public double FillLevel { get; private set; }

    public bool IsOnReserve => FillLevel < 5;
    public bool IsComplete => FillLevel == 60;

    public void Consume(double liters)
    {
        if (liters < 0)
            return;

        FillLevel -= liters;

        FillLevel = Math.Max(FillLevel, 0);
    }

    public void Refuel(double liters)
    {
        if (liters < 0)
            return;

        FillLevel += liters;

        FillLevel = Math.Min(FillLevel, 60);
    }
}