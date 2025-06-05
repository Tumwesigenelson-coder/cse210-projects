public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt peace recently?",
        "Who are your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "List as many positive things as you can in a specific area.";
    }

    public void Run()
    {
        StartMessage();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("Begin listing items:");
        PauseWithCountdown(3);

        int startTime = Environment.TickCount;
        List<string> items = new List<string>();
        while ((Environment.TickCount - startTime) / 1000 < _duration)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            items.Add(input);
        }

        Console.WriteLine($"You listed {items.Count} items!");
        EndMessage();
    }
}
