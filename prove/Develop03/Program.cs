using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string reference;
    private List<Word> words;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string Reference => reference;

    public List<Word> Words => words;

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, words.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(0, words.Count);
            words[index].Hide();
        }
    }

    public void Display()
    {
        Console.WriteLine(reference);
        Console.WriteLine(string.Join(" ", words.Select(word => word.IsVisible ? word.Text : "_____")));
    }
}

public class Reference
{
    private int chapter;
    private int startVerse;
    private int endVerse;

    public Reference(int chapter, int startVerse)
    {
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = startVerse;
    }

    public Reference(int chapter, int startVerse, int endVerse)
    {
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public override string ToString()
    {
        if (startVerse == endVerse)
            return $"{chapter} {startVerse}";
        else
            return $"{chapter} {startVerse}-{endVerse}";
    }
}

public class Word
{
    private string text;
    private bool isVisible;

    public Word(string text)
    {
        this.text = text;
        this.isVisible = true;
    }

    public string Text => text;

    public bool IsVisible => isVisible;

    public void Hide()
    {
        isVisible = false;
    }
}

class Program
{
    static void Main()
    {
        // Create a scripture object
        Scripture scripture = new Scripture("1 Nephi 3:7", "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        // Display the complete scripture
        scripture.Display();

        // Prompt the user to press Enter or type "quit"
        while (true)
        {
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;
            else
            {
                // Hide a few random words
                scripture.HideRandomWords();

                // Clear the console and display the scripture again
                Console.Clear();
                scripture.Display();
            }
        }
    }
}