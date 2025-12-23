using System;

class MultiplicationTable
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        for (int i = 6; i <= 9; i++)
        {
            Console.ReadLine(num + " * " + i + " = " + (num * i));
        }
    }
}