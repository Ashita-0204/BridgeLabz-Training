using System;
using System.Runtime.InteropServices;

class Largest
{
    public static void Main()
    {
        //taking input
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        //to check which one is the largest among the three
        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("Is the first number the largest? Yes");
            Console.WriteLine("Is the second number the largest? No");
            Console.WriteLine("Is the third number the largest? No");
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine("Is the first number the largest? No");
            Console.WriteLine("Is the second number the largest? Yes");
            Console.WriteLine("Is the third number the largest? No");
        }
        else
        {
            Console.WriteLine("Is the first number the largest? No");
            Console.WriteLine("Is the second number the largest? No");
            Console.WriteLine("Is the third number the largest? Yes");
        }
    }
}