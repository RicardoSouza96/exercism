using System;


//Updating the branch name

class RemoteControlCar
{
    private int meters = 0;
    private int battery = 100;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {meters} meters";

    public string BatteryDisplay()
    {
        if (battery == 0)
            return $"Battery empty";

        return $"Battery at {battery}%";
    }

    public void Drive()
    {
        if (battery == 0)
            BatteryDisplay();
        else
        {
            meters += 20;
            battery -= 1;
        }
    }
}
