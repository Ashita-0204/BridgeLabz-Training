using System;

class TempConv
{
    public static void Main(String[] args)
    {
        // Input temp
        Console.WriteLine("Enter the temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        // Conversion formula
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("The " + celsius + "Celsius is " + fahrenheit + "Fahrenheit");

    }
}
