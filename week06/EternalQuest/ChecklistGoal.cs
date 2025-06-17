public class ChecklistGoal : Goal
{
    private string _name, _desc;
    private int _points, _bonus, _target, _count;

    public ChecklistGoal(string name, string desc, int points, int bonus, int target)
    {
        _name = name;
        _desc = desc;
        _points = points;
        _bonus = bonus;
        _target = target;
        _count = 0;
    }

    public override int RecordEvent()
    {
        if (_count < _target)
        {
            _count++;
            if (_count == _target)
                return _points + _bonus;
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        string check = _count >= _target ? "X": " ";
        return $"[{check}] {_name} ({_desc}) -- Completed: {_count}/{_target}";
    }

    public override string Serialize() =>
        $"ChecklistGoal|{_name}|{_desc}|{_points}|{_bonus}|{_target}|{_count}";

    public static ChecklistGoal Deserialize(string[] parts)
    {
        var goal = new ChecklistGoal(
            parts[1],
            parts[2],
            int.Parse(parts[3]),
            int.Parse(parts[4]),
            int.Parse(parts[5])
        );
        goal._count = int.Parse(parts[6]);
        return goal;
    }
}
