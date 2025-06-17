public  abstract class Goal
{
    public abstract string Serialize();
    public static Goal Deserialize(string data)
    {
        string[] parts = data.Split('|');
        string type = parts[0];

        switch (type)
        {
            case "SimpleGoal":
                return SimpleGoal.Deserialize(parts);
            case "EternalGoal":
                return EternalGoal.Deserialize(parts);
            case "ChecklistGoal":
                return ChecklistGoal.Deserialize(parts);
            default:
                throw new Exception("Unknown goal type.");
        }
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
}
