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
        string entryText = Console.ReadLine();

        Entry entry = new Entry(date, entryText);
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string file)
    {
        Console.Write("Please enter the name of the file to save to: ");
        string file = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date}\n{entry._entryText}");
                }
            }
            Console.WriteLine($"File saved as: {file}");
        } 
        catch (Exception e)
        {
            Console.WriteLine($"Error saving to {file}: {e.Message}");
        }
       
    }

    public void LoadFromFile(string file)
    {
        Console.Write("Please enter the file name you would like to open from: ");
        string file = Console.ReadLine();
        try{
            using ( StreamWriter reader = new StreamWriter(file))
            {
                while (!reader.EndOfStream)
                {
                    string _date = reader.ReadLine();
                    string _entryText = reader.ReadLine();
                    Entry entry = new Entry (_date, _entryText);
                    entries.Add(entry);
                }

            }
            Console.WriteLine($"File loaded from: {file}");
        } 
        catch (Exception e)
        {
            Console.WriteLine($"Error while reading entries from {file}: {e.Message}");
        }
        
    }
}