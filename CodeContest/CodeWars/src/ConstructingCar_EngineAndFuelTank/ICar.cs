namespace ConstructingCar_EngineAndFuelTank;

public interface ICar
{
    bool EngineIsRunning { get; }

    void EngineStart();
    void EngineStop();
    void Refuel(double liters);
    void RunningIdle();
}