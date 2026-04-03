using System;
class Harshad
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int temp = num;
        int sum = 0;
        while (temp != 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        if (num % sum == 0)
        {
            Console.WriteLine("Harshad Number");
        }
        else
        {
            Console.WriteLine("Not a Harshad Number");
        }
    }
}