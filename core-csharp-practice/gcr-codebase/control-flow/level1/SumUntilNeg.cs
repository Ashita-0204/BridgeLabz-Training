using System;
using System.Linq.Expressions;
public class SumUntilNeg
{
    public static void Main()
    {
        double total = 0.0;
        while (true) //to keep loop ongoing
        {
            double num = double.Parse(Console.ReadLine());
            if (num <= 0) //if negative or zero
            {
                break;
            }
            total += num;//total sum
        }
        Console.WriteLine("The sum until Negative or Zero is " + total);
    }
}