public class ImHome : SmartDevice
// Open the Garage, and set temperature to 70 degrees F
{
    public ImHome() : base("Welcome Home") { }

    public override void Execute()
    {
        Console.WriteLine("Welcome home!");
        TurnDeviceOn();
    }
    
}