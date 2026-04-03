using System;

class Prime
{
    static bool IsValid(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) //finding facts
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        if (IsValid(num)) //calling method
        {
            Console.WriteLine("Is Prime ");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }
    }
}
