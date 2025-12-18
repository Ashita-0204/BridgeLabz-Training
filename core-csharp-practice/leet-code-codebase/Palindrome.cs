using System;
public class Palindrome
{
    public static bool isPalindrome(String str) //function
    {
        int left = 0;
        int right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right]) //first n last idx check
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
    public static void Main(String[] args)
    {
        String s = Console.ReadLine();
        Console.WriteLine(isPalindrome(s)); //calling
    }
}