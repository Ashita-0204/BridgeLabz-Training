using System;

public class Operators
{
    public static void Main(String[] args)
    {
        int num1 = 10;
        int num2 = 5;

        // Arithmetic Operators
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine("Addition: " + (num1 + num2));
        Console.WriteLine("Subtraction: " + (num1 - num2));
        Console.WriteLine("Multiplication: " + (num1 * num2));
        Console.WriteLine("Division: " + (num1 / num2));
        Console.WriteLine("Modulus: " + (num1 % num2));

        // Comparison Operators
        Console.WriteLine("Comparison Operators:");
        Console.WriteLine("Equal to: " + (num1 == num2));
        Console.WriteLine("Not equal to: " + (num1 != num2));
        Console.WriteLine("Greater than: " + (num1 > num2));
        Console.WriteLine("Less than: " + (num1 < num2));
        Console.WriteLine("Greater than or equal to: " + (num1 >= num2));
        Console.WriteLine("Less than or equal to: " + (num1 <= num2));

        // Logical Operators
        Console.WriteLine("Logical Operators:");
        Console.WriteLine("Logical AND: " + (num1 > 0 && num2 > 0));
        Console.WriteLine("Logical OR: " + (num1 > 0 || num2 < 0));
        Console.WriteLine("Logical NOT: " + !(num1 > 0));

        // Assignment Operators
        Console.WriteLine("Assignment Operators:");
        int c = num1;
        Console.WriteLine("Assignment: " + c);
        c += num2;
        Console.WriteLine("Addition Assignment: " + c);
        c -= num2;
        Console.WriteLine("Subtraction Assignment: " + c);
        c *= num2;
        Console.WriteLine("Multiplication Assignment: " + c);
        c /= num2;
        Console.WriteLine("Division Assignment: " + c);
        c %= num2;
        Console.WriteLine("Modulus Assignment: " + c);

        // Increment and Decrement Operators
        Console.WriteLine("Increment and Decrement Operators:");

        Console.WriteLine("Initial value of num1: " + num1);
        Console.WriteLine("Post-increment num1: " + (num1++));
        Console.WriteLine("Value of num1 after post-increment: " + num1);
        Console.WriteLine("Pre-increment num1: " + (++num1));
        Console.WriteLine("Post-decrement num1: " + (num1--));
        Console.WriteLine("Pre-decrement num1: " + (--num1));
    }
}
