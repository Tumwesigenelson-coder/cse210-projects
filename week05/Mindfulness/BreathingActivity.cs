public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by guiding you through slow breathing steps.";
    }

    public void Run()
    {
        StartMessage();
        int timeLeft = _duration;
        while (timeLeft > 0)
        {
            Console.WriteLine("Breathe in...");
            PauseWithCountdown(3);
            Console.WriteLine("Breathe out...");
            PauseWithCountdown(3);
            timeLeft -= 6;
        }
        EndMessage();
    }
}
