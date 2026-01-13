using System;
using System.Text;

class ConcatenateString
{
    public static void Main()
    {
        Console.Write("Enter number of strings: ");
        int n = int.Parse(Console.ReadLine());

        string[] arr = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter string ");
            arr[i] = Console.ReadLine();
        }

        StringBuilder sb = new StringBuilder();

        foreach (string s in arr)
        {
            sb.Append(s);
        }

        Console.WriteLine("Concatenated String: " + sb.ToString());
    }
}
