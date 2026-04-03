using System;
using System.Diagnostics;

class RecursiveVsIterativeFibonacci
{
    public static void Main()
    {
        int n = 30;
        Stopwatch sw = new Stopwatch();
        sw.Start();
        FibonacciRecursive(n);
        sw.Stop();
        Console.WriteLine("Recursive Time: " + sw.ElapsedMilliseconds + " ms");

        // Iterative Fibonacci
        sw.Restart();
        FibonacciIterative(n);
        sw.Stop();
        Console.WriteLine("Iterative Time: " + sw.ElapsedMilliseconds + " ms");
    }

    // Recursive Fibonacci Method to find nth term
    static int FibonacciRecursive(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        // Recursive call   
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Iterative Fibonacci Method to find nth term
    static int FibonacciIterative(int n)
    {
        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int sum = a + b;                    // Calculate next Fibonacci number
            a = b;
            b = sum;
        }
        return b;
    }
}
