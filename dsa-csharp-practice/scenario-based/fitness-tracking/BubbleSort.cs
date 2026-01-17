using System;
namespace Sorting
{
    class BubbleSort
    {
        public static void BubbleSortt(int[] steps)
        {
            int n = steps.Length;
            for (int i = 0; i < n; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (steps[j] < steps[j + 1])
                    {
                        int temp = steps[j];
                        steps[j] = steps[j + 1];
                        steps[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        public static void DisplayLeaderBoard()
        {
            Console.WriteLine("Fitness LeaderBoard: ");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine("Rank " + i + 1 + ":" + steps[i] + " steps");
            }
        }
    }
}