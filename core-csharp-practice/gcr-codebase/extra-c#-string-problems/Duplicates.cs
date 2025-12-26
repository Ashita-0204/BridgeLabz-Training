using System;

class Duplicates
{
    public static void Main()
    {
        string str = Console.ReadLine();
        string res = "";
        for (int i = 0; i < str.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < res.Length; j++)
            {
                if (str[i] == res[j])
                {
                    found = true;
                    break;
                }
            }
            if (!found)
                res += str[i];
        }
        Console.WriteLine("After removing duplicates: " + res);
    }
}
