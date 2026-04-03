using System;

class Factors
{
    public static int[] fact(int num)
    {
        int len = 0;
        //arr to find length of new arr
        for (int i = 0; i < num; i++)
            if (num % i == 0)
            {
                len++;
            }
        //to store
        int[] arr = new int[count];
        int idx = 0;
        for (int i = 0; i < num; i++)
            if (num % i == 0)
                arr[idx++] = i;

        return arr;
    }

    public static int Sum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += i; //sum of all factors
        }
        return sum;
    }

    public static long Product(int[] arr)
    {
        long product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= i; //prod of factors
        }
        return product;
    }

    public static double SumOfSquares(int[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += Math.Pow(i, 2); //calc sum of squares
        }
        return sum;
    }
    public static void Main()
    {
        //input the num
        int num = int.Parse(Console.ReadLine());
        //calling the method
        int[] arr = fact(number);
        Console.WriteLine("Factors:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(i + " "); //for factors
        }
        Console.WriteLine("Sum of factors: " + Sum(arr)); //for sum
        Console.WriteLine("Product of factors: " + Product(arr)); ///for product
        Console.WriteLine("Sum of squares of factors: " + SumOfSquares(arr)); //for sum of squares
    }
}
