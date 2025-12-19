using System;
class MilesConv
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter distance in kilometers:");
        double km = double.Parse(Console.WriteLine());
        //formula to convert kilometers to miles 
        double miles = km / 1.6;
        Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
    }
}