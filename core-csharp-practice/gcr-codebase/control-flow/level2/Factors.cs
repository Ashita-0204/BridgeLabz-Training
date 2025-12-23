using System;
class Factors
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Factors of " + num + " are:");
        //to find factors
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}