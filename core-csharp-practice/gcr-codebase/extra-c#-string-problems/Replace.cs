using System;

class Replace
{
    public static void Main()
    {
        //inputs

        string main = Console.ReadLine();
        Console.Write("Old Word to be changed");
        string old = Console.ReadLine();
        Console.Write("Updated Word");
        string neww = Console.ReadLine();

        //inbuilt method
        string res = main.Replace(old, neww);
        Console.WriteLine("Updated Sentence is " + res);
    }
}
