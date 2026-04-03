using System;

class Anagram
{
    public static void Main()
    {
        string str = Console.ReadLine().ToLower();
        string strr = Console.ReadLine().ToLower();

        if (str.Length != strr.Length) //unequal length
        {
            Console.WriteLine("Not Anagrams");
            return;
        }

        int[] count = new int[26];
        for (int i = 0; i < str.Length; i++)
        {
            count[str[i] - 'a']++;
            count[strr[i] - 'a']--;
        }
        for (int i = 0; i < 26; i++)
        {
            if (count[i] != 0)
            {
                Console.WriteLine("Not Anagrams");
                return;
            }
        }
        Console.WriteLine("Strings are Anagrams");
    }
}
