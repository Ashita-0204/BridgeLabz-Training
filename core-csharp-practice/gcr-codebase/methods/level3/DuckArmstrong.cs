using System;
class DuckArmstrong
{
    //counting via string conversion
    public static int CountDigits(int num)
    {
        return num.ToString().Length;
    }
    // storing them in arr
    public static int[] Store(int num)
    {
        string str = num.ToString();
        int[] arr = new int[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = str[i] - '0';
        }
        return digits;
    }
    //to check for duck number
    public static bool IsDuckNumber(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
                return true;
        }
        return false;
    }
    //to check armstrongS
    public static bool IsArmstrong(int num, int[] arr)
    {
        int power = arr.Length;
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += (int)Math.Pow(arr[i], power);
        }
        return sum == num;
    }
    // Find largest and second largest
    public static int[] FindLargestAndSecondLargest(int[] arr)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                secondLargest = largest;
                largest = arr[i];
            }
            else if (arr[i] > secondLargest && arr[i] != largest)
            {
                secondLargest = arr[i];
            }
        }
        return new int[] { largest, secondLargest };
    }

    //Find smallest and second smallest
    public static int[] FindSmallestAndSecondSmallest(int[] arr)
    {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < smallest)
            {
                secondSmallest = smallest;
                smallest = arr[i];
            }
            else if (arr[i] < secondSmallest && arr[i] != smallest)
            {
                secondSmallest = arr[i];
            }
        }
        return new int[] { smallest, secondSmallest };
    }
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int digitCount = NumberChecker1.CountDigits(number);
        Console.WriteLine("Digit Count: " + digitCount);

        int[] digits = StoreDigits(number);

        // Duck Number
        if (NumberChecker1.IsDuckNumber(digits))
            Console.WriteLine("It is a Duck Number");
        else
            Console.WriteLine("It is NOT a Duck Number");

        // Armstrong Number
        if (NumberChecker1.IsArmstrong(number, digits))
            Console.WriteLine("It is an Armstrong Number");
        else
            Console.WriteLine("It is NOT an Armstrong Number");

        // Largest & Second Largest
        int[] largest = NumberChecker1.FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest Digit: " + largest[0]);
        Console.WriteLine("Second Largest Digit: " + largest[1]);

        // Smallest & Second Smallest
        int[] smallest = NumberChecker1.FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest Digit: " + smallest[0]);
        Console.WriteLine("Second Smallest Digit: " + smallest[1]);
    }
}


