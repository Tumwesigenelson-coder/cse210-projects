public class SimpleGoal : Goal
{
    private string _name, _desc;
    private int _points;
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int points)
    {
        _name = name;
        _desc = desc;
        _points = points;
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override string GetStatus() =>
        $"[{"X",1}] {_name} ({_desc})";

    public override string Serialize() =>
        $"SimpleGoal|{_name}|{_desc}|{_points}|{_isComplete}";

    public static SimpleGoal Deserialize(string[] parts)
    {
        string name = parts[1];
        string desc = parts[2];
        int points = int.Parse(parts[3]);
        bool isComplete = bool.Parse(parts[4]);

        var goal = new SimpleGoal(name, desc, points);
        goal._isComplete = isComplete;
        return goal;
    }
}
