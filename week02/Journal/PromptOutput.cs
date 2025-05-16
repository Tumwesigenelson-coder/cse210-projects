using System;

public class PromptOutput
{
    private List<string> _prompts = new List<string>
    {
        "What is the first thing you do every moerning you wakeup?",
        "If God gave you one minute on your last day of your breathe, what would you do?",
        "what is the most moment you enjoyed in the day?",
        "What was the strongest emotion did you  feel today?",
        "If the president asked you of what you want him to do for you, what would it be?",
        "This month who was your best friend to help you out in your hard times?",
        "Who is that person you can`t spend day with out talking to",
        "What color are you going to choose this month to use in everything?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
