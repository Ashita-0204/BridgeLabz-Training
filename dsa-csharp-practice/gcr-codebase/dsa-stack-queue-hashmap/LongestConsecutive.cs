using System;
using System.Collections.Generic;
class LongestConsecutive
{
    static int FindLongest(int[] arr)
    {
        HashSet<int> set = new HashSet<int>();
        int longest = 0;
        foreach (int i in arr)
        {
            if (!set.Contains(i - 1))
            {
                int curr = i;
                int streak = 1;
                while (set.Contains(curr + 1))
                {
                    curr++;
                    streak++;
                }
                longest = Math.Max(longest, streak);
            }
        }
        return longest;
    }
    public static void Main()
    {
        int[] nums = { 100, 4, 5, 1, 3, 2 };
        Console.WriteLine(FindLongest(nums));
    }
}