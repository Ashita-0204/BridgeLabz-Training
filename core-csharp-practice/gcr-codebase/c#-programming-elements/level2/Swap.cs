using System;
class Swap
{
    public static void Main()
    {
        Console.WriteLine("Enter number 1: "); //input
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");
        int num2 = int.Parse(Console.ReadLine());
        //Swap with an additional variable
        int num3 = num1;
        num1 = num2;
        num2 = num3;
        Console.WriteLine("The swapped numbers are " + num1 + " and " + num2);
    }
}