public class HeatOven : SmartDevice
// Pre heat oven to temperature specified by the user.
{
    
   public HeatOven() : base("Oven") { }

    public override void Execute()
    {
        Console.WriteLine("Heating oven...");
        TurnDeviceOn();
        Thread.Sleep(2000); // Simulating oven heating process
        Console.WriteLine("Oven is ready!");
    }
}