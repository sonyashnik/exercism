using System;

class RemoteControlCar
{
    int _drivenDistance = 0;
    int _savingBattery = 100;
    public static RemoteControlCar Buy()
    {
        var myCar = new RemoteControlCar();
        return myCar;
    }

    public string DistanceDisplay()
    {
        return $"Driven {_drivenDistance} meters";
    }

    public string BatteryDisplay()
    {
        switch (_savingBattery)
        {
            case > 0:
                return $"Battery at {_savingBattery}%";
            default:
                return "Battery empty";
        }
    }

    public void Drive()
    {
        if (_savingBattery > 0) 
        {

            _drivenDistance += 20;
            _savingBattery -= 1;
        }
    }
}
