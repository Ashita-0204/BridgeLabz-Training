using System;

class Digit
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int[] arr = new int[10];
        while (num != 0)//freq of each number
        {
            int digit = num % 10;
            arr[digit]++;
            num = num / 10;
        }
        //printing statement 
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digit " + i + " = " + arr[i]);
        }
    }
}