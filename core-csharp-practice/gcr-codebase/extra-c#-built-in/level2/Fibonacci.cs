using System;

class Fibonacci
{
    public static void meth(int terms)//method
    {
        int num1 = 0, num2 = 1;

        for (int i = 1; i <= terms; i++)
        {   //finding upcoming terms
            Console.Write(num1 + " ");
            int next = num1 + num2;
            num1 = num2;
            num2 = next;
        }
    }
    public static void Main()
    {
        Console.Write("Enter terms: ");
        int num = int.Parse(Console.ReadLine());
        meth(num); //calling the method
    }
}
