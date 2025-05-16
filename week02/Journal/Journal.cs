// Journal.cs - Handles journal entries and file operations
using System;
// using System.Collections.Generic;
// using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        // I added more prompts for variety
        "What made you smile today?",
        "What lesson did you learn today?"
    };

    public void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)]; //This gives you a single prompt randomly from my list of prompts 
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("MM/dd/yyyy");

        entries.Add(new Entry(prompt, response, date));
        Console.WriteLine("Entry added!");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine($"\nDate: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
        }
    }

    public void SaveJournal()
    {
        Console.Write("Enter filename to save (without extension): ");
        string filename = Console.ReadLine();

        // EXCEEDED REQUIREMENT: Added JSON serialization option
        // Because: It provides more structured data storage than plain text
        // and handles special characters automatically
        string json = JsonSerializer.Serialize(entries);
        File.WriteAllText($"{filename}.json", json);
        Console.WriteLine("Journal saved as JSON!");
    }

    public void LoadJournal()
    {
        Console.Write("Enter filename to load (without extension): ");
        string filename = Console.ReadLine();

        try
        {
            // EXCEEDED REQUIREMENT: Added JSON deserialization
            // Why: Matches the JSON save format and properly rebuilds objects
            string json = File.ReadAllText($"{filename}.json");
            entries = JsonSerializer.Deserialize<List<Entry>>(json);
            Console.WriteLine("Journal loaded from JSON!");
        }
        catch (Exception)
        {
            Console.WriteLine("File not found or invalid format.");
        }
    }
}