using System;
class Circle
{
    //global variable
    public double radius;

    //method for circumference
    public static double Circumference(double radius)
    {
        return (2 * 3.14 * radius);
    }
    //method for area
    public static double Area(double radius)
    {
        return (3.14 * radius * radius);
    }
    public void Display()
    { //display method
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Circumference of Circle: " + Circumference());
        Console.WriteLine("Area of Circle: " + Area());
    }
}
class AreaOfCircle
{
    public static void Main()
    {
        Circle circle = new Circle();
        Console.Write("Enter Radius");
        circle.radius = double.Parse(Console.ReadLine());
        //display the calculation
        circle.Display();
    }

}