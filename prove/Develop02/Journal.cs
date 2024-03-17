using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    public PromptGenerator _promptGenerator;

    public Journal()
    {
        _entries = new List<Entry>();
        _promptGenerator = new PromptGenerator();
    }

    public void Add(Entry newEntry)
    {
        string prompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine("Please enter the date (mm/dd/yyyy): ");
        string date = Console.ReadLine();
        Console.WriteLine($"Please enter todays prompt: {prompt} ");
        Entry entry = new Entry(date, prompt);
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date}\n{entry._entryText}");
                }
            }
            Console.WriteLine($"File saved as: {fileName}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving to {fileName}: {e.Message}");
        }
    }

    public void LoadFromFile(string fileName)
    {
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string date = reader.ReadLine();
                    Entry entry = new Entry(date, prompt);
                    _entries.Add(entry);
                }
            }
            Console.WriteLine($"File loaded from: {fileName}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error while reading entries from {fileName}: {e.Message}");
        }
    }
}