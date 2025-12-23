using System;
class NaturalSumFor
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine()); //input
        if (num <= 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }

        int sum = num * (num + 1) / 2; //calculation via formula
        int total = 0;
        for (int i = 1; i <= num; i++)
        {
            total += i;
        }
        if (sum == total)
        {
            Console.WriteLine("Both computations are correct");
        }
        else
        {
            Console.WriteLine("The computation is not Valid");
        }

    }
}