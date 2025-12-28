using System;

class Maximum
{
    public static int FindMax(int num1, int num2, int num3)
    {
        int max = num1; //conditioning to find max
        if (num2 > max)
        {
            max = num2;
        }
        if (num3 > max)
        {
            max = num3;
        }
        return max;
    }

    public static void Main()
    {
        //input
        Console.Write("Enter nums");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        //printing statement
        Console.WriteLine("Maximum number is " + FindMax(num1, num2, num3));
    }
}
