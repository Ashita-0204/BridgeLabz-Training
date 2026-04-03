using System;
class PositiveNegative
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine()); //input
        if (num < 0) //negative num
        {
            Console.WriteLine("The number is negative");
        }
        else if (num > 0) //positive num
        {
            Console.WriteLine("The number is positive");
        }
        //for zero
        {
            Console.WriteLine("The number is zero");
        }
    }
}