using System;
class LeapYear
{
    public static bool IsLeap(int year)
    {
        if (year < 1582) //checking condition
        {
            return false;
        }
        if (year % 4 == 0 || year % 100 != 0 || year % 400 == 0)
        {
            return true;
        }
        return false;
    }
    public static void Main()
    {
        //input
        int year = int.Parse(Console.ReadLine());
        if (IsLeap(year)) //if true
        {
            Console.WriteLine("Is a Leap Year");
        }
        else
        {
            Console.WriteLine("Not a Leap Year");
        }
    }
}