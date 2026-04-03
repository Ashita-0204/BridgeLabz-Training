using System;
public class Miles
{
    public static void Main(String[] args)
    {
        double km = double.Parse(Console.ReadLine());
        double form = km * 0.6;
        Console.WriteLine("The converted value to miles is " + form);
    }
}