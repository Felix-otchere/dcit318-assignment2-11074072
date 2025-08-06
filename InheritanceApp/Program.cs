using System;

// Base (parent) class
class Animal
{
    // Virtual method: child classes can replace this with their own version
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound...");
    }
}

// Dog inherits from Animal
class Dog : Animal
{
    // Overrides the Speak method
    public override void Speak()
    {
        Console.WriteLine("Dog says: Woof Woof!");
    }
}

// Cat inherits from Animal
class Cat : Animal
{
    // Overrides the Speak method
    public override void Speak()
    {
        Console.WriteLine("Cat says: Meow!");
    }
}

class Program
{
    static void Main()
    {
        // I’m just testing each animal’s sound
        Animal normalAnimal = new Animal();
        Dog myDog = new Dog();
        Cat myCat = new Cat();

        normalAnimal.Speak();  // Should print generic sound
        myDog.Speak();         // Should print Woof Woof
        myCat.Speak();         // Should print Meow
    }
}
