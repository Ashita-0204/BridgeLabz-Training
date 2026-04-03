using System;

class Players
{
    public static void Main()
    {
        double[] arr = new double[11];
        double sum = 0.0;
        for (int i = 0; i < 11; i++)
        {
            arr[i] = double.Parse(Console.ReadLine());
            sum += arr[i];
        }
        double mean = sum / 11;
        Console.WriteLine("Mean Heightof the 11 players is " + mean);
    }
}
