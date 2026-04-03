using System;
public class Power
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the base and exp");
        double b = double.Parse(Console.ReadLine());
        double exp = double.Parse(Console.ReadLine());
        double value = Math.Pow(b, exp);
        Console.WriteLine("The exponential is " + value);
    }
}