using System;
class FirstMissingPos
{
    public static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        //  Linear Search
        int firstMissing = FindFirstMissingPositive(arr);
        Console.WriteLine(" First Missing Positive Number: " + firstMissing);

        //Binary Search 
        Console.WriteLine("Enter target value to search: ");
        int target = int.Parse(Console.ReadLine());
        Array.Sort(arr);
        int index = BinarySearch(arr, target);
        if (index != -1)
        {
            Console.WriteLine("Target found");
        }
        else
        {
            Console.WriteLine("Target not found.");
        }
    }
    static int FindFirstMissingPositive(int[] nums)
    {
        int n = nums.Length;
        bool[] visited = new bool[n + 1];
        // Mark visited positive numbers
        for (int i = 0; i < n; i++)
        {
            if (nums[i] > 0 && nums[i] <= n)
            {
                visited[nums[i]] = true;
            }
        }
        // Find first missing positive
        for (int i = 1; i <= n; i++)
        {
            if (!visited[i])
                return i;
        }

        return n + 1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}
