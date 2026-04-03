using System;
public class PerimeterRect
{
    public static void Main(String[] args)
    {
        int length = int.Parse(Console.ReadLine());
        int breadth = int.Parse(Console.ReadLine());
        int perimeter = 2 * (length + breadth);
        Console.WriteLine("The perimeter of the rectangle is " + perimeter);
    }
}