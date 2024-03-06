public abstract class SmartDevice
{

    string _name = "";
    bool _powerOn = false;


    public SmartDevice(string name)
    {
        _name = name;
    }

    public bool DeviceIsOn()
    {
        return _powerOn;
    }

    public string Display()
    {
        return $"{_name}: {_powerOn}";
    }
    public abstract void Execute();

    public void TurnDeviceOn()
    {
        _powerOn = true;
        
    }

    public void TurnDeviceOff()
    {
        _powerOn = false;

    }


}