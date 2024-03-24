using System;

namespace DailyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            List<string> prompts = new List<string>
            {
                "What was the best part of your day?",
                "Write about an experience where you felt the spirit with you today:",
                "Who was the most interesting person you interacted with today?",
                "Write about something that happened for which you are grateful today:",
                "If you had one thing you could do over today, what would it be?",
                "What was the strongest emotion you felt today?",
                "Write about an act of service you either witnessed or performed today:>",
                "Write about something you learned today:",
                "Write about a tender mercy you noticed today:",
                "Write about a positive interaction you had with someone else today:",
                "Write about something you noticed that reminded you of Jesus Christ today:",
                "Write about something you learned about someone in your life today:",
                "Write about an experience you had that allowed you to teach someone else today:"
            };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("Welcome to your Journal");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Add Entry");
                Console.WriteLine("2. View Entries");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");

                Console.WriteLine("Enter the number of your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = GetRandomPrompt(prompts);
                        journal.AddEntry(prompt);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            Console.WriteLine("Goodbye!");
        }

        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}