using System;
class Bonus
{
    public static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        int salary = int.Parse(Console.ReadLine());
        int bonus = 0;
        if (year < 5)
        {
            bonus = salary * 0.05;
            Console.WriteLine("The bonus is " + bonus);
        }
        else
        {
            Console.WriteLine("No bonus");
        }

    }
}