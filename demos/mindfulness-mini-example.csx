using System;
using System.Threading;

// Abstract base class (abstraction)
abstract class MindfulnessGame
{
    protected int gameDuration; // Encapsulated game duration

    public abstract void Play(); // Abstract method

    // Method to display loading animation
    protected virtual void LoadingAnimation(String message = "Loading")
    {
        Console.Clear();
        int elapsed = 0;
        while (elapsed < gameDuration)
        {    
            Console.Write($"{message} \\");
            Thread.Sleep(300);
            Console.Clear();
            Console.Write($"{message} |");
            Thread.Sleep(300);
            Console.Clear();
            Console.Write($"{message} /");
            Thread.Sleep(300);
            Console.Clear();
            Console.Write($"{message} —");
            Thread.Sleep(300);
            Console.Clear();
            elapsed += 1500;
        }
    }
    private void CountdownTimer()
    {
        int timeRemaining = gameDuration / 1000; // Convert milliseconds to seconds
        while (timeRemaining > 0)
        {   
            Console.Clear();
            Console.WriteLine($"Time remaining: {timeRemaining} seconds");
            Thread.Sleep(1000); // Wait for 1 second
            timeRemaining--;
        }
    }
}

// Derived class for Game 1 (inheritance)
class Game1 : MindfulnessGame
{
    public Game1()
    {
        gameDuration = 5000; // Encapsulated game duration
    }

    public override void Play()
    {
        Console.Clear();
        Console.WriteLine("Breathing Game");
        LoadingAnimation("Breathe in... Breathe out..."); // Using base class method
        Console.WriteLine("Breathing Game completed! Press [Enter] to continue.");
        Console.ReadLine();
    }
}

// Derived class for Game 2 (inheritance)
class Game2 : MindfulnessGame
{
    public Game2()
    {
        gameDuration = 8000; // Encapsulated game duration
    }

    public override void Play()
    {
        Console.Clear();
        Console.WriteLine("Reflection Activity");
        LoadingAnimation("Thinking"); // Using base class method
        Console.WriteLine("Reflection Activity completed! Press [Enter] to continue.");
        Console.ReadLine();
    }
}

// Derived class for Game 3 (inheritance)
class Game3 : MindfulnessGame
{
    public Game3()
    {
        gameDuration = 10000; // Encapsulated game duration
    }

    public override void Play()
    {
        Console.Clear();
        Console.WriteLine("Writing Activity");
        CountdownTimer(); // Using countdown timer instead of loading animation
        Console.Clear();
        Console.WriteLine("Writing Activity completed! Press [Enter] to continue.");
        Console.ReadLine();
    }

    
}

/*
We cannot call this Main() or Main(string[] args) because it will conflict with the Main method
VS Code and the C# compiler expects to see in a standard C# program.
*/
static void MainScript()
{
    bool quit = false;
    while (!quit)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Mindfulness Games!");
        Console.WriteLine("Please select a game:");
        Console.WriteLine("1. Breathing Game");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Writing Activity");
        Console.WriteLine("4. Quit");

        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Game1 game1 = new Game1();
                game1.Play();
                break;
            case "2":
                Game2 game2 = new Game2();
                game2.Play();
                break;
            case "3":
                Game3 game3 = new Game3();
                game3.Play();
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("Thank you for playing, goodbye!");
                Thread.Sleep(2000); // Wait for 2 seconds
                Console.Clear();
                quit = true;
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                Console.ReadLine();
                break;
        }
    }
}

MainScript();