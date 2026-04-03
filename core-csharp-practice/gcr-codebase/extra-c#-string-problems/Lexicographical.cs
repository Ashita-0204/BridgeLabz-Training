using System;

class Lexicographical
{
    public static void Main()
    {//inpiut
        string str = Console.ReadLine();
        string strr = Console.ReadLine();

        int len = 0;
        if (str.Length < strr.Length) //highest length opted
        {
            len = str.Length;
        }
        else
        {
            len = strr.Length;
        }
        bool decided = false;

        for (int i = 0; i < len; i++)
        {
            if (str[i] < strr[i]) //evaluating
            {
                Console.WriteLine("First string comes before string 2");
                decided = true;
                break;
            }
            else if (str[i] > strr[i])
            {
                Console.WriteLine("Second string comes before string 1");
                decided = true;
                break;
            }
        }

        if (!decided)
        {
            if (str.Length == strr.Length) //comparision
            {
                Console.WriteLine("Both strings are equal");
            }
            else if (str.Length < s2.Length)
            {
                Console.WriteLine("First string comes before second one");
            }
            else
            {
                Console.WriteLine("Second string comes before string 1");
            }
        }
    }
}
