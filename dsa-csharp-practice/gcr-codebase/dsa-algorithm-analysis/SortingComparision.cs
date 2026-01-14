using System;
using System.Diagnostics;
class SortingComparision
{
    public static void Main()
    {
        int n = 10000;
        int[] arr1 = GenerateArray(n);          // Generate random array
        int[] arr2 = (int[])arr1.Clone();
        int[] arr3 = (int[])arr1.Clone();

        Stopwatch sw = new Stopwatch();         // Stopwatch for timing

        // Bubble Sort 
        sw.Start();
        BubbleSort(arr1);
        sw.Stop();
        Console.WriteLine("Bubble Sort Time: " + sw.ElapsedMilliseconds + " ms");

        // Merge Sort
        sw.Restart();
        MergeSort(arr2, 0, arr2.Length - 1);
        sw.Stop();
        Console.WriteLine("Merge Sort Time: " + sw.ElapsedMilliseconds + " ms");

        // Quick Sort
        sw.Restart();
        QuickSort(arr3, 0, arr3.Length - 1);
        sw.Stop();
        Console.WriteLine("Quick Sort Time: " + sw.ElapsedMilliseconds + " ms");
    }


    // Generate random array
    static int[] GenerateArray(int n)
    {
        Random r = new Random();
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = r.Next(1, 100000);
        return arr;
    }

    // Bubble Sort Method to sort array
    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        { // Outer loop for passes
            for (int j = 0; j < arr.Length - i - 1; j++)
            { // Inner loop for comparisons
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }
    }

    // Merge Sort Method to sort array
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right) { return; } // Base case
        int mid = (left + right) / 2;     // Find mid index
        MergeSort(arr, left, mid);  // Sort left half
        MergeSort(arr, mid + 1, right);// Sort right half
        Merge(arr, left, mid, right); // Merge sorted halves
    }

    // Merge helper method
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0; // Pointers for left, right and temp arrays

        while (i <= mid && j <= right)
        {
            temp[k++] = arr[i] < arr[j] ? arr[i++] : arr[j++];
        }

        while (i <= mid) temp[k++] = arr[i++];  // Adding the remaining elements
        while (j <= right) temp[k++] = arr[j++];

        Array.Copy(temp, 0, arr, left, temp.Length);
    }

    // Quick Sort Method to sort array
    static void QuickSort(int[] arr, int low, int high)
    {// Base case
        if (low >= high)
        {
            return;
        }

        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                (arr[++i], arr[j]) = (arr[j], arr[i]);
            }

            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        }

        QuickSort(arr, low, i);
        QuickSort(arr, i + 2, high);
    }
}
