using System;
class BookSort
{
    public static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;

        while (i <= mid && j <= right)
        {
            temp[k++] = (arr[i] <= arr[j]) ? arr[i++] : arr[j++];
        }


        while (i <= mid)
        {
            temp[k++] = arr[i++];
        }
        while (j <= right)
        {
            temp[k++] = arr[j++];
        }

        for (i = left, k = 0; i <= right; i++, k++)
        {
            arr[i] = temp[k];
        }
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Main()
    {
        int[] arr = { 125, 520, 658, 985, 462 };
        MergeSort(arr, 0, arr.Length - 1);

        Console.WriteLine("Sorted Book Prices:");
        foreach (int i in arr)
            Console.Write(p + " ");
    }
}
