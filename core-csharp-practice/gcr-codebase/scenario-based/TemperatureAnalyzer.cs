using System;
class TemperatureAnalyzer
{
    public static void Main()
    {
        float[,] arr = new float[7, 24];
        Random temperature = new Random();
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 24; j++)
            {
                arr[i, j] = temperature.Next(0, 41);
            }
        }
        int input;
        do
        {
            Console.WriteLine("------------ Temperature Analyzer Menu ------------");
            Console.WriteLine("1. Find Hottest Day");
            Console.WriteLine("2. Find Coldest Day");
            Console.WriteLine("3. Average Temperature per Day");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your value: ");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    FindHottestDay(arr);
                    break;
                case 2:
                    FindColdestDay(arr);
                    break;
                case 3:
                    AverageTemperature(arr);
                    break;
                case 4:
                    Console.WriteLine("Program finished");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        } while (input != 4);
    }
    public static void FindHottestDay(float[,] arr)
    {
        float max = arr[0, 0];
        int day = 0;
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 24; j++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                    day = i;
                }
            }
        }
        Console.WriteLine("Hottest Day: Day " + day + 1);
    }
    public static void FindColdestDay(float[,] arr)
    {
        float min = arr[0, 0];
        int day = 0;
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 24; j++)
            {
                if (arr[i, j] < min)
                {
                    min = arr[i, j];
                    day = i;
                }
            }
        }
        Console.WriteLine("Coldest Day: Day " + day + 1 + " " + min + " degree celsius");
    }
    public static void AverageTemperature(float[,] arr)
    {
        for (int i = 0; i < 7; i++)
        {
            float sum = 0;
            for (int j = 0; j < 24; j++)
            {
                sum += arr[i, j];
            }
            Console.WriteLine(" Average = " + sum / 24 + " degree celsius");
        }
    }
}