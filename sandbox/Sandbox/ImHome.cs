public class ImHome : SmartDevice
{
    public ImHome() : base("Welcome Home") { }

    public override void Execute()
    {
        TurnDeviceOn();
        Display();

        Console.WriteLine("\nOpening garage door...");
        Thread.Sleep(1000); // Simulate opening time
        Console.WriteLine("Garage door open!");
        Thread.Sleep(1000); // pause for reading

        Console.WriteLine("\nSetting temperature to 70 degrees F...");
        Thread.Sleep(500); // Simulate temperature adjustment time
        Console.WriteLine("Temperature set!");
        Thread.Sleep(1000); // pause for reading

        Console.WriteLine("\nWelcome home!");
        Thread.Sleep(2000); // pause for reading

    }
}
