class ReflectionActivity : Activity
{
    public override void StartActivity()
    {
        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you achieved something in life.",
            "Think of a time when you got something done.",
            "Think of a time when you got yourself i some kind of trouble.",

        };

        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "Have you ever felt like this before?",
            "Can you tell me about it?",
        };

        CommonStartingMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Random random = new Random();
        int remainingTime = duration;
        while (remainingTime > 0)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Thread.Sleep(4000);
            }

            remainingTime -= 10;
        }

        CommonEndingMessage("Reflection Activity");
    }
}

class ListingActivity : Activity
{
    public override void StartActivity()
    {
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
        };

        CommonStartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);

        Console.WriteLine("You have 10 seconds to start listing...");
        Thread.Sleep(10000);

        Console.WriteLine("Enter each item and press Enter. Press Enter again to finish.");

        int count = 0;
        string input;
        do
        {
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                count++;
            }
        } while (!string.IsNullOrWhiteSpace(input));

        Console.WriteLine($"You listed {count} items.");

        CommonEndingMessage("Listing Activity");
    }
}
