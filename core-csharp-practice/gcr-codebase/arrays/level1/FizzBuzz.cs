using System;

class FizzBuzz
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num <= 0)
        {
            Console.WriteLine("Invalid");
            return;
        }
        string[] arr = new string[num + 1];
        for (int i = 1; i <= num; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            { arr[i] = "FizzBuzz"; }
            else if (i % 3 == 0)
            { arr[i] = "Fizz"; }
            else if (i % 5 == 0)
            { arr[i] = "Buzz"; }
            else
            { arr[i] = i.ToString(); }
        }

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(i + " . " + arr[i]);
        }
    }
}
