using System;
class LowerText
{
    public static string Lower(string str)
    {
        string res = "";
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (ch >= 'A' && ch <= 'Z') //if lower convert to uppper
            {
                res += (char)(ch + 32);
            }
            else
            {
                res += ch; //small pushed as it is
            }
            return res;
        }
    }
    public static void Main()
    {
        string str = Console.ReadLine();
        Console.WriteLine("Via Method: " + Lower(str)); //the method
        Console.WriteLine("Inbuilt: " + str.ToLower()); //the inbuilt method
    }
}