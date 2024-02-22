// -------------------------------------------
// |          BreathingActivity               |
// -------------------------------------------
// | + Execute(): override void              |
// -------------------------------------------


public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void Execute()
    {
        Start();
        int count = 0;
        while (count < duration)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(5000); // Pause for 5 seconds
            Console.WriteLine("Breathe out...");
            Thread.Sleep(5000); // Pause for 5 seconds
            count += 4;
        }
        End();
    }
}