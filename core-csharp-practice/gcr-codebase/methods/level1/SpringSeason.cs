using System;
class SpringSeason
{
    public static bool isIt(int month, int day)
    { // aboolean method to check
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
        {
            return true;
        }
        return false;
    }
    public static void Main()
    {
        Console.Write("Month");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Day");
        int day = int.Parse(Console.ReadLine());
        if (isIt)
        {
            Console.WriteLine("A spring season");
        }
        else
        {
            Console.WriteLine("NOt a spring season");
        }
    }
}