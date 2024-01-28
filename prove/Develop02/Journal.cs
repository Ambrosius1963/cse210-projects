using System;
using System.Collections.Generic;
using System.IO;

public class Journal {

    private List<Entry> entries = new List<Entry>();
    private PromptGen promptGen = new PromptGen();
    public void AddEntry()
    {
        Entry newEntry = new Entry();

        // Display a random prompt from PromptGen
        newEntry.Prompt = promptGen.GetRandomPrompt();
        Console.WriteLine($"Prompt: {newEntry.Prompt}");

        // Use the Entry class to grab a Thoughts and the date
        Console.Write("Enter Your Thoughts: ");
        newEntry.Thoughts = Console.ReadLine();
        newEntry.Date = DateTime.Now;

        // Save the information into a local list
        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        // Use the Entry class to display all the entries with the corresponding date and Thoughts
        foreach (var entry in entries)
        {
            // take each entry and then run it through the method in the Entry Class
            entry.DisplayEntry();
            Console.WriteLine("");
            //Console.WriteLine($"{entry.Date.ToString("MM/dd/yyyy hh:mm")} ~ {entry.Prompt}\n{entry.Thoughts}");
        }
    }

    public void SaveToFile()
    {
        // Ask for a file from the user
        Console.Write("Enter the file name to save entries: ");
        string fileName = Console.ReadLine();

        // Save the written Thoughts, Prompts, and date from the list made in AddEntry to the user's designated file
        using (StreamWriter writer = new StreamWriter(fileName, true)) // Set 'true' to append
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date.ToString("MM/dd/yyyy hh:mm")} ~ Prompt:{entry.Prompt} ~ Thoughts:{entry.Thoughts}");
            }
        }
    }


    public void LoadFile()
    /*This LoadFile code was touched up by AI*/
    {
        // Use the Entry class to open the journal txt file and read the entries into a list
        Console.Write("Enter the file name to load entries: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            entries.Clear(); // Clear existing entries in saved list

            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    // Assuming the format is "MM/dd/yyyy hh:mm ~ Thoughts"
                    string[] parts = line.Split(new string[] { "~" }, 3, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        Entry loadedEntry = new Entry
                        {
                            Date = date,
                            Prompt = parts[1].Trim().Replace("Prompt:", ""),
                            Thoughts = parts[2].Trim().Replace("Thoughts:", "")
                        };
                        entries.Add(loadedEntry);
                    }
                }
            }

            Console.WriteLine("Entries loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found. No entries loaded.");
        }
    }


}