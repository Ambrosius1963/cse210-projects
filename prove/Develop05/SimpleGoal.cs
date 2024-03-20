public class SimpleGoal : Goal
{
    public override int CalculatePoints()
    {
        // write code that will return the points if the goal is completed
        return Points; 
    }

    public override void Display()
    {
        string completedMark = Completed ? "X" : " "; // test completed mark
        Console.WriteLine($"[{completedMark}] {Name}({Description})");
        Thread.Sleep(1500); // wait 1.5 sec
    }
}