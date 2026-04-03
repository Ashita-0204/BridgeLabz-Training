using System;
public class VolumeEarth
{
    public static void Main(String[] args)
    {
        double radius = 6378;
        double pi = 3.14;
        //in cubic kilometers
        double volume = (4.0 / 3.0) * pi * radius * radius * radius;
        //in cubic miles
        double volumeInMiles = volume / (1.6 * 1.6 * 1.6);
        Console.WriteLine("The volume of earth in cubic kilometers is " + volume + " and cubic miles is " + volumeInMiles);
    }
}