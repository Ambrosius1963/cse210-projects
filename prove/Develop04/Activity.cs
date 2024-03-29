// ------------------------------------
// |            Activity              |
// ------------------------------------
// | - name: string                   |
// | - description: string            |
// | - duration: int                  |
// | - DotCount: int                  |
// | - Interval: double               |
// ------------------------------------
// | + Activity(name: string,         |
// |            description: string)  |
// | + Start(): void                  |
// | - SetDuration(): void            |
// | + DotAnimationIn(): void         |
// | + DotAnimationOut(): void        |
// | + CountdownTimer(): void         |
// | + End(): void                    |
// | + Execute(): abstract void       |
// ------------------------------------


// Base class for all activities
public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;
    private const int DotCount = 25; // Adjust this for more or less dots


    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    // Common starting message for all activities
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {name}:\n----------------------------- {description}");
        SetDuration();
        Thread.Sleep(300); // Pause for .3 seconds
    }

    // Set the duration of the activity
    private void SetDuration()
    {
        Console.Write("Enter duration (in seconds): ");
        duration = Convert.ToInt32(Console.ReadLine());
    }

    public void DotAnimationIn()
    {
        // Print dots for 5 seconds
        for (int i = 0; i < DotCount; i++)
        {
            Console.Write(".");
            Thread.Sleep(150); // Pause for .15 seconds between each dot

        }
    }
    public void DotAnimationOut(){
        // Remove dots one by one
        Console.Write('\r');
        Console.Write(new string('.', DotCount));
        for (int i = DotCount - 1; i >= 0; i--)
        {
            Console.Write("\b\b"); // Back space twice
            Console.Write(" "); // Overwrite the dot with a space
            Thread.Sleep(150); // Pause for .15 seconds between each dot

        }

    }
    public void CountdownTimer()
    {
        int timeRemaining = duration; // 1000; // Convert milliseconds to seconds
        while (timeRemaining >= 0)
        {   
            string seconds = timeRemaining == 1 ? "second" : "seconds";
            Console.Write($"\rTime remaining: {timeRemaining} {seconds} ");
            Thread.Sleep(1000); // Wait for 1 second
            timeRemaining--;
        }
        Console.WriteLine("\nTime's up!");
    }
    // Common ending message for all activities
    public void End()
    {
        Console.WriteLine("\nGreat job!");
        Console.WriteLine($"You completed {name} for {duration} seconds.");
        Thread.Sleep(1500); // Pause for 1.5 seconds
    }
    // Abstract method for activity execution
    public abstract void Execute();
}