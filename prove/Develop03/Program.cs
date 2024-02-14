using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Scripture Memorizer!\n");
        Console.WriteLine("Menu:");
        Console.WriteLine("1) Memorize");
        Console.WriteLine("2) Flash cards");
        Console.Write("Choose your choice (1-2) ~ ");
        string choice = Console.ReadLine();

        switch (choice)
            {
                case "1":
                    MemorizeScripture();
                    break;
                case "2":
                    // flash card option
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 2.\n");
                    break;
            }

    }
    static void MemorizeScripture()
    {
        Console.WriteLine("Memorization Mode\n");
        // Create an instance of ScriptureGen to get a random scripture
        ScriptureGen scriptureGen = new ScriptureGen();
        string randomScripture = scriptureGen.GetRandomScripture();
        Console.WriteLine("Scripture to Memorize:\n" + randomScripture);

    }
    static void UseFlashCards()
    {
        Console.WriteLine("Flash Cards Mode\n");

        ScriptureGen scriptureGen = new ScriptureGen();

        string randomScripture = scriptureGen.GetRandomScripture();
        Console.WriteLine(randomScripture);

        // Create a Scripture object to work with the text and words
        List<Word> words = new List<Word>();

    }
}