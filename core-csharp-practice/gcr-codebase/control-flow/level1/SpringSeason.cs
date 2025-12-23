using System;

class SpringSeason
{
    public static void Main()
    {

        //taking input
        Console.Write("Month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Day: ");
        int day = int.Parse(Console.ReadLine());

        //checking the condition
        if (month == 3 && day >= 20 || month > 3 && month <= 6 || month == 6 && day <= 20)
        {
            Console.WriteLine("It's a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}