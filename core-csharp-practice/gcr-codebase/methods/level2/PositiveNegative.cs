using System;

class PositiveNegative
{
    public static bool IsPositive(int num)
    {
        if (num < 0)
        {
            return false;
        }
        return true;
    }
    public static bool IsEven(int num)
    {
        return num % 2 == 0;
    }
    public static int Compare(int num1, int num2)
    {
        if (num1 > num2)
        {
            return 1;
        }
        if (num1 == num2)
        {
            return 0;
        }
        return -1;
    }

    public static void Main()
    {
        int[] arr = new int[5];

        for (int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (IsPositive(arr[i]))
            {
                if (IsEven(nums[i]))
                {
                    Console.WriteLine("The number is Even and positive");
                }
                else
                {
                    Console.WriteLine("The number is Odd and positive");
                }
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }

        int res = Compare(nums[0], nums[4]);
        if (result == 1)
        {
            Console.WriteLine("First > Last");
        }
        else if (result == 0)
        {
            Console.WriteLine("First = Last");
        }
        else
        {
            Console.WriteLine("First < Last");
        }
    }
}
