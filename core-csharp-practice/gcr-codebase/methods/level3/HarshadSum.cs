using System;
class HarshadSum
{
    public static int SumOfDigits(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];
        return sum;
    }

    public static double SumOfSquares(int[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += Math.Pow(arr[i], 2);
        return sum;
    }

    public static bool IsHarshad(int num, int[] arr)
    {
        return num % SumOfDigits(arr) == 0;
    }

    public static int[,] DigitCount(int[] arr)
    {
        int[,] freq = new int[10, 2];

        for (int i = 0; i < 10; i++)
        {
            freq[i, 0] = i;
            freq[i, 1] = 0;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            freq[arr[i], 1]++;
        }

        return freq;
    }
}
