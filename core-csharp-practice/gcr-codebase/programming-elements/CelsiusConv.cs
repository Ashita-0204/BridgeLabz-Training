using System;
public class CelsiusConv
{
    public static void Main(String[] args)
    {
        double farenheit = double.Parse(Console.ReadLine());
        double conv = (farenheit - 32) * 5 / 9;
        Console.WriteLine("The converted value to Celsius is " + conv);
    }
}