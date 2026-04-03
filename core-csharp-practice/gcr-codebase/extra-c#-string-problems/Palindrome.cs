using System;

class Palindrome
{
    public static void Main()
    {
        string str = Console.ReadLine();
        string rev = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            rev += str[i];
        }
        if (str == rev)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }
    }
}
