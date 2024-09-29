namespace ConstructingCar_Driving;

public interface ICar
{
    bool EngineIsRunning { get; }

    void BrakeBy(int speed);
    void Accelerate(int speed);
    void EngineStart();
    void EngineStop();
    void FreeWheel();
    void Refuel(double liters);
    void RunningIdle();
}