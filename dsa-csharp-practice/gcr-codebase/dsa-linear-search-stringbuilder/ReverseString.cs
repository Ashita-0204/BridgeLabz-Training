using System;
using System.Text;

class ReverseString
{
    public static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder(input);
        int start = 0, end = sb.Length - 1;

        while (start < end)
        {
            char temp = sb[start];
            sb[start] = sb[end];
            sb[end] = temp;

            start++;
            end--;
        }

        Console.WriteLine("the reversed string is " + sb.ToString());
    }
}