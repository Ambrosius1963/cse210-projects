using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // Get input from the user
        Console.WriteLine("Enter a series of numbers. Enter 0 to stop.");
        int userInput;
        do
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                numbers.Add(userInput);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (userInput != 0);

        // Core Requirements
        if (numbers.Count > 0)
        {
            // Compute the sum
            int sum = numbers.Sum();
            Console.WriteLine($"Sum of the numbers: {sum}");

            // Compute the average
            double average = numbers.Average();
            Console.WriteLine($"Average of the numbers: {average}");

            // Find the maximum
            int max = numbers.Max();
            Console.WriteLine($"Maximum number in the list: {max}");

            // Find the Minimum
            int min = numbers.Min();
            Console.WriteLine($"Minimum number in the list: {min}");
        }
        else
        {
            Console.WriteLine("No numbers entered.");
        }
    }
}
