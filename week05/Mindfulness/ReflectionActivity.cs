public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful to you?",
        "Have you done this before?",
        "How did you start?",
        "How did it feel when you completed it?",
        "What made this time so different?",
        "What is your favorite part of this experience in your life?",
        "What did you learn from the experience?",
        "How can you use this lesson in the future?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "Reflect on times in your life when you’ve shown strength and resilience.";
    }

    public void Run()
    {
        StartMessage();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(3);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            ShowSpinner(5);
            elapsed += 5;
        }
        EndMessage();
    }
}
