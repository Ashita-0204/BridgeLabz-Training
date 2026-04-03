using System;

class ExamSort
{
    public static void Main()
    {
        int[] arr = { 92, 85, 32, 46, 82, 35 };

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }

        Console.WriteLine("Sorted Exam Scores:");
        foreach (int i in arr)
            Console.Write(i + " ");
    }
}
