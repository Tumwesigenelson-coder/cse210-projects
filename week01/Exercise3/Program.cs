using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        string playAgain;

        do
        {
            //Random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); 
            int userGuess = -1;
            int userAttempts = 0;

            Console.WriteLine("Nelson is thinking of a number between 1 and 100. Guess the number!");

            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess number? ");
                userGuess = int.Parse(Console.ReadLine());
                userAttempts++;

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {userAttempts} guesses.");
                }
            }

            Console.Write("Would you like to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
            Console.WriteLine();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing!");
    }
    }
}
