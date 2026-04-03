using System;
class LeapYear
{
    public static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        if (year >= 1582) //Condition statement
        {
            if (year % 4 == 0)
            {
                Console.WriteLine("A leap Year");
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine("A leap Year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Not a leap Year");
            }
        }
        else
        {
            Console.WriteLine("Not a leap Year");
        }
    }
}