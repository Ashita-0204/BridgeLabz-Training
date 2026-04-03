using System;
using System.Collections.Generic;
class SubArrayWithZero
{
    static bool Exists(int[] arr)
    {
        HashSet<int> set = new HashSet<int>();
        int sum = 0;
        foreach (int x in arr)
        {
            sum += x;
            if (sum == 0 || set.Contains(sum))
            {
                return true;
            }
            set.Add(sum);
        }
        return false;
    }
    public static void Main()
    {
        int[] arr = { 4, 2, -3, 1, 6 };
        Console.WriteLine(Exists(arr));
    }
}