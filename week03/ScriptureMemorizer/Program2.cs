using System;

// Exceeding Requirements: Added a welcome and a goodbye message 
// Could be extended to load scriptures from a file or randomly select from a library.

class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer Week Assignment!");
       
        Reference2 reference2 = new Reference2("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding;in all your ways submit to him, and he will make your paths straight.";
        Scripture scripture = new Scripture(reference2, text);

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are now hidden. Goodbye!");
    }
}
