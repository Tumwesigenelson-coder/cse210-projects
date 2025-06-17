using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is my ExerciseTracking Project.");

         List<Activity> activities = new List<Activity>
        {
            new Running("15 Feb 2022", 30, 4.8),
            new Cycling("15 Feb 2022", 45, 15.0),
            new Swimming("15 Feb 2022", 40, 60)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
