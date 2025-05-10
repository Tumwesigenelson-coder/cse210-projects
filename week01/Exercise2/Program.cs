using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        // working with letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        // working with the signs
        int gradesign = grade % 10;

        if (letter != "A" && letter != "F")
        {
            if (gradesign >= 7)
            {
                sign = "+";
            }
            else if (gradesign < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A")
        {
            if (gradesign < 3)
            {
                sign = "-";
            }
        }
    
        Console.WriteLine($"Your grade is: {letter}{sign}");
        // for passing and failing 
        if (grade >= 70)
        {
            Console.WriteLine("Great! You have passed the course.");
        }
        else
        {
            Console.WriteLine("You didn't pass well this time, but work hard you will make it!");
        }
    }
}
