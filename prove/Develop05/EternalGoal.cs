public class EternalGoal : Goal
{
    public override int CalculatePoints()
    {
        // write code that will return the points if the goal is completed
        return Points; 
    }

    public override void Display()
    {
        // this goal is eternal, so no need to update the completion 
        Console.WriteLine($"[∞] {Name}({Description})");
        Thread.Sleep(1500); // wait 1.5 sec
    }
}