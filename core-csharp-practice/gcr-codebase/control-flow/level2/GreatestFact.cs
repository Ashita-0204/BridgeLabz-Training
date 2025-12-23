using System;
class GreatestFact
{

    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int factor = 1;
        // to find the greatest factor
        for (int i = num - 1; i >= 1; i--)
        {
            if (num % i == 0)
            {
                factor = i;
                break;
            }
        }
        Console.WriteLine("Greatest Factor of " + num + " is: " + factor);
    }
}