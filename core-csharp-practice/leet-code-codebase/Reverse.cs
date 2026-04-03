using System;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
public class Reverse
{
    public static int reverse(int num) // calling funct
    {
        int rev = 0;
        bool neg = num < 0;
        num = Math.Abs(num); //neg->positive
        while (num > 0)
        {
            if (Integer.Max_Value / 10 < rev)
            {
                return 0;
            }
            rev = rev * 10 + num % 10;
            num = num / 10;
        }
        return neg ? -num : num; //return negative value for negation and positive val for positive
    }
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(reverse(n)); //calling function
    }
}