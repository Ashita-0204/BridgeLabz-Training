using System;

class ReverseNumber
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int temp = num;
        int c = 0;
        //find the length 
        while (temp != 0)
        {
            c++;
            temp = temp / 10;
        }
        int[] arr = new int[c];
        //reverse
        for (int i = 0; i < c; i++)
        {
            arr[i] = num % 10;
            num = num / 10;
        }
        //printing
        Console.Write("Reversed Number ");
        for (int i = 0; i < c; i++)
        {
            Console.Write(arr[i]);
        }
    }
}