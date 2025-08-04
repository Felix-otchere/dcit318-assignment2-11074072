using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade (0-100): ");
        string input = Console.ReadLine();

        // Try to convert input to number safely
        if (int.TryParse(input, out int grade))
        {
            if (grade >= 90)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your grade is D");
            }
            else
            {
                Console.WriteLine("Your grade is F");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
    }
}
