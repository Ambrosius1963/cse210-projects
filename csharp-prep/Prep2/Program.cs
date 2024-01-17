using System;

class Program
{
    static void Main(string[] args)
    {
        // Core Requirements
        Console.WriteLine("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge
        int lastDigit = gradePercentage % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handle exceptional cases for A+ and F+/- grades
        if (letter == "A" && sign == "+")
        {
            letter = "A";
            sign = "";
        }
        else if (letter == "F" && (sign == "+" || sign == "-"))
        {
            letter = "F";
            sign = "";
        }

        // Display the final grade with sign
        Console.WriteLine($"Your final grade is: {letter}{sign}");

        // Check if passed and congratulate or encourage
        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed miserably. Better luck next time!");
        }
    }
}