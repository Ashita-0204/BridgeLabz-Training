using System;

class OddEven
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }
        int[] odd = new int[number / 2 + 1];
        int[] even = new int[number / 2 + 1];
        int oddIdx = 0, evenIdx = 0;
        for (int i = 0; i < number; i++)
        {
            if (i % 2 == 0)
                even[evenIdx++] = i;
            else
                odd[oddIdx++] = i;
        }
        Console.WriteLine("Odd Numbers");
        for (int i = 0; i < oddIdx; i++)
            Console.Write(odd[i] + " ");
        Console.WriteLine("Even Numbers");
        for (int i = 0; i < evenIdx; i++)
            Console.Write(even[i] + " ");
    }
}
