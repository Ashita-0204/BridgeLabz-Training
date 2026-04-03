using System;
class FactorialWhile
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int fact = 0, i = 0;
        if (num == 1 || num == 0) //fact for 0 and 1
        {
            fact = 1;
        }
        while (i <= num)
        {
            fact *= i; //calculation
            i++;
        }
        Console.WriteLine("The factorial of the number is " + fact);
    }
}