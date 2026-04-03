using System;
class UpperText
{
    public static string Upper(string str)
    {
        string res = "";
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (ch >= 'a' && ch <= 'z') //if upper convert to lower
            {
                res += (char)(ch - 32);
            }
            else
            {
                res += ch;
            }
            return res;
        }
    }
    public static void Main()
    {
        string str = Console.ReadLine();
        Console.WriteLine("Via Method: " + Upper(str)); //the method
        Console.WriteLine("Inbuilt: " + str.ToUpper()); //the inbuilt method
    }
}