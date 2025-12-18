using System;
using System.Diagnostics.Contracts;
public class Average
{
    public static void Main(String[] args)
    {
        int val1 = int.Parse(Console.ReadLine());
        int val2 = int.Parse(Console.ReadLine());
        int val3 = int.Parse(Console.ReadLine());
        int average = (val1 + val2 + val3) / 3;
        Console.WriteLine("The average of three nums is " + average);
    }
}