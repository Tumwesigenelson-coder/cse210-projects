using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! Welcome to my EternalQuest Project.");

        GoalManager manager = new GoalManager();
        string input = "";


        while (input != "6")
        {
            Console.WriteLine("=== Eternal Quest Program ===");
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            Console.Write("Choose an option you would like to take: ");
            input = Console.ReadLine();

            switch (input) 
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    manager.RecordEvent();
                    break;
                case "4":
                    Console.Write("Enter filename to save: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;
                case "5":
                    Console.Write("Enter filename to load: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid input.\n");
                    break;
            }
        }
    }
}
