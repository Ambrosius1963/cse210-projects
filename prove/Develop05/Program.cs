using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    const string fileName = "goals.json";
    public static List<Goal> goals = new List<Goal>();
    public static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine(" | Goal Tracker 2000 | \n ---------------------");

            // Console.WriteLine($"\nTotal Points: {points}");
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine(" 1. Add a new goal");
            Console.WriteLine(" 2. Display goals");
            Console.WriteLine(" 3. Save goals to file");
            Console.WriteLine(" 4. Load goals from file");
            Console.WriteLine(" 5. Record event");
            Console.WriteLine(" 6. Modify a goal");
            Console.WriteLine(" 7. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewGoal(goals);
                    break;
                case "2":
                    DisplayGoals(goals);
                    break;
                case "3":
                    SaveGoals(goals);
                    break;
                case "4":
                    LoadGoals(goals);
                    break;
                case "5":
                    RecordEvent(goals);
                    break;
                case "6":
                    Goal.ModifyGoal(goals);
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayGoals(List<Goal> goals)
    {
        Console.Clear();
        Console.WriteLine("\nGoals:");
        foreach (var goal in goals)
        {
            goal.Display();
        }
        Thread.Sleep(1500); // wait 1.5 sec

    }


    public static void SaveGoals(List<Goal> goals)
    {
        Goal.SaveGoalsToFile(goals, fileName);
        Console.WriteLine("Goals saved to file.");
        Thread.Sleep(1500);
    }

    static void LoadGoals(List<Goal> goals)
    {
        goals = Goal.LoadGoalsFromFile(fileName);
        Console.WriteLine("Goals loaded from file.");
        Thread.Sleep(1500);
    }

    static void AddNewGoal(List<Goal> goals)
    {
        Console.Clear();
        Console.WriteLine("\nChoose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                goals.Add(Goal.CreateSimpleGoal());
                SaveGoals(goals); // Save goal to file
                break;
            case "2":
                goals.Add(Goal.CreateEternalGoal());
                SaveGoals(goals); // Save goal to file
                break;
            case "3":
                goals.Add(Goal.CreateChecklistGoal());
                SaveGoals(goals); // Save goal to file
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
    

    static void RecordEvent(List<Goal> goals)
    {
        Console.Clear();
        Console.WriteLine("Which goal did you completed!?");

        // Display goal list with numbering
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        string choice = Console.ReadLine();
        int index;

        // Check if input is a valid number within goal count
        if (int.TryParse(choice, out index) && index > 0 && index <= goals.Count)
        {
            index--; 

            Goal goal = goals[index];

            if (goal is SimpleGoal simpleGoal)
            {
                simpleGoal.Completed = true; // Mark as completed
                Console.WriteLine($"Look at you go! Be proud of completing your goal to {simpleGoal.Name}!");
            }
            else if (goal is EternalGoal eternalGoal)
            {
                Console.WriteLine("Congratulations! You are one step closer to eternity!");
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                checklistGoal.CompletedCount++; // Increment completion count
                Console.WriteLine($"You completed {checklistGoal.Name} {checklistGoal.CompletedCount} times!");

                if (checklistGoal.CompletedCount == checklistGoal.TargetCount)
                {
                    Console.WriteLine($"Yay! You've fully completed {checklistGoal.Name}!");
                }
            }
            else
            {
                Console.WriteLine("Whachu tryin' tuh do!?!");
            }

            SaveGoals(goals); // Save modified goals to file
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }


    

}
