using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
            "What was the best part of your day?",
            "What are you grateful for today?",
            "Describe a moment that made you smile.",
            "What challenge did you face today and how did you handle it?",
            "What did you learn today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
