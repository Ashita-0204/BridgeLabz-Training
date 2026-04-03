using System;

class PositiveNegative
{
    public static void Main()
    {
        int[] arr = new int[5];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] == int.Parse(Console.ReadLine());
        }
        //code to check positive,negative and divisibility by 2
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("The number " + arr[i] + " is Positive and Even");
                }
                else
                {
                    Console.WriteLine("The number " + arr[i] + " is Positive and Odd");
                }
            }
            else if (arr[i] < 0)
            {
                Console.WriteLine(arr[i] + " is Negative");
            }
            else
            {
                Console.WriteLine("The number is Zero");
            }
        }

        //comparing Relationally
        if (arr[0] == arr[4])
        {
            Console.WriteLine("First and Last elements are equal");
        }
        else if (arr[0] > arr[4])
        {
            Console.WriteLine("First element is Greater");
        }
        else
        {
            Console.WriteLine("Last element is Greater");
        }

    }
}