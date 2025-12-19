using System;
class Distance
{
    static void Main(string[] args)
    {
        double kilometers = 10.8;
        //formula to convert kilometers to miles
        double miles = kilometers / 1.6;
        Console.WriteLine("The Distance " + kilometers + " km in miles is " + miles);
    }
}