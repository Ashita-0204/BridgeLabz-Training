using System;
class Mathematical
{
    public static long Factorial(int num)
    {
        if (num < 0) //base case
        {
            Console.WriteLine("Invalid");
            return -1;
        }
        long fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact* i; //calculation
        }
        return fact;
    }

    public static bool IsPrime(int num)
    {
        if (num <= 1) //base case
        {
            return false;
        }
        for (int i = 2; i <= nameof / 2; i++)
        {
            if (num % i == 0)
            { //if factors present
                return false;
            }
        }
        return true;
    }

    public static int GCD(int num1, int num2)
    {
        if (num1 == 0) //base case
        {
            return Math.Abs(num2);
        }
        if (num2 == 0) //base case
        {
            return Math.Abs(num1);
        }
        num1 = Math.Abs(num1);
        num2 = Math.Abs(num2);
        while (num1 != num2) ///loops for calculation
        {
            if (num1 > num2)
            {
                num1 = num1 - num2;
            }
            else
            {
                num2 = num2 - num1;
            }
        }
        return num1;
    }

    public static int Fibonacci(int num)
    {
        if (num < 0) //base case
        {
            return -1;
        }
        if (num == 0) //base case
        {
            return 0;
        }
        if (num == 1)//base case
        {
            return 1;
        }
        int a = 0, b = 1, c = 0;
        for (int i = 2; i <= num; i++) //Calculation
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }
    public static void Main()
    {
        //input of numbers
        Console.Write("Enter Number: ");
        int num = Console.ReadLine();
        Console.Write("Enter Number: ");
        int num1 = Console.ReadLine();
        //Calling of diff methods 
        Console.WriteLine("Factorial of the number is: " + Factorial(num));
        Console.WriteLine("Is the number Prime: " + IsPrime(num));
        Console.WriteLine("GCD of the numbers are : " + GCD(num, num1));
        Console.WriteLine("Fibonacci of the number is: ");

    }
}