using System;

class Reverse
{
    static void Main()
    {
        string str = Console.ReadLine();
        string rev = "";
        //decrement loop
        for (int i = str.Length - 1; i >= 0; i--)
            rev += str[i];

        Console.WriteLine("Reversed String is " + rev);
    }
}
