public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent(); // Returns points earned
    public abstract bool IsComplete();
    public abstract string GetStatus(); // [ ] or [X] or progress
    public abstract string Serialize(); // For saving
}
