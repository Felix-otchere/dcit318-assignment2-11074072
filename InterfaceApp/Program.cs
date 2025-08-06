using System;

// Interface - acts like a contract
interface IMovable
{
    void Move();
}

// Car implements IMovable
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("The car drives forward smoothly.");
    }
}

// Bicycle implements IMovable
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("The bicycle pedals forward steadily.");
    }
}

class Program
{
    static void Main()
    {
        // Objects that follow IMovable contract
        IMovable myCar = new Car();
        IMovable myBike = new Bicycle();

        myCar.Move();   // Should say car drives forward
        myBike.Move();  // Should say bicycle pedals forward
    }
}
