using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            ConsoleKeyInfo choice = Console.ReadKey();
            Activity activity;

            if (choice.KeyChar == '1'){
                Console.Clear();
                activity = new BreathingActivity();
                activity.Execute();
            }
            else if (choice.KeyChar == '2'){
                Console.Clear();
                activity = new ReflectionActivity();
                activity.Execute();
            }
            else if (choice.KeyChar == '3'){
                Console.Clear();
                activity = new ListingActivity();
                activity.Execute();
            }
            else if (choice.KeyChar == '4'){
                Environment.Exit(0);
            }
            else{
                Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 4.");
            }
        }
    }
}