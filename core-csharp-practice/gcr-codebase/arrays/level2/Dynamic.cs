using System;

class Dynamic
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int maxDigit = 10;
        int[] arr = new int[maxDigit];
        int idx = 0;
        while (num != 0) //for arr
        {
            if (idx == maxDigit)
            {
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                for (int i = 0; i < arr.Length; i++)
                {
                    temp[i] = arr[i];
                }
                digit = temp;
            }
            arr[idx] = num % 10;
            idx++;
            num = num / 10;
        }
        int largest = 0;
        int secondLargest = 0;
        for (int i = 0; i < idx; i++)
        {
            if (arr[i] > largest)
            {
                secondLargest = largest; //largest n second largest
                largest = arr[i];
            }
            else if (arr[i] > secondLargest && arr[i] != largest)
            {
                secondLargest = arr[i];
            }
        }
        //printing statement
        Console.WriteLine("Largest = " + largest + "Second Largest " + secondLargest);
    }
}