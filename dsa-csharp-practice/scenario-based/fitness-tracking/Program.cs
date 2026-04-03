using System;
namespace Sorting
{
    class Program
    {
        public static void Main()
        {
            int[] dailySteps = { 3020, 3500, 8500, 6900, 7530 };
            BubbleSort.BubbleSortt(dailySteps);
            BubbleSorting.DisplayLeaderBoard(dailySteps);
        }
    }
}
