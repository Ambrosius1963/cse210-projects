public class HeatOven : SmartDevice
{
    int _targetTemperature = 0; // Default temperature

    public HeatOven() : base("Oven") { }

    public override void Execute()
    {
        TurnDeviceOn();
        Display();

        // Get user input for temperature
        while (_targetTemperature == 0)
        {
            Console.Write("Enter desired temperature (Fahrenheit): ");
            try
            {
                _targetTemperature = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        Console.WriteLine($"Setting oven to {_targetTemperature}ºF.");
        Thread.Sleep(500); 
        Console.WriteLine("\nHeating oven...");
        Thread.Sleep(2000); // Simulating oven heating process
        Console.WriteLine("Oven is ready!");
        Thread.Sleep(2000); // pause for reading


    }
}
