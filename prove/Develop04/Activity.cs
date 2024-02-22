// ------------------------------------
// |            Activity              |
// ------------------------------------
// | - name: string                   |
// | - description: string            |
// | - duration: int                  |
// ------------------------------------
// | + Activity(name: string,        |
// |            description: string) |
// | + Start(): void                  |
// | + SetDuration(): void            |
// | + End(): void                    |
// | + Execute(): abstract void       |
// ------------------------------------


// Base class for all activities
public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    // Common starting message for all activities
    public void Start()
    {
        Console.WriteLine($"Starting {name}: {description}");
        SetDuration();
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    // Set the duration of the activity
    private void SetDuration()
    {
        Console.Write("Enter duration (in seconds): ");
        duration = Convert.ToInt32(Console.ReadLine());
    }

    // Common ending message for all activities
    public void End()
    {
        Console.WriteLine("Great job!");
        Console.WriteLine($"You completed {name} for {duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    // Abstract method for activity execution
    public abstract void Execute();
}