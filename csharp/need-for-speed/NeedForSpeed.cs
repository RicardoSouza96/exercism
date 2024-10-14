using System;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed;
    private int batteryDrain;
    private int metersDriven = 0;
    private int battery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => battery > 0 && battery >= batteryDrain ? false : true;

    public int DistanceDriven() => metersDriven;

    public void Drive()
    {
        if(battery > 0 && battery >= batteryDrain)
        {
            this.metersDriven += speed;
            this.battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
            car.Drive();

        if (car.DistanceDriven() >= distance)
            return true;

        return false;
    }
}