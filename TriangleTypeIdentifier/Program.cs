using System;

class Program
{
    static void Main()
    {
        // Ask user for three side lengths
        Console.Write("Enter side 1: ");
        string side1Input = Console.ReadLine();

        Console.Write("Enter side 2: ");
        string side2Input = Console.ReadLine();

        Console.Write("Enter side 3: ");
        string side3Input = Console.ReadLine();

        // Try to convert inputs to numbers
        if (int.TryParse(side1Input, out int side1) &&
            int.TryParse(side2Input, out int side2) &&
            int.TryParse(side3Input, out int side3))
        {
            // Determine triangle type
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Equilateral triangle (all sides equal).");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("Isosceles triangle (two sides equal).");
            }
            else
            {
                Console.WriteLine("Scalene triangle (no sides equal).");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers for all sides.");
        }
    }
}
