using System;

class RemoveCharacter
{
    public static void Main()
    {
        //input
        string str = Console.ReadLine();
        char ch = Console.ReadLine()[0]; //the char input
        string res = "";

        for (int i = 0; i < str.Length; i++)
            if (str[i] != ch)
            {
                res += str[i];
            }
        Console.WriteLine("Modified String is" + res);
    }
}
