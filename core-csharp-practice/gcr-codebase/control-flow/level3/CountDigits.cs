using System;
class CountDigits
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int count = 0;
        while (num != 0)
        {
            num /= 10;
            count++;
        }
        Console.WriteLine("Number of digits = " + count);
    }
}