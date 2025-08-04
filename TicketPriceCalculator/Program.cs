 using System;

class Program
{
    static void Main()
    {
        // Ask the user for their age
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Check if input is a number
        if (int.TryParse(input, out int age))
        {
            // Senior citizens (65+) or children (12 and below) get discount
            if (age >= 65 || age <= 12)
            {
                Console.WriteLine("Your ticket price is GHC 7");
            }
            else
            {
                Console.WriteLine("Your ticket price is GHC 10");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number for age.");
        }
    }
}

