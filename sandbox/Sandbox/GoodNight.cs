
public class GoodNight : SmartDevice
{
    public GoodNight() : base("Good Night") { }

    public override void Execute()
    {
        TurnDeviceOff();

        Console.WriteLine("Turning off lights...");
        Thread.Sleep(500); // Simulate turning off lights time
        Console.WriteLine("Lights off!");

        Console.WriteLine("Locking all doors...");
        Thread.Sleep(1000); // Simulate locking doors time
        Console.WriteLine("Doors locked!");

        Console.WriteLine("Setting temperature to 60ºF...");
        Thread.Sleep(500); // Simulate temperature adjustment time
        Console.WriteLine("Temperature set!");

        Console.WriteLine("\nGood night! Sleep tight.");
    }
}
