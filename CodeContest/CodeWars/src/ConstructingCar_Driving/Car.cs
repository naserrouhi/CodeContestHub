using System;

namespace ConstructingCar_Driving;

public class Car : ICar
{
    public readonly IDrivingInformationDisplay drivingInformationDisplay;
    public readonly IFuelTankDisplay fuelTankDisplay;
    private readonly IDrivingProcessor drivingProcessor;
    private readonly IEngine engine;
    private readonly IFuelTank fuelTank;

    public Car(double fuelLevel, int maxAcceleration)
    {
        maxAcceleration = Math.Max(maxAcceleration, 5);
        maxAcceleration = Math.Min(maxAcceleration, 20);

        fuelTank = new FuelTank();
        fuelTankDisplay = new FuelTankDisplay(fuelTank);
        engine = new Engine(fuelTank);
        drivingProcessor = new DrivingProcessor(maxAcceleration, engine);
        drivingInformationDisplay = new DrivingInformationDisplay(drivingProcessor);

        fuelTank.Refuel(fuelLevel);
    }

    public Car(double fuelLevel) : this(fuelLevel, 10) { }
    public Car() : this(20, 10) { }

    public bool EngineIsRunning => engine.IsRunning;

    public void Accelerate(int speed)
    {
        drivingProcessor.IncreaseSpeedTo(speed);
    }

    public void BrakeBy(int speed)
    {
        drivingProcessor.ReduceSpeed(speed);
    }

    public void FreeWheel()
    {
        drivingProcessor.ReduceSpeed(1);
    }

    public void EngineStart() => engine.Start();
    public void EngineStop() => engine.Stop();
    public void Refuel(double liters) => fuelTank.Refuel(liters);
    public void RunningIdle() => engine.Consume(0.0003);
}

public class DrivingInformationDisplay : IDrivingInformationDisplay
{
    private readonly IDrivingProcessor _drivingProcessor;

    public DrivingInformationDisplay(IDrivingProcessor drivingProcessor)
    {
        _drivingProcessor = drivingProcessor;
    }

    public int ActualSpeed => _drivingProcessor.ActualSpeed;
}

public class DrivingProcessor : IDrivingProcessor
{
    private readonly IEngine _engine;
    private readonly int _maxAcceleration;

    public DrivingProcessor(int maxAcceleration, IEngine engine)
    {
        _maxAcceleration = maxAcceleration;
        _engine = engine;
    }

    public int ActualSpeed { get; private set; }

    public void IncreaseSpeedTo(int speed)
    {
        if (!_engine.IsRunning)
            return;

        if (speed <= ActualSpeed)
        {
            _engine.Consume(GetFuelConsumption());
            return;
        }

        if (speed - ActualSpeed > _maxAcceleration)
        {
            ActualSpeed += _maxAcceleration;
            ActualSpeed = Math.Min(ActualSpeed, 250);

            _engine.Consume(GetFuelConsumption());

            return;
        }

        ActualSpeed = speed;
        ActualSpeed = Math.Min(ActualSpeed, 250);

        _engine.Consume(GetFuelConsumption());
    }

    public void ReduceSpeed(int speed)
    {
        ActualSpeed -= Math.Min(speed, _maxAcceleration);

        if (ActualSpeed <= 0)
        {
            ActualSpeed = 0;
            _engine.Stop();
        }

        if (ActualSpeed != 0)
            _engine.Consume(GetFuelConsumption());
    }

    private double GetFuelConsumption()
    {
        return ActualSpeed switch
        {
            <= 60 => 0.0020,
            <= 100 => 0.0014,
            <= 140 => 0.0020,
            <= 200 => 0.0025,
            <= 250 => 0.0030,
            _ => 0
        };
    }
}

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

public class FuelTankDisplay : IFuelTankDisplay
{
    private readonly IFuelTank _fuelTank;

    public FuelTankDisplay(IFuelTank fuelTank) => _fuelTank = fuelTank;

    public double FillLevel => Math.Round(_fuelTank.FillLevel, 2);
    public bool IsOnReserve => _fuelTank.IsOnReserve;
    public bool IsComplete => _fuelTank.IsComplete;
}