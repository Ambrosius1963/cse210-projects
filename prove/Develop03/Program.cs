using System;

class Program
{
    public static bool Memorizing { get; private set; }

    static void Main(string[] args)
    {
        bool EndMemorizing = false;
        while (!EndMemorizing){
            Console.Clear(); // Clear the console
            Console.WriteLine("\nWelcome to the Scripture Memorizer!\n");
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Memorize");
            Console.WriteLine("2) Flash cards");
            Console.WriteLine("3) quit");
            Console.Write("Choose your choice (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
                {
                    case "1":
                        MemorizeScripture();
                        break;
                    case "2":
                        // flash card option
                        UseFlashCards();
                        break;
                    case "3":
                        EndMemorizing = true;
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
            string randomScriptureText = scriptureGen.GetRandomScripture();
            Scripture scripture = new Scripture(randomScriptureText);
            

            Console.WriteLine("Scripture:\n" + scripture);
            while(true){
                Console.Write("\nPress 'h' to hide 3 words and 'q' to quit: ");
                // Read a single key from the console input
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // Check if the key pressed is 'h'
                if (keyInfo.KeyChar == 'h'){
                    // Hide 3 words (implementation here)
                    scripture.HideWords();
                    Console.WriteLine("\n\n" + scripture + '\n');
                    // Check if all words are hidden
                    if (scripture.AllWordsHidden())
                    {
                        Console.WriteLine("\nAll words are hidden.");
                        return;
                    }
                }
                // Check if the key pressed is 'q'
                else if (keyInfo.KeyChar == 'q'){

                    return; // Exit the program
                }
                else{
                    // Handle invalid input
                    Console.WriteLine("\nunknown input.");
                }
            }
        }

        static void UseFlashCards()
        {
            Console.WriteLine("Flash Card Mode");
            ScriptureGen scriptureGen = new ScriptureGen();
            Reference reference = new Reference("");

        while (true)
            {
                Console.Write("\nPress 'enter' for next card, or 'q' to quit. ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter){
                    Console.Clear(); // Clear the console for the next scripture
                    // Generate a random scripture
                    string randomScriptureText = scriptureGen.GetRandomScripture();

                    // Print the scripture text
                    reference.PrintVerse(randomScriptureText);

                    // Prompt user to press Enter to reveal reference
                    Console.Write("\nPress 'f' to FLIP");
                    ConsoleKeyInfo innerKey = Console.ReadKey();

                    // Check if the key pressed is 'f'
                    if (innerKey.KeyChar == 'f'){
                        // Clear the console and then re-print verse
                        Console.Clear(); 
                        reference.PrintVerse(randomScriptureText);
                        // Print the scripture reference
                        reference.PrintReference(randomScriptureText);
                    }
                    else{
                        Console.WriteLine("whoops!\n");
                    }
                }
                // q to quit?
                else if (keyInfo.KeyChar == 'q'){
                    return; // Exit the program
                }
                else{
                    // Handle invalid input
                    Console.WriteLine("\nunknown input.");
                }

            }
        }
    }
}