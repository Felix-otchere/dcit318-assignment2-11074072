using System;

// Abstract class - you cannot create an object from this directly
abstract class Shape
{
    // Abstract method - child classes MUST override this
    public abstract double GetArea();
}

// Circle inherits from Shape and provides its own way of calculating area
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius; // πr²
    }
}

// Rectangle inherits from Shape and provides its own way of calculating area
class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main()
    {
        // I’m testing two different shapes

        Circle circle = new Circle(5);       // radius 5
        Rectangle rectangle = new Rectangle(4, 6); // 4x6 rectangle

        Console.WriteLine($"Area of circle: {circle.GetArea()}");
        Console.WriteLine($"Area of rectangle: {rectangle.GetArea()}");
    }
}
