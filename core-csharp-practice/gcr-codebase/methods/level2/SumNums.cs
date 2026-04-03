// using System;
using System.Globalization;

class SumNums
{
    public static int SumFormula(int num) //the formula
    {
        int form = num * (num + 1) / 2;
        return form;
    }

    public static int SumRecurr(int num) //the recursion
    {
        if (num == 0)
        {
            return 0;
        }
        return num + SumRecurr(num - 1);
    }
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num <= 0)
        {
            Console.WriteLine("Invalid input");
        }
        int val1 = SumFormula(num); //the formula
        int val2 = SumRecurr(num); //via recursion
        if (val1 == val2)
        {
            Console.WriteLine("Valid Computation");
        }
        else
        {
            Console.WriteLine("Invalid!");
        }
    }
}