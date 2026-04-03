using System;
class Substring
{
    public static void Substr(string str, int start, int end)
    {
        int sub = ""; //empty str to store the substr
        for (int i = start; i <= end; i++)
        {
            sub += str[i];
        }
        return sub;
    }
    public static void Main()
    {
        //input
        string str = Console.ReadLine();
        int start = int.Parse(Console.ReadLine()); //starting idx
        int end = int.Parse(Console.ReadLine()); //ending idx
        string subStr = Substr(str, start, end); //calling method
        Console.WriteLine("The substrings is " + subStr);
    }
}