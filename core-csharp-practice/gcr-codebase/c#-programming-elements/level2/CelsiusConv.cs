using System;

public class CelsiusConv
{
    public static void Main(String[] args)
    {
        // in fahrenheit
        Console.WriteLine("Enter the temperature in fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        // Conversion formula
        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine("The " + fahrenheit + "Fahrenheit is " + celsius + "Celsius");

    }
}
