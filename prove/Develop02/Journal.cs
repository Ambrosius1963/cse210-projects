using System;
using System.Collections.Generic;
using System.IO;

public class Journal {

    private List<Entry> entries = new List<Entry>();

    public void AddEntry()
    {
        Entry newEntry = new Entry();

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
            Console.WriteLine($"{entry.Date.ToString("MM/dd/yyyy hh:mm")} ~ {entry.Thoughts}");
        }
    }

    public void SaveToFile()
    /*~~~~~~~~~~~~~~~~~~~~~~~~~ BIG PROBLEM!!!!!~~~~~~~~~~~~~~~~~~~~~~~~~~
    When I save new entries to the txt file it replaces everything on the file*/
    {
        // Use the Entry class to ask the user for a file
        Console.Write("Enter the file name to save entries: ");
        string fileName = Console.ReadLine();

        // Save the written Thoughts, answers, and date from the list made in AddEntry to the user's designated file
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date.ToString("MM/dd/yyyy hh:mm")} ~ {entry.Thoughts}");
            }
        }
    }

    public void LoadFile()
    /*~~~~~~~~~~~~~~~~~~~~~~~~~ MEDIUM PROBLEM~~~~~~~~~~~~~~~~~~~~~~~~~~
    When I Try to load the txt file, None of the entries (I also have no idea what this code does...)*/
    {
        // Use the Entry class to open the journal txt file and read the entries into a list
        Console.Write("Enter the file name to load entries: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            entries.Clear(); // Clear existing entries

            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    // Assuming the format is "MM/dd/yyyy hh:mm ~ Thoughts"
                    string[] parts = line.Split(new char[] { '~' }, 2, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length == 2 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        Entry loadedEntry = new Entry
                        {
                            Date = date,
                            Thoughts = parts[1].Trim()
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