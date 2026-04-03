using System;

class Longest
{
    public static void Main()
    {
        Console.Write("Enter sentence: "); //the input
        string str = Console.ReadLine() + " ";
        string word = "", longest = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ')
                word += str[i]; //continuation
            else
            {
                if (word.Length > longest.Length)
                    longest = word;
                word = "";
            }
        }

        Console.WriteLine("Longest Word is " + longest);
    }
}
