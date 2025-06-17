public class EternalGoal : Goal
{
    private string _name, _desc;
    private int _points;

    public EternalGoal(string name, string desc, int points)
    {
        _name = name;
        _desc = desc;
        _points = points;
    }

    public override int RecordEvent() => _points;

    public override string GetStatus() =>
        $"[ ] {_name} ({_desc})";

    public override string Serialize() =>
        $"EternalGoal|{_name}|{_desc}|{_points}";

    public static EternalGoal Deserialize(string[] parts)
    {
        return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
    }
}
