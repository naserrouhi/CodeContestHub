namespace ConstructingCar_EngineAndFuelTank.Tests;

public class CarTests
{
    [Fact]
    public void TestMotorStartAndStop()
    {
        var car = new Car();
        Assert.False(car.EngineIsRunning, "Engine could not be running.");

        car.EngineStart();
        Assert.True(car.EngineIsRunning, "Engine should be running.");

        car.EngineStop();
        Assert.False(car.EngineIsRunning, "Engine could not be running.");
    }

    [Fact]
    public void TestFuelConsumptionOnIdle()
    {
        var car = new Car(1);

        car.EngineStart();
        Enumerable.Range(0, 3000).ToList().ForEach(s => car.RunningIdle());

        Assert.Equal(0.10, car.fuelTankDisplay.FillLevel);
    }

    [Fact]
    public void TestFuelTankDisplayIsComplete()
    {
        var car = new Car(60);

        Assert.True(car.fuelTankDisplay.IsComplete);
    }

    [Fact]
    public void TestFuelTankDisplayIsOnReserve()
    {
        var car = new Car(4);

        Assert.True(car.fuelTankDisplay.IsOnReserve);
    }

    [Fact]
    public void TestRefuel()
    {
        var car = new Car(5);

        car.Refuel(40);

        Assert.Equal(45, car.fuelTankDisplay.FillLevel);
    }
}