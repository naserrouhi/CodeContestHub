namespace ConstructingCar_EngineAndFuelTank;

public class Engine : IEngine
{
    private readonly IFuelTank _fuelTank;

    public Engine(IFuelTank fuelTank) => _fuelTank = fuelTank;

    public bool IsRunning { get; private set; }

    public void Consume(double liters)
    {
        if (!IsRunning)
            return;

        _fuelTank.Consume(liters);

        if (_fuelTank.FillLevel == 0)
            Stop();
    }

    public void Stop() => IsRunning = false;

    public void Start()
    {
        if (_fuelTank.FillLevel > 0)
            IsRunning = true;
    }
}