using System;

class SumOfNums
{
    public static void Main()
    {
        double[] arr = new double[10];
        double total = 0.0;
        int index = 0;
        while (true)
        {
            double input = double.Parse(Console.ReadLine());
            if (input <= 0 || index == 10)
            {
                break;
            }
            arr[index] = input;
            index++;
        }
        //Printing arrays
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(arr[i]);
            total += arr[i];
        }
        Console.WriteLine("Total Sum " + total);
    }
}
