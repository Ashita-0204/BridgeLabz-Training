using System;

public class RemoveDuplicates
{
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) // base case
        {
            return 0;
        }

        int p1 = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[p1] != nums[i]) // if not duplicate
            {
                p1++;
                nums[p1] = nums[i];
            }
        }
        return p1 + 1;
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++) //array inp
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int k = RemoveDuplicates(arr);

        for (int i = 0; i < k; i++) //final ans
        {
            Console.Write(arr[i] + " ");
        }
    }
}
