// -------------------------------------------
// |          ListingActivity                |
// -------------------------------------------
// | - prompts: string[]                    |
// -------------------------------------------
// | + Execute(): override void             |
// -------------------------------------------




public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void Execute()
    {
        Start();
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have 10 seconds, start listing...");
        Thread.Sleep(10000); // Pause for 10 seconds
        Console.WriteLine("Time's up!");
        End();
    }
}