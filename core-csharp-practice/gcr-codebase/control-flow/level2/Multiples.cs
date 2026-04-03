using System;
class Multiples
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Multiples of " + number + " below 100 are:");
        //iteration for multiples
        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}