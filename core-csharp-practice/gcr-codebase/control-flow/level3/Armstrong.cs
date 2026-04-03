using System;
class Armstrong
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int original = num;
        int sum = 0;
        while (original != 0) //loop
        {
            int digit = original % 10;
            sum += digit * digit * digit;
            original /= 10;
        }
        if (sum == num)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }
}
