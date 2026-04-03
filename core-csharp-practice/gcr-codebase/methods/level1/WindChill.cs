using System;
class WindChill
{
    public double CalculateWindChill(double temperature, double windSpeed)
    {
        //Method to calculate via formula
        windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        return windChill;
    }
    public static void Main()
    {
        //The inputs
        double temp = double.Parse(Console.ReadLine());
        double speed = double.Parse(Console.ReadLine());
        //Calling method
        int ans = CalculateWindChill(temp, speed);
        Console.WriteLine("The wind speed is " + ans);
    }
}