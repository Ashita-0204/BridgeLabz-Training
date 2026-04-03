using System;

class Quotient
{
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quo = number / divisor; //calculation
        int rem = number % divisor;
        return new int[] { quo, rem };
    }

    public static void Main()
    {
        //Taking inputs
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        //calling method via array
        int[] arr = Division(num1, num2);
        Console.WriteLine(" The Quotient is " + arr[0] + " and Remainder " + arr[1]);
    }
}
