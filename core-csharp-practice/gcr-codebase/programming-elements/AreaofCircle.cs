using System;
public class AreaofCircle
{
    public static void Main(String[] args)
    {
        Console.Write("Enter Radius");
        double rad = double.Parse(Console.ReadLine());
        double pi = 3.14;
        double area = pi * rad * rad;

        Console.WriteLine("The Area of a circle is " + area);
    }
}
