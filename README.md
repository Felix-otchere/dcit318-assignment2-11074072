# DCIT 318 - Assignment 2

## Object-Oriented Programming (Inheritance, Abstract Classes, Interfaces)

This assignment demonstrates three major concepts in object-oriented programming (OOP) using C#:

1. **Inheritance and Method Overriding**
2. **Abstract Classes and Methods**
3. **Interfaces**

Each concept is implemented as a separate console application project.

---

### 1. Inheritance & Method Overriding

- **Parent class**: `Animal`
- **Child classes**: `Dog` and `Cat`
- Each child overrides the `Speak()` method
- Shows how objects share common behavior but can act differently

---

### 2. Abstract Classes & Methods

- **Abstract parent**: `Shape`
- **Child classes**: `Circle` and `Rectangle`
- Each child implements `GetArea()` in its own way
- Enforces a rule that all shapes must define how they calculate area

---

### 3. Interfaces

- **Interface**: `IMovable` (with `Move()` method)
- **Classes**: `Car` and `Bicycle`
- Both implement `Move()` differently
- Shows flexibility: multiple classes can share the same contract

---

### How to Run

1. Open each project folder (InheritanceApp, AbstractApp, InterfaceApp)
2. Run `dotnet run` inside each folder
3. View the output in the terminal
