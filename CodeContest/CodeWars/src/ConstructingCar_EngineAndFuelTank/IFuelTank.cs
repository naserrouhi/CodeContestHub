namespace ConstructingCar_EngineAndFuelTank;

public interface IFuelTank
{
    double FillLevel { get; }
    bool IsOnReserve { get; }
    bool IsComplete { get; }

    void Consume(double liters);
    void Refuel(double liters);
}