using System;

class RotationPoint
{
    public static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        //binary search
        int low = 0, high = n - 1;

        while (low < high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] > arr[high])
                low = mid + 1;
            else
                high = mid;
        }

        Console.WriteLine("Rotation point index: " + low);
    }
}
