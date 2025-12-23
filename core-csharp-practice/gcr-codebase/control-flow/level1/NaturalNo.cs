using System;
class NaturalNo
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine()); //input
        int sum = num * (num + 1) / 2; //calculation for sum
        if (num <= 0) //Natural number verification
        {
            Console.WriteLine("The sum of " + num + " natural number is " + sum);
        }
        else
        {
            Console.WriteLine("The number " + num + " is not a natural number");
        }
    }
}