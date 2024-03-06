

public class GoodNight : SmartDevice
// Class will turn off all the lights, lock all the doors, and turn down the temperature to 60 degrees F
{
    public GoodNight() : base("Good Night") { }

    public override void Execute()
    {
        Console.WriteLine("Good night! Sleep tight.");
        TurnDeviceOff();
    }
}