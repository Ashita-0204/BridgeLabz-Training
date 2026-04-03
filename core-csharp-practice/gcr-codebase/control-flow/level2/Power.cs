using System;
class Power
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        int result = 1;
        //to calculate power
        for (int i = 1; i <= power; i++)
        {
            result = result * number;
        }
        Console.WriteLine(number + " raised to power of " + power + " is: " + result);
    }
}