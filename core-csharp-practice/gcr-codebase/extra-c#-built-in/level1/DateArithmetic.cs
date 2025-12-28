using System;

class DateArithmetic
{
    public static void Main()
    {
        Console.Write("Date (yyyy-MM-dd): ");
        DateTime date = Convert.ToDateTime(Console.ReadLine());
        DateTime result = date.AddDays(7).AddMonths(1).AddYears(2).AddDays(-21); // subtracting 3 weeks

        Console.WriteLine("Final Date: " + result.ToShortDateString());
    }
}
