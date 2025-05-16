using System;

public class Journal
{
    private List<UserEntry> _entries = new List<UserEntry>();

    public void AddUserEntry(UserEntry UserEntry)
    {
        _entries.Add(UserEntry);
    }

    public void DisplayAll()
    {
        foreach (UserEntry UserEntry in _entries)
        {
            UserEntry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (UserEntry UserEntry in _entries)
            {
                writer.WriteLine($"{UserEntry._date}|{UserEntry._prompt}|{UserEntry._response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    UserEntry UserEntry = new UserEntry
                    {
                        _date = parts[0],
                        _prompt = parts[1],
                        _response = parts[2]
                    };
                    _entries.Add(UserEntry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
