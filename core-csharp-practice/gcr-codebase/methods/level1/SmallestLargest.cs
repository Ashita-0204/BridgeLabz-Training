using System;
using System.ComponentModel;
class SmallestLargest
{
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        //the method with arr
        int smallest = Math.Min(n1, Math.Min(n2, n3));
        int largest = Math.Max(n1, Math.Max(n2, n3));
        return new int[] { smallest, largest };
    }

    public static void Main()
    {   //taking inputs
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        //calling the methdo via an array
        int[] arr = FindSmallestAndLargest(num1, num2, num3);
        Console.WriteLine("The smallest is " + arr[0] + "and the largest is " + arr[1]);
    }
}