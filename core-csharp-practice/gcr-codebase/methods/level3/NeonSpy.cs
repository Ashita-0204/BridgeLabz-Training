class NeonSpy
{
    //required classes
    public static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsNeon(int num)
    {
        int sq = num * num, sum = 0;
        while (sq > 0)
        {
            sum += sq % 10;
            sq /= 10;
        }
        return sum == num;
    }
    public static bool IsSpy(int[] arr)
    {
        int sum = 0, product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            product *= arr[i];
        }
        return sum == product;
    }
    public static bool IsAutomorphic(int num)
    {
        return (num * num).ToString().EndsWith(num.ToString());
    }

    public static bool IsBuzz(int num)
    {
        return num % 7 == 0 || num % 10 == 7;
    }
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] digits = StoreDigits(num);

        // Prime check
        if (IsPrime(number))
        {
            Console.WriteLine(" Prime Number");
        }
        else
        {
            Console.WriteLine("Not Prime Number");
        }

        // Neon number
        if (IsNeon(number))
        {
            Console.WriteLine("Neon Number");
        }
        else
        {
            Console.WriteLine("Not Neon Number");
        }

        // Spy number
        if (IsSpy(digits))
        {
            Console.WriteLine(" Spy Number");
        }
        else
        {
            Console.WriteLine("Not Spy Number");
        }

        // Automorphic number
        if (IsAutomorphic(number))
        {
            Console.WriteLine("Automorphic Number");
        }
        else
        {
            Console.WriteLine("Not Automorphic Number");
        }

    }
}