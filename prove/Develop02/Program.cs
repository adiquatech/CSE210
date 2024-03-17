using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to your Journal");

        while (true)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. View Entries");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    journal.LoadFromFile("filename.txt");
                    break;

                case "4":
                    journal.SaveToFile("filename.txt");
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}

public class Journal
{
    public void AddEntry()
    {
        // Add entry code here
    }

    public void DisplayAll()
    {
        // Display entries code here
    }

    public void LoadFromFile(string fileName)
    {
        // Load the file here
    }

    public void SaveToFile(string fileName)
    {
        // Save the file here
    }
}