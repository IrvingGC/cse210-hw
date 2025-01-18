using System;

public class PromptGenerator
{
    private static readonly string[] Prompts = 
    {
        "Who was the most interesting person I interacted with today?",
        "What am I grateful for today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the most fun thing I did today?",
        "What was the most challenging thing I faced today?"
    };

    private static Random random = new Random();

    public string GetRandomPrompt()
    {
        int index = random.Next(Prompts.Length);
        return Prompts[index];
    }
}