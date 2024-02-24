// -------------------------------------------
// |          BreathingActivity               |
// -------------------------------------------
// | + Execute(): override void              |
// -------------------------------------------


using System.Xml.Serialization;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "\n  This activity will help you relax by walking you through breathing in and out slowly. \n  Clear your mind and focus on your breathing.") { }

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
                // Thread.Sleep(5000); // Pause for 5 seconds
                Console.Clear();
                Console.WriteLine("Breathe out");
                DotAnimationOut();
                // Thread.Sleep(5000); // Pause for 5 seconds
                
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