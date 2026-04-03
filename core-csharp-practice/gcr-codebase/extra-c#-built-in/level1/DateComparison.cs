using System;

class DateComparison
{
    public static void Main()
    {
        //input
        DateTime date1 = Convert.ToDateTime(Console.ReadLine());
        DateTime date2 = Convert.ToDateTime(Console.ReadLine());
        int res = DateTime.Compare(date1, date2); //compare
        //comparison
        if (res < 0)
        {
            Console.WriteLine("First date is previous of the second date");
        }
        else if (res > 0)
        {
            Console.WriteLine("First date is post second date");
        }
        else
        {
            Console.WriteLine("Both dates are same");
        }
    }
}
