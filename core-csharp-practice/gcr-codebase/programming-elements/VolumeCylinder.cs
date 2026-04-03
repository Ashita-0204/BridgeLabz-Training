using System;
public class VolumeCylinder
{
    public static void Main(String[] args)
    {
        double rad = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double pi = 3.14;
        double vol = pi * rad * rad * height;
        Console.WriteLine("The volume of Cylinder is " + vol);
    }
}