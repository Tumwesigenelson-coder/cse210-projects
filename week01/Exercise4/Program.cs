using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
         List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers and type 0 when finished.");

        // Request loop
        while (userNumber != 0)
        {
            Console.Write("Enter your number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                //adding user number to the stored number
                numbers.Add(userNumber);
            }
        }

        // Finding the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of numbers is: {sum}");

        // Calculate the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of  numbers is: {average}");

        // Finding the largest number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        //smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There were no positive numbers.");
        }

        //Sorting the list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            //displaying the list
            Console.WriteLine(number);
        }
    }
}
