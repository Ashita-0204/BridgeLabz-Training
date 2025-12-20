using System;
public class Athlete
{
    public static void Main(String[] ags)
    {
        Console.Write("Enter side1: "); //input
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter side2: ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter side3: ");
        double side3 = double.Parse(Console.ReadLine());
        //Calculation
        double perimeter = side1 + side2 + side3;
        double rounds = 5000 / perimeter;
        Console.WriteLine($"The total number of rounds the athlete will run is {rounds}");
    }
}
