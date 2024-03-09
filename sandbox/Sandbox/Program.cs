using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n~`~`~`~`~ MyHome ~`~`~`~`~\n__________________________\n");
            Console.WriteLine("Select your Mode:");
            Console.WriteLine("1. Heat oven");
            Console.WriteLine("2. I'm coming home");
            Console.WriteLine("3. Good night");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            ConsoleKeyInfo choice = Console.ReadKey();
            SmartDevice device;

            if (choice.KeyChar == '1'){
                Console.Clear();
                device = new HeatOven();
                device.Execute();
            }
            else if (choice.KeyChar == '2'){
                Console.Clear();
                device = new ImHome();
                device.Execute();
            }
            else if (choice.KeyChar == '3'){
                Console.Clear();
                device = new GoodNight();
                device.Execute();
            }
            else if (choice.KeyChar == '4'){
                Console.Clear();
                Console.Write("Thanks for using MyHome!");
                Thread.Sleep(1500); // wait 1.5 sec
                Console.Clear();
                Environment.Exit(0);
            }
            else{
                Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 4.");
            }
        }
    }
}



