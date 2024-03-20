public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CompletedCount { get; set; }

    public override int CalculatePoints()
    {
        return Points + (CompletedCount == TargetCount ? 500 : 0); // Points for a checklist goal
    }

    public override void Display()
    {
        string completedMark = Completed ? "X" : " "; // test completed mark
        Console.WriteLine($"[{completedMark}] {Name}({Description}) -- Completed: {CompletedCount}/{TargetCount}");
        Thread.Sleep(1500); // wait 1.5 sec
    }
}