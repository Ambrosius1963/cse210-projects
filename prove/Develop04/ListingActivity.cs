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

    public ListingActivity() : base("Listing Activity", "\nThis activity will help you reflect on the good things in your \nlife by having you list as many things as you can in a certain area.\n") { }

    public override void Execute()
    {
        Start();
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];

        bool continueListing = true;
        while(continueListing){
            Console.WriteLine(prompt);
            DateTime startTime = DateTime.Now;

            while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
            {
                DotAnimationIn();
                DotAnimationOut();
            }
            // Thread.Sleep(duration); // Pause for their set time
            Console.Write("\rTime's up!");
            
            Console.Write("\nContinue Listing? (y/n) ");
            ConsoleKeyInfo choice = Console.ReadKey();
            if (choice.KeyChar == 'y'){
                Console.Clear();
                continue;
            }
            else if (choice.KeyChar == 'n'){
                End();
                continueListing = false;
            }
            else{
                Console.WriteLine("\nInvalid choice. Please enter y or n.");
            }
        }
    }
}