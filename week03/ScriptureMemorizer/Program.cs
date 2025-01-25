using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter reference (for example Proverbs 3:5-6):");
        string reference = Console.ReadLine();

        Console.WriteLine("Enter the scripture text:");
        string scriptureText = Console.ReadLine();

        Scripture scripture = new Scripture(reference, scriptureText);

        scripture.DisplayScripture();

        while (true)
        {
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
            scripture.DisplayScripture();
        }
    }
}

public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(Reference.GetFormattedReference());
        foreach (var word in Words)
        {
            Console.Write(word.IsHidden ? new string('_', word.Text.Length) : word.Text);
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Any())
        {
            Random rand = new Random();
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }
}

public class Reference
{
    public string ReferenceText { get; set; }

    public Reference(string reference)
    {
        ReferenceText = reference;
    }

    public string GetFormattedReference()
    {
        return ReferenceText;
    }
}

public class Word
{
    public string Text { get; set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }


    public void Hide()
    {
        IsHidden = true;
    }
}