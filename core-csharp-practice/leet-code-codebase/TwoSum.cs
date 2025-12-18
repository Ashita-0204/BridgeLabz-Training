using System;

public class TwoSum
{
    public static bool twoSum(int[] arr, int target)
    {
        int len = arr.Length;
        for (int i = 0; i < len; i++)
        {
            for (int j = i + 1; j < len; j++)
            {
                if (arr[i] + arr[j] == target)//value of idx==target
                {
                    return true;
                }
            }
        }
        return false;
    }
    public static void Main(String[] args)
    {
        int len = int.Parse(Console.ReadLine());
        int[] arr = new int[len];//Array input
        for (int i = 0; i < len; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the target"); //target
        int target = int.Parse(Console.ReadLine()); //calling funct
        if (twoSum(arr, target))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }


}
