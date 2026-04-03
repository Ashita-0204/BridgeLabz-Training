using System;

class TemperatureConverter
{
    //Methods
    public static double FahrenheitToCelsius(double faren)
    {
        return (faren - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double cels)
    {
        return (cels * 9 / 5) + 32;
    }

    public static void Main()
    {
        Console.Write("Enter temperature: ");
        double temp = double.Parse(Console.ReadLine());
        char pref = Console.ReadLine()[0]; //cels/faren

        if (pref == 'C')
        {
            Console.WriteLine("Celsius: " + FahrenheitToCelsius(temp));
        }
        else
        {
            Console.WriteLine("Fahrenheit: " + CelsiusToFahrenheit(temp));
        }
    }
}
