
// -------------------------------------------
// |         ReflectionActivity              |
// -------------------------------------------
// | - prompts: string[]                    |
// | - questions: string[]                  |
// -------------------------------------------
// | + Execute(): override void             |
// -------------------------------------------


public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    public override void Execute()
    {
        Start();
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];
        Console.WriteLine(prompt);
        foreach (string question in questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(3000); // Pause for 3 seconds
            // Display spinner while paused
            Console.Write("\b|");
            Thread.Sleep(500);
            Console.Write("\b/");
            Thread.Sleep(500);
            Console.Write("\b-");
            Thread.Sleep(500);
            Console.Write("\b\\");
            Thread.Sleep(500);
            Console.Write("\b");
        }
        End();
    }
}