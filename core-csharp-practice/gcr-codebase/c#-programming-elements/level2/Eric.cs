using System;

public class Eric
{
    public static void Main()
    {
        //input
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter from city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter to city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter distance from-to-via (miles): ");
        double fromToVia = double.Parse(Console.ReadLine());

        Console.Write("Enter distance via-to-final city (miles): ");
        double viaToFinalCity = double.Parse(Console.ReadLine());

        Console.Write("Enter total time taken (hours): ");
        double timeTaken = double.Parse(Console.ReadLine());

        //calculation
        double Distance = fromToVia + viaToFinalCity;
        double averageSpeed = Distance / timeTaken;

        Console.WriteLine(
        "The results of the trip are: " + name + ", " + Distance + ", " + averageSpeed);

    }
}
