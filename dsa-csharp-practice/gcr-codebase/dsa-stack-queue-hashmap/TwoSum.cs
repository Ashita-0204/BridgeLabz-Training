using System;
using System.Collections.Generic;

class TwoSum
{
    static int[] FindIdx(int[] arr, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int need = target - arr[i];
            if (map.ContainsKey(need))
                return new int[] { map[need], i };

            map[arr[i]] = i;
        }
        return new int[] { -1, -1 };
    }
    public static void Main()
    {
        int[] arr = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = FindIdx(arr, target);
        Console.WriteLine(result[0] + " " + result[1]);
    }
}