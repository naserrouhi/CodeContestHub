namespace ConstructingCar_Driving.Tests;

public class CarTests
{
    [Fact]
    public void TestStartSpeed()
    {
        var car = new Car();

        car.EngineStart();

        Assert.Equal(0, car.drivingInformationDisplay.ActualSpeed);
    }

    [Fact]
    public void TestFreeWheelSpeed()
    {
        var car = new Car();

        car.EngineStart();
        Enumerable.Range(0, 10).ToList().ForEach(s => car.Accelerate(100));

        Assert.Equal(100, car.drivingInformationDisplay.ActualSpeed);

        car.FreeWheel();
        car.FreeWheel();
        car.FreeWheel();

        Assert.Equal(97, car.drivingInformationDisplay.ActualSpeed);
    }

    [Fact]
    public void TestAccelerateBy10()
    {
        var car = new Car();

        car.EngineStart();
        Enumerable.Range(0, 10).ToList().ForEach(s => car.Accelerate(100));

        car.Accelerate(160);
        Assert.Equal(110, car.drivingInformationDisplay.ActualSpeed);

        car.Accelerate(160);
        Assert.Equal(120, car.drivingInformationDisplay.ActualSpeed);

        car.Accelerate(160);
        Assert.Equal(130, car.drivingInformationDisplay.ActualSpeed);

        car.Accelerate(160);
        Assert.Equal(140, car.drivingInformationDisplay.ActualSpeed);

        car.Accelerate(145);
        Assert.Equal(145, car.drivingInformationDisplay.ActualSpeed);
    }

    [Fact]
    public void TestBraking()
    {
        var car = new Car();

        car.EngineStart();
        Enumerable.Range(0, 10).ToList().ForEach(s => car.Accelerate(100));

        car.BrakeBy(20);
        Assert.Equal(90, car.drivingInformationDisplay.ActualSpeed);

        car.BrakeBy(10);
        Assert.Equal(80, car.drivingInformationDisplay.ActualSpeed);
    }

    [Fact]
    public void TestConsumptionSpeedUpTo30()
    {
        var car = new Car(1, 20);

        car.EngineStart();

        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);

        Assert.Equal(0.98, car.fuelTankDisplay.FillLevel);
    }
}