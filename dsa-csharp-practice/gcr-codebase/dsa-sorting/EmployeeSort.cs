using System;

class EmployeeSort
{
    public static void Main()
    {
        int[] arr = { 101, 101, 109, 113, 102 };

        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }

        Console.WriteLine("Sorted Employee IDs:");
        foreach (int i in arr)
            Console.Write(i + " ");
    }
}
