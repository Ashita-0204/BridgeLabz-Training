using System;
class SearchTargetTwoD
{
    public static void Main()
    {
        // Get matrix dimensions from user
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];         // Declare 2D matrix

        Console.WriteLine("Enter matrix elements row-wise:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                matrix[i, j] = int.Parse(Console.ReadLine());
        }

        // Get target value from user
        Console.Write("Enter target value: ");
        int target = int.Parse(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < rows; i++)
        {
            int low = 0, high = cols - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2; // Calculate mid index

                if (matrix[i, mid] == target)
                { // Check if target is found
                    found = true;
                    break;
                }
                else if (matrix[i, mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
        }
        Console.WriteLine(found ? "Target found" : "Target not found");
    }
}