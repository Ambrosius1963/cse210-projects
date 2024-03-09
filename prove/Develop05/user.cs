using System;
using System.Collections.Generic;
using System.IO;

public class User
{
    private string username;
    private List<Goal> goals;
    private int score;

    public User(string username)
    {
        this.username = username;
        this.goals = new List<Goal>();
        this.score = 0;
    }

    public void CreateGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        goal.Complete();
        score += goal.CalculatePoints();
    }

    public void DisplayScore()
    {
        Console.WriteLine("User: " + username);
        Console.WriteLine("Score: " + score);
    }

    public void SaveGoalsToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.Name + "," + goal.Points + "," + goal.Completed);
            }
        }
    }

    public void LoadGoalsFromFile(string filename)
    {
        goals.Clear(); // Clear existing goals before loading from file
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                int points = int.Parse(parts[1]);
                bool completed = bool.Parse(parts[2]);
                // Decide which type of goal to create based on the name, points, and completion status
                // Add the goal to the list
            }
        }
    }
}
