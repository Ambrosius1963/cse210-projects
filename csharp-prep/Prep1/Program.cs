using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your first name? ");
        string firstname = Console.ReadLine();
        Console.Write("What's your last name? ");
        string lastname = Console.ReadLine();
        Console.WriteLine($"\nHello {lastname}, {firstname} {lastname}.");
    }
}