using System;

class TwoDimensional
{
    public static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        int[,] matrix = new int[row, col];
        int[] arr = new int[row * col];
        int idx = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write("Enter element ");
                matrix[i, j] = int.Parse(Console.ReadLine());
                arr[index++] = matrix[i, j];
            }
        }
        Console.WriteLine("1 Dimensional array");
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }
}
