using System;
using System.Collections.Generic;

class Pump
{
    public int petrol, distance;
    public Pump(int p, int d)
    {
        petrol = p;
        distance = d;
    }
}
class CircularTour
{

    static int FindStart(Pump[] pumps)
    {
        int total = 0, curr = 0, start = 0;
        for (int i = 0; i < pumps.Length; i++)
        {
            int diff = pumps[i].petrol - pumps[i].distance;
            total += diff;
            curr += diff;

            if (curr < 0)
            {
                start = i + 1;
                curr = 0;
            }
        }
        return total >= 0 ? start : -1;
    }
    public static void Main()
    {
        Pump[] pumps = { new Pump(6, 4), new Pump(3, 6), new Pump(7, 3) };
        Console.WriteLine(FindStart(pumps));
    }
}