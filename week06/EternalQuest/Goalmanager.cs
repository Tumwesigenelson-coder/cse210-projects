using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type: 1. Simple  2. Eternal  3. Checklist");
        int type = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("Give a description of your goal: ");
        string desc = Console.ReadLine();
        Console.Write("How many points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case 3:
                Console.Write("Target Count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, bonus, target));
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Select a goal to record: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            _score += _goals[choice].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            if (parts.Length < 2) continue;

            string goalType = parts[0];
            string data = parts[1];

            switch (goalType)
            {
                case "SimpleGoal":
                    _goals.Add(SimpleGoal.Deserialize(data));
                    break;
                case "EternalGoal":
                    _goals.Add(EternalGoal.Deserialize(data));
                    break;
                case "ChecklistGoal":
                    _goals.Add(ChecklistGoal.Deserialize(data));
                    break;
                default:
                    Console.WriteLine($"Unknown goal type: {goalType}");
                    break;
            }
        }
    }
}
