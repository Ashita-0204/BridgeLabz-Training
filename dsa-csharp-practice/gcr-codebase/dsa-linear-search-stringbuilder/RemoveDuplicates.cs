using System;
using System.Text;

class RemoveDuplicates
{
    public static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        foreach (char c in input)
        {
            if (result.ToString().IndexOf(c) == -1)
            {
                result.Append(c);
            }
        }

        Console.WriteLine(result.ToString());
    }
}
