using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! Welcome to my Journal Project.");
        Console.WriteLine("Developer: Tumwesige Nelson");
        Console.WriteLine();

        Journal myJournal = new Journal();
        PromptOutput PromptOutput = new PromptOutput();

        bool running = true;

        //Working on the while loop for the user`s options
        while (running)
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write a new UserEntry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            Console.Write("Choose what would you like to do? ");
            string choice = Console.ReadLine();
        
        //Working with conditional (Case format)
            switch (choice)
            {
                case "1":
                    string prompt = PromptOutput.GetRandomPrompt();
                    Console.WriteLine($"\n{prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    UserEntry UserEntry = new UserEntry
                    {
                        _date = DateTime.Now.ToShortDateString(),
                        _prompt = prompt,
                        _response = response,    
                    };

                    //adding time (request for help instructor, i tried it out but it could not show time)
                    UserEntry userEntry = new UserEntry
                    {
                        _time = DateTime.Now.ToShortTimeString(),
                        _prompt = prompt,
                        _response = response,

                    };

                    myJournal.AddUserEntry(UserEntry);
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter the filename to save: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter the filename to load: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again with numbers from 1 to 5.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
