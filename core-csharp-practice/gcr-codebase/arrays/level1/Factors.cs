using System;
class Factors
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int maxFactor = 0, idx = 0;
        int[] arr = new int[10];
        for (int i = 0; i <= num; i++)
        {
            if (num % i == 0) //calculating factors
            {
                if (idx == maxFactor)
                {
                    maxFactor *= 2; //conditioning
                    int[] numss = new int[10];
                    for (int i = 0; i < numss.Length; i++)
                        temp[i] = arr[i];
                    arr = temp;
                }
                arr[idx++] = i;
            }
        }
        Console.WriteLine("The factors are");
        for (int i = 0; i < idx; i++)
            Console.Write(arr[i] + ",");
    }
}