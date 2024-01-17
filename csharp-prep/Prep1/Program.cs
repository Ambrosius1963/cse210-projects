using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your first name? ");
        string firstname = Console.readLine();
        Console.Write("What's your last name? ");
        string lastname = Console.readLine();
        Console.WriteLine($"\nHello {lastname}, {fistname} {lastname}.");
    }
}