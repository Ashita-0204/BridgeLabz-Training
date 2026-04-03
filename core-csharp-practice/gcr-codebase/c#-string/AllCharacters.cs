using System;
class AllCharacters
{
    public static char[] Charac(string str)
    {
        char[] arr = new char[str.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = str[i]; //all string charact in an array
        }
        return arr;
    }
    public static void Main()
    {
        string str = Console.ReadLine();
        char[] meth = GetChars(str);
        char[] arr = str.ToCharArray(); //the inbuilt method

        Console.Write("The method:");
        for (int i = 0; i < meth.Length; i++)
            Console.Write(meth[i] + " ");

        Console.WriteLine("Inbuilt:");
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }
}