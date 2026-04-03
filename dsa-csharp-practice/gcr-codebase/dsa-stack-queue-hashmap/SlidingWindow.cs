using System;
using System.Collections.Generic;
class SlidingWindow
{
    static async Task FindMax(int[] arr, int k)
    {
        LinkedList<int> ll = new LinkedList<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (ll.Count > 0 && ll.First.Value <= i - k)
            {
                ll.RemoveFirst();
            }
            while (ll.Count > 0 && arr[ll.Last.Value] <= arr[i])
            {
                ll.RemoveLast();
            }
            ll.AddLast();
            if (i >= k - 1)
            {
                Console.Write(arr[ll.First.Value] + " ");
            }
        }
    }
    public static void Main()
    {
        int[] arr = { 1, 2, -1, -5, 6, 7, 8, 3, -2 };
        int k = 2;

        FindMax(arr, k);
    }
}