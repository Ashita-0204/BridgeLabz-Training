using System;

class Football
{
    public static int Sum(int[] arr)
    {
        int sum = 0; //calculating sum
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    public static double FindMean(int[] arr) //finding mean
    {
        double mean = (double)Sum(arr) / arr.Length;
        return mean;
    }

    public static int FindShortest(int[] arr) //finding shortest
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
        }
        return min;
    }
    public static int FindTallest(int[] arr) //finding tallest
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }
    public static void Main()
    {
        int[] arr = new int[11];
        Random random = new Random(); //random generation
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(150, 251);
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine("Shortest Height: " + FindShortest(arr));
        Console.WriteLine("Tallest Height: " + FindTallest(arr));
        Console.WriteLine("Mean Height: " + FindMean(arr));
    }
}
