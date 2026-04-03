using System;
using System.Collections.Generic;

class PairSum
{
    static bool HasPair(int[] arr, int target)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (int x in arr)
        {
            if (set.Contains(target - x))
            {
                return true;
            }
            set.Add(x);
        }
        return false;
    }
    public static void Main()
    {
        int[] arr = { 8, 9, 1, 3, 6 };
        int target = 10;

        Console.WriteLine(HasPair(arr, target));
    }
}