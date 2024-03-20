
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }
    public int Points { get; set; }

    
    public Goal(){ }

    public abstract int CalculatePoints();
    public abstract void Display();

    public static void SaveGoalsToFile(List<Goal> goals, string filename)
    {
        var options = new JsonSerializerOptions { WriteIndented = true }; // indents the data on the json file
        var serializedGoals = JsonSerializer.Serialize(goals, options); 
        File.WriteAllText(filename, serializedGoals);
    }

    public static List<Goal> LoadGoalsFromFile(string filename)
    {
        // read the json string from file
        string serializedGoals = File.ReadAllText(filename);
        // return JsonSerializer.Deserialize<List<Goal>>(serializedGoals);
        try
        {
            List<Goal> deserializedGoals = JsonSerializer.Deserialize<List<Goal>>(serializedGoals);
            return deserializedGoals;
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error deserializing JSON: {ex.Message}");
            // Handle the error or return a default value
            return new List<Goal>();
        }
    }

    public static SimpleGoal CreateSimpleGoal()
    {
        Console.Clear();
        Console.Write("Enter the name of the simple goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description of the simple goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for the simple goal: ");
        int points = int.Parse(Console.ReadLine());
        return new SimpleGoal { Name = name, Description = description, Points = points };
    }

    public static EternalGoal CreateEternalGoal()
    {
        Console.Clear();
        Console.Write("Enter the name of the eternal goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description of the eternal goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for the eternal goal: ");
        int points = int.Parse(Console.ReadLine());
        return new EternalGoal { Name = name, Description = description, Points = points };
    }

    public static ChecklistGoal CreateChecklistGoal()
    {
        Console.Clear();
        Console.Write("Enter the name of the checklist goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description of the checklist goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for the checklist goal: ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("Enter the target count for the checklist goal: ");
        int targetCount = int.Parse(Console.ReadLine());
        return new ChecklistGoal { Name = name, Description = description, Points = points, TargetCount = targetCount };
    }
    
    public static void ModifyGoal(List<Goal> goals)
    {
        Console.Clear();
        Console.WriteLine("Select a goal to modify:");

        // Display goal details with numbering (1. Goal 1, 2. Goal 2, ...)
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        string choice = Console.ReadLine();
        int index;

        // Check if input is a valid number within goal count
        if (int.TryParse(choice, out index) && index > 0 && index <= goals.Count)
        {
            index--; // Adjust for zero-based indexing

            Console.Clear();
            Console.WriteLine($"Modifying goal: {goals[index].Name}\n");
            Console.WriteLine("Choose what to modify:");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Description");
            Console.WriteLine("3. Points");
            Console.WriteLine("4. Target Count (for ChecklistGoal only)"); // Optional for specific goal types

            string modifyChoice = Console.ReadLine();

            switch (modifyChoice)
            {
                case "1":
                    Console.Write("Enter the new name:");
                    goals[index].Name = Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Enter the new description:");
                    goals[index].Description = Console.ReadLine();
                    break;
                case "3":
                    Console.Write("Enter the new points:");
                    goals[index].Points = int.Parse(Console.ReadLine());
                    break;
                case "4":
                    if (goals[index] is ChecklistGoal checklistGoal) // Check if goal is ChecklistGoal
                    {
                        Console.Write("Enter the new target count:");
                        checklistGoal.TargetCount = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Target count modification is only available for Checklist Goals.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("Goal modified and saved successfully!");
            Program.SaveGoals(goals); // Save modified goals to file
            Thread.Sleep(1500);
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
}
