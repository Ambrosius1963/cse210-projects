// -------------------------------------------
// |          BreathingActivity               |
// -------------------------------------------
// | + Execute(): override void              |
// -------------------------------------------


public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "\nThis activity will help you relax by walking you through breathing in and out slowly. \nClear your mind and focus on your breathing.\n") { }

    public override void Execute()
    {
        Start();
        bool continueBreathing = true;
        while(continueBreathing){
            DateTime startTime = DateTime.Now;
            while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
            {
                Console.Clear();
                Console.WriteLine("Breathe in");
                DotAnimationIn();

                Console.Clear();
                Console.WriteLine("Breathe out");
                DotAnimationOut();
                
            }
            Console.Write("\nBreath again? (y/n) ");
            ConsoleKeyInfo choice = Console.ReadKey();
            if (choice.KeyChar == 'y'){
                continue;
            }
            else if (choice.KeyChar == 'n'){
                End();
                continueBreathing = false;
            }
            else{
                Console.WriteLine("\nInvalid choice. Please enter y or n.");
            }
        }
        
    }
}