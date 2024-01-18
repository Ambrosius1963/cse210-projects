using System;

class Program
{
    static void Main(string[] args)
    {
        // Call DisplayWelcome
        DisplayWelcome();

        // Call PromptUserName
        string userName = PromptUserName();

        // Call PromptUserNumber
        int userNumber = PromptUserNumber();

        // Call SquareNumber
        int squaredNumber = SquareNumber(userNumber);

        // Call DisplayResult
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}