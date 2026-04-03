using System;
using System.Runtime.CompilerServices;
class OddEven
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num > 0) //for natural num
        {
            for (int i = 1; i <= num; i++)
            { //till the last num
                if (i % 2 == 0) //even
                {
                    Console.WriteLine("The number " + i + " is divisible by 2");
                }
                else
                {
                    Console.WriteLine("The number " + i + " is not divisible by 2");
                }
            }
        }
        else
        {
            Console.WriteLine("The number is not a natural number");
        }
    }
}