using System;
using System.IO;
using System.Runtime.CompilerServices;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int battery;
    private int distance;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.battery = 100;
        this.distance = 0;

    }


    public bool BatteryDrained()
    {
        return battery-batteryDrain < 0;
    }

    public int DistanceDriven()
    {
        return this.distance;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            this.battery -= batteryDrain;
            this.distance += speed;
        }
    }

    public static RemoteControlCar Nitro()
    {
        var nitroCar = new RemoteControlCar(50, 4);
        return nitroCar;
    }
}

class RaceTrack
{
    private int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        bool isFinished = false;
        while (!car.BatteryDrained())
        {
            car.Drive();
            if (car.DistanceDriven() >=  this.distance)
            {
                isFinished = true;
            }
        }
        return isFinished;
    }
}
