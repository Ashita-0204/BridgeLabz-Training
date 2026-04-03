using System;
using System.Globalization;
class WordSplit
{
    public static int getLen(string str)
    {
        int lenn = 0;
        for (char ch = 0; ch < str.Length; ch++)
        {
            lenn++;
        }
        return lenn;
    }

    public static string[,] split(string str)
    {
        int count = 1;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                count++;
            }
        }

        string[,] res = new string[count, 2];
        string newWord = "";
        int idx = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ')
            {
                newWord += str[i];
            }
            else
            {
                res[idx, 0] = newWord;
                res[idx, 1] = getLen(newWord).ToString();
                idx++;
                newWord = "";

            }
        }
        res[idx, 0] = newWord;
        res[idx, 1] = getLen(newWord).ToString();
        return res;
    }
    public static void Main()
    {
        string str = Console.ReadLine();
        string[,] words = SplitWords(str);

        Console.WriteLine("Word\tLength");
        for (int i = 0; i < words.getLen(0); i++)
        {
            Console.WriteLine(words[i, 0] + "\t" + words[i, 1]);
        }
    }
}