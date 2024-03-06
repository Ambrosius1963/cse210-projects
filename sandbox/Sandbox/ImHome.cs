public class ImHome : SmartDevice
{
    public ImHome() : base("Welcome Home") { }

    public override void Execute()
    {
        Console.WriteLine("Welcome home!");
        TurnDeviceOn();

        Console.WriteLine("Opening garage door...");
        Thread.Sleep(1000); // Simulate opening time
        Console.WriteLine("Garage door open!");

        Console.WriteLine("Setting temperature to 70 degrees F...");
        Thread.Sleep(500); // Simulate temperature adjustment time
        Console.WriteLine("Temperature set!");
    }
}
