using System;
public class Entry 
{
    public string _promptText;
    public string _entryText;
    public string _date;


    public Entry (string promptText, string entryText, string date)
    {
        _promptText = promptText;
        _entryText = entryText;
        _date = date;

    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}