using System;

class RandomAvg
{
    public static int[] Generate4DigitRandomArray(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = rand.Next(1000, 10000);
        return arr;
    }
    public static double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers[0], max = numbers[0], sum = 0;
        for (int i = 0; i < numbers; i++)
        {
            sum += i;
            min = Math.Min(min, i);
            max = Math.Max(max, i);
        }

        return new double[] { (double)sum / numbers.Length, min, max };
    }
    public static void Main()
    {
        int[] numbers = Generate4DigitRandomArray(5);
        double[] result = FindAverageMinMax(numbers);
        Console.WriteLine("Numbers:");
        for (int i = 0; i < numbers; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("Average" + result[0] + "Min " + result[1] + "Max " + result[2]);
    }
}
