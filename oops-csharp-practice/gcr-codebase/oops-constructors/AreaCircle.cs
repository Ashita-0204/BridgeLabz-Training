using System;

class Circle
{
    public double radius;

    // Default constructor
    public Circle() : this(1.0)   // Constructor chaining
    { }

    // Parameterized constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public void Display()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + (3.14 * radius * radius));
    }
}

class AreaCircle
{
    public static void Main()
    {
        Circle circle = new Circle();
        Circle circle1 = new Circle(5);

        circle.Display();
        circle1.Display();
    }
}


