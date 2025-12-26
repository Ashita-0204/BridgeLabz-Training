using System;

class ToggleCase
{
    public static void Main()
    {
        string str = Console.ReadLine();
        string res = "";

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (ch >= 'a' && ch <= 'z') //lower to upper
            {
                res += (char)(ch - 32);
            }
            else if (ch >= 'A' && ch <= 'Z') //upper to lower
            {
                res += (char)(ch + 32);
            }
            else
                res += ch;
        }

        Console.WriteLine("Toggled String is " + res);
    }
}
