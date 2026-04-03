using System;
class Handshakes
{
    public static void maxShakes(int num) //calculation of combination
    {
        int calc = (num * (num - 1)) / 2;
        return calc;
    }
    public static void Main()
    {
        Console.Write("Number:"); //the input
        int num = int.Parse(Console.ReadLine());
        //calling the method
        int ans = maxShakes(num);
        //Printing statement
        Console.WriteLine("The max number of handshakes are " + ans);
    }
}