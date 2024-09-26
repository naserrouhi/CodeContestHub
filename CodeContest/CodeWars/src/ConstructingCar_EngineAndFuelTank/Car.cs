namespace ConstructingCar_EngineAndFuelTank;

public class Car : ICar
{
    public readonly IFuelTankDisplay fuelTankDisplay;
    private readonly IEngine engine;
    private readonly IFuelTank fuelTank;

    public Car(double fuelLevel)
    {
        fuelTank = new FuelTank();
        fuelTankDisplay = new FuelTankDisplay(fuelTank);
        engine = new Engine(fuelTank);

        fuelTank.Refuel(fuelLevel);
    }

    public Car() : this(20) { }

    public bool EngineIsRunning => engine.IsRunning;

    public void EngineStart() => engine.Start();
    public void EngineStop() => engine.Stop();
    public void Refuel(double liters) => fuelTank.Refuel(liters);
    public void RunningIdle() => engine.Consume(0.0003);
}