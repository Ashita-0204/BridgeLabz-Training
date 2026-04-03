using System;

class CountStudent
{
    public static void Main()
    {
        int[] arr = { 11, 15, 16, 12, 16, 11 };
        int min = 10, max = 18;

        int[] count = new int[max - min + 1];

        foreach (int i in arr)
        {
            count[i - min]++;
        }

        Console.WriteLine("Sorted Student Ages:");
        for (int i = 0; i < count.Length; i++)
            while (count[i]-- > 0)
                Console.Write((i + min) + " ");
    }
}
