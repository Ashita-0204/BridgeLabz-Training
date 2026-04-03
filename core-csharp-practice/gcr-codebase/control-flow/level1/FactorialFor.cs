using System;
class FactorialFor
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int fact = 0, i = 0;
        if (num == 1 || num == 0) //fact for 0 and 1
        {
            fact = 1;
        }
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        Console.WriteLine("The factorial of the number is " + fact);
    }
}