
public class GoodNight : SmartDevice
{
    public GoodNight() : base("Good Night") { }

    public override void Execute()
    {
        TurnDeviceOff();
        Display();

        Console.WriteLine("\nTurning off lights...");
        Thread.Sleep(500); // Simulate turning off lights time
        Console.WriteLine("Lights off!");
        Thread.Sleep(1000); // pause for reading

        Console.WriteLine("\nLocking all doors...");
        Thread.Sleep(1000); // Simulate locking doors time
        Console.WriteLine("Doors locked!");
        Thread.Sleep(1000); // pause for reading

        Console.WriteLine("\nSetting temperature to 60ºF...");
        Thread.Sleep(500); // Simulate temperature adjustment time
        Console.WriteLine("Temperature set!");
        Thread.Sleep(1000); // pause for reading

        Console.WriteLine("\nGood night! Sleep tight.");
        Thread.Sleep(2000); // pause for reading

    }
}
