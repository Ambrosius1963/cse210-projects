using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the number game!\n ~~~~~~~~~~~~~~~~~~~~~~~");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guessInput = 10000;
        int Count = 0;

        while (guessInput != number)
        {
            Count += 1;
            Console.Write("What's your Guess? ");
            guessInput = int.Parse(Console.ReadLine());

            if (guessInput > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guessInput < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guessInput == number)
            {
                Console.WriteLine($"\nYou Guessed it! The number was {number}");
                Console.WriteLine($"It took you {Count} guesses.\n");
            }
            else
            {
                Console.WriteLine("Sorry. That is not a valid guess.");
            }
        }
    }
}