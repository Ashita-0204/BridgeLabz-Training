using System;

class Palindrome
{
    public static bool IsValid(string str)
    {
        int start = 0, end = str.Length - 1;

        while (start < end) //checking charact
        {
            if (str[start] != str[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }

    public static void Main()
    {
        Console.Write("Enter string ");
        string str = Console.ReadLine();
        if (IsValid(str)) //calling method
        {
            Console.WriteLine("Is Palindrome ");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }

    }
}
