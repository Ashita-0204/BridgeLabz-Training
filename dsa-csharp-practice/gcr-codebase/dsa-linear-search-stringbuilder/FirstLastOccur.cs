using System;

class FirstAndLastOccur
{
    static int FindFirst(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1, result = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;      // Calculate mid index

            if (arr[mid] == target)
            {// Check if target is found
                result = mid;
                high = mid - 1;
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return result;
    }

    static int FindLast(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1, result = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;// Calculate mid index

            if (arr[mid] == target)
            {// Check if target is found
                result = mid;
                low = mid + 1;
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return result;
    }

    public static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter sorted array elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter target element: ");
        int target = int.Parse(Console.ReadLine());

        Console.WriteLine("First Occurrence: " + FindFirst(arr, target));
        Console.WriteLine("Last Occurrence: " + FindLast(arr, target));
    }
}