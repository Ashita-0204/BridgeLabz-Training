using System;
class NaturalSum //using while
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
        int i = 1;
        while (num >= 1)
        {
            total += i;
            i++;//via loop
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