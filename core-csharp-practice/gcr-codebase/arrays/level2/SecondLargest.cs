using System;

class SecondLargest
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        //initialising the array
        int maxDigit = 10;
        int[] arr = new int[maxDigit];
        int idx = 0;
        while (num != 0 && idx < maxDigit)
        {
            arr[idx] = num % 10;
            idx++;
            num = num / 10;
        }
        int largest = 0;
        int secondLargest = 0;
        for (int i = 0; i < idx; i++)
        {
            if (arr[i] > largest) //largest and sec largest
            {
                secondLargest = largest;
                largest = arr[i];
            }
            else if (arr[i] > secondLargest && arr[i] != largest)
            {
                secondLargest = arr[i];
            }
        }

        //printing statement 
        Console.WriteLine("Largest is " + largest + "and Second Largest is " + secondLargest);

    }
}